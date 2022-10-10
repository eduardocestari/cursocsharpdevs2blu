using Devs2Blu.ProjetosAula.SistemaCadastro.Forms.Data;
using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Enum;
using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Forms
{
    public partial class Form1 : Form
    {
        public MySqlConnection Conn { get; set; }
        public ConvenioRepository ConvenioRepository = new ConvenioRepository();
        public PacienteRepository PacienteRepository = new PacienteRepository();
        public EnderecoRepository EnderecoRepository = new EnderecoRepository();

        

        public Form1()
        {
            InitializeComponent();
        }

        #region Events

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulaComboConvenio();
            PopulaDataGridPessoa();
            txtNome.Focus();

        }

        #region Methods

        private void PopulaComboConvenio()
        {
            var listConvenio = ConvenioRepository.FetchAll();
            cboConvenio.DataSource = new BindingSource(listConvenio, null);
            cboConvenio.DisplayMember = "nome";
            cboConvenio.ValueMember = "id";


        }

        private void LimpaForms()
        {
            txtNome.Text = "";
            txtCGCCPF.Text = "";

            if (lblCGCCPF.Text == "CPF")
            {
                txtCGCCPF.Mask = "000.000.000-00";
            }
            else if (lblCGCCPF.Text == "CNPJ")
            {
                txtCGCCPF.Mask = "00.000.000/000-00";
            }

            cboConvenio.SelectedValue = 0;

            mskCEP.Text = "";
            mskCEP.Mask = "00.000-000";
            txtRua.Text = "";
            txtNumero.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            cboUF.Text = "";

            txtNumeroProntuario.Text = "";
            txtPacienteRisco.Text = "";
        }

        private void PopulaDataGridPessoa()
        {
            var listPessoas = PacienteRepository.GetPessoas();
            gridPacientes.DataSource = new BindingSource(listPessoas, null);

        }

        private String ValidaFormCadastro()
        {
            if (txtNome.Text.Equals("")) return "O campo nome é obrigatório";
            if (txtCGCCPF.Text.Equals("")) return "O campo de documento é obrigatório";
            if (cboConvenio.Text.Equals("")) return "O campo convenio é obrigatório";
            if (txtCidade.Text.Equals("")) return "O campo cidade é obrigatório";
            if (txtBairro.Text.Equals("")) return "O campo bairro é obrigatório";
            if (txtRua.Text.Equals("")) return "O campo rua é obrigatório";
            if (txtNumero.Text.Equals("")) return "O campo numero é obrigatório";
            if (!(rdFisica.Checked || rdJuridica.Checked)) return "Selecione o tipo de usuário";
            return "";
        }

        #endregion

        private void rdFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (rdFisica.Checked)
            {
                lblCGCCPF.Text = "CPF";
                lblCGCCPF.Visible = true;
                txtCGCCPF.Visible = true;
                //txtCGCCPF.Mask = "___.___.___-__";
            }
        }

        private void rdJuridica_CheckedChanged(object sender, EventArgs e)
        {
            if (rdJuridica.Checked)
            {
                lblCGCCPF.Text = "CNPJ";
                lblCGCCPF.Visible = true;
                txtCGCCPF.Visible = true;
                //txtCGCCPF.Mask = "__.___.___/____-__";
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e) 
        { 
            if (ValidaFormCadastro().Equals(""))
            {

                Pessoa pessoa = new Pessoa();
                pessoa.Nome = txtNome.Text;
                pessoa.CGCCPF = txtCGCCPF.Text.Replace(',', '.');              

                Paciente paciente = new Paciente();
                Convenio convenio = new Convenio();
                convenio.Id = (int)cboConvenio.SelectedValue;
                paciente.NrProntuario = Int32.Parse(txtNumeroProntuario.Text);
                paciente.PacienteRisco = txtPacienteRisco.Text;

                var pacienteResult = PacienteRepository.Salve(pessoa,paciente, convenio);
                Endereco endereco = new Endereco(pessoa, mskCEP.Text.Replace(',', '.'), txtRua.Text, Int32.Parse(txtNumero.Text), txtBairro.Text, txtCidade.Text, cboUF.Text);
                EnderecoRepository.SalveEndereco(endereco);

                if (pacienteResult.Id > 0)
                {
                    MessageBox.Show($"Pessoa {pessoa.Id} - {pessoa.Nome} salva com sucesso!", "Adicionar Pessoa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    PopulaDataGridPessoa();
                    LimpaForms();
                }
            }
        
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistema de Cadastro Hospitalar Versão 1.0");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Id = (int)gridPacientes.CurrentRow.Cells[0].Value;
            if (PacienteRepository.Delete(pessoa))
            {
                MessageBox.Show("Paciente apagado com sucesso", "Deletar paciente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult = MessageBox.Show("Paciente possui informações salvas no banco, deseja apagar mesmo assim?", "Deletar Paciente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult == DialogResult.Yes)
                {
                    pessoa.Id = (int)gridPacientes.CurrentRow.Cells[0].Value;
                    EnderecoRepository.DeletePessoa(pessoa.Id);
                    PacienteRepository.DeletePaciente(pessoa);
                    PacienteRepository.Delete(pessoa);
                }
                else
                {
                    Close();
                }
            }
            PopulaDataGridPessoa();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistema de Cadastro Hospitalar Versão 1.0");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            LimpaForms();
        }


        #endregion
    }
}
