using Devs2Blu.ProjetosAula.AulaOOP2Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Devs2Blu.ProjetosAula.AulaOOP2
{
    public partial class frmContato : Form
    {

        public Contato Contato { get; set; }

        public frmContato()
        {
            InitializeComponent();
        }

        #region Eventos
        private void frmContato_Load(object sender, EventArgs e)
        {
            //INSTACIAR OBJETO
            Contato = new Contato();
        }

        
        private void btEnviar_Click(object sender, EventArgs e)
        {
            if (!ValidaForm())
            {
                MessageBox.Show(this, "Preencha todos os campos!","Erro - Formulário de Contato",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            BindClass();


            String TextoMsg = $"{tbNome.Text}, texto enviado com sucesso!";
            MessageBox.Show(this, TextoMsg, "Formulário de Contato");

        }

        //Métodos 
        private void btLimpar_Click(object sender, EventArgs e)
        {
            LimparForm();
        }

        private void tbCep_TextChanged(object sender, EventArgs e)
        {
            if(tbCep.Text.Length == 8)
            {
                tbRua.Text = "7 de Setembro";
                tbBairro.Text = "Centro";
                tbCidade.Text = "Blumenau";
                tbEstado.Text = "Santa Catarina";
            } else
            {
                tbBairro.Clear();
                tbCidade.Clear();
                tbEstado.Clear();
                tbRua.Clear();
            }
        }

        #endregion
        #region Metodos

        public void BindClass()
        {
            Contato.Nome = tbNome.Text;
            Contato.TelCel = tbTelCel.Text;
            Contato.Email = tbEmail.Text;
            Contato.CEP = tbCep.Text;
            Contato.Rua = tbRua.Text;
        }

        public void LimparForm()
        {
            tbBairro.Clear();
            tbCep.Clear();
            tbCidade.Clear();
            tbEmail.Clear();
            tbEstado.Clear();
            tbNome.Clear();
            tbNumero.Clear();
            tbRua.Clear();
            tbTelCel.Clear();
            tbTexto.Clear();           
        }

        public bool ValidaForm()
        {
            if (tbNome.Text.Equals("")) return false;
            if (tbCep.Text.Equals("")) return false;
            if (tbCidade.Text.Equals("")) return false;
            if (tbEmail.Text.Equals("")) return false;
            if (tbNome.Text.Equals("")) return false;
            if (tbNumero.Text.Equals("")) return false;
            if (tbRua.Text.Equals("")) return false;
            if (tbTelCel.Text.Equals("")) return false;
            if (tbTexto.Text.Equals("")) return false;
            
            return true;
        }

        #endregion

        
    }
}
