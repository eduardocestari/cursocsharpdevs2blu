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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Bind the DataGridView controls to the BindingSource
            // components and load the data from the database.
            masterDataGridView.DataSource = masterBindingSource;
            detailsDataGridView.DataSource = detailsBindingSource;
            GetData();

            // Resize the master DataGridView columns to fit the newly loaded data.
            masterDataGridView.AutoResizeColumns();

            // Configure the details DataGridView so that its columns automatically
            // adjust their widths when the data changes.
            detailsDataGridView.AutoSizeColumnsMode =
             DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void GetData()
        {
            try
            {
                // Specify a connection string. Replace the given value with a
                // valid connection string for a Northwind SQL Server sample
                // database accessible to your system.
                MySqlConnection connection = ConnectionMySQL.GetConnection();

                // Create a DataSet.
                DataSet data = new DataSet();
                data.Locale = System.Globalization.CultureInfo.InvariantCulture;

                // Add data from the contato table to the DataSet.
                MySqlDataAdapter masterDataAdapter = new
                    MySqlDataAdapter("select id, Nome, Celular, email 'E-mail', UF from contato", connection);
                masterDataAdapter.Fill(data, "contato");

                // Add data from the compromissos table to the DataSet.
                MySqlDataAdapter detailsDataAdapter = new
                    MySqlDataAdapter(@"select id, id_contato, Titulo 'Título', dataini 'De', datafim 'Até', 
            case Status when 'A' then 'Ativo'
			when 'I' then 'Inativo'
            when 'C' then 'Concluído'
            when 'R' then 'Remarcado' end Status,
            Descricao 'Observação' from compromisso", connection);
                detailsDataAdapter.Fill(data, "compromisso");

                // Establish a relationship between the two tables.
                DataRelation relation = new DataRelation("CompromissoContato",
                    data.Tables["contato"].Columns["id"],
                    data.Tables["compromisso"].Columns["id_contato"]);
                data.Relations.Add(relation);

                // Bind the master data connector to the Customers table.
                masterBindingSource.DataSource = data;
                masterBindingSource.DataMember = "contato";

                // Bind the details data connector to the master data connector,
                // using the DataRelation name to filter the information in the
                // details table based on the current row in the master table.
                detailsBindingSource.DataSource = masterBindingSource;
                detailsBindingSource.DataMember = "CompromissoContato";

            }
            catch (MySqlException myeExc)
            {
                MessageBox.Show(myeExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;


            }
        }
       
    }
}
