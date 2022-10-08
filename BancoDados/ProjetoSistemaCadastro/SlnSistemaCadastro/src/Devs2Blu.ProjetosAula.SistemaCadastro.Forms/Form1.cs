using Devs2Blu.ProjetosAula.SistemaCadastro.Forms.Data;
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

        

        public Form1()
        {
            InitializeComponent();
        }

        #region Events

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulaComboConvenio();
            PopulaDataGridPessoa();

        }

        #region Methods

        private void PopulaComboConvenio()
        {
            var listConvenio = ConvenioRepository.FetchAll();
            cboConvenio.DataSource = new BindingSource(listConvenio, null);
            cboConvenio.DisplayMember = "nome";
            cboConvenio.ValueMember = "id";


        }

        private void PopulaDataGridPessoa()
        {
            var listPessoas = PacienteRepository.GetPessoas();
            gridPacientes.DataSource = new BindingSource(listPessoas, null);

        }

        private bool ValidaFormCadastro()
        {
            if (txtNome.Text.Equals(""))
                return false;
            if (txtCGCCPF.Text.Equals(""))
                return false;
            /*if (txtBairro.Text.Equals(""))
                return false;
            if (txtCidade.Text.Equals(""))
                return false;
            if (txtNumero.Text.Equals(""))
                return false;
            if (txtRua.Text.Equals(""))
                return false;
            if (mskCEP.Text.Equals(""))
                return false;
            if (cboConvenio.SelectedIndex == -1)
                return false;
            if (cboUF.SelectedIndex == -1)
                return false;*/

            return true;
        }

        #endregion

        private void rdFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (rdFisica.Checked)
            {
                lblCGCCPF.Text = "CPF";
                lblCGCCPF.Visible = true;
                txtCGCCPF.Visible = true;
            }
        }

        private void rdJuridica_CheckedChanged(object sender, EventArgs e)
        {
            if (rdJuridica.Checked)
            {
                lblCGCCPF.Text = "CNPJ";
                lblCGCCPF.Visible = true;
                txtCGCCPF.Visible = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e) 
        { 
            if (ValidaFormCadastro())
            {
                Paciente paciente = new Paciente();
                paciente.Pessoa.Nome = txtNome.Text;
                paciente.Pessoa.CGCCPF = txtCGCCPF.Text.Replace(',','.');
                paciente.Convenio.Id = (int) cboConvenio.SelectedValue;
                MessageBox.Show($"Convenio {paciente.Convenio.Id}");

                var pacienteResult = PacienteRepository.Salve(paciente);
                if (pacienteResult.Pessoa.Id > 0)
                {
                    MessageBox.Show($"Pessoa {paciente.Pessoa.Id} - {paciente.Pessoa.Nome} salva com sucesso!", "Adicionar Pessoa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    PopulaDataGridPessoa();
                }

            }
        
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        #endregion

        
       
    }
}
