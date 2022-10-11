using Devs2Blu.ProjetosAula.SistemaAgendaContato.Forms.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.SistemaAgendaContato.Forms
{
    public partial class FormContato : Form
    {

        public MySqlConnection Conn { get; set; }
        public EstadoRepository EstadoRepository = new EstadoRepository();

        public FormContato()
        {
            InitializeComponent();
        }

        private void FormContato_Load(object sender, EventArgs e)
        {
            PopulaComboEstado();
        }

        private void PopulaComboEstado()
        {
            var listEstado = EstadoRepository.FetchAll();
            cboEstado.DataSource = new BindingSource(listEstado, null);
            cboEstado.DisplayMember = "estado";
            cboEstado.ValueMember = "id";
        }
    }
}
