using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinalProyect
{
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }
        SqlConnection Conecconsulta = new SqlConnection("server =LAPTOP-OE61GCCE ; database = USERS ; INTEGRATED SECURITY = true");

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            Conecconsulta.Open();
            string consulta = "select * from Customers where Id=" + txtidcliente.Text + "";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, Conecconsulta);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgvconsulta.DataSource = dt;
            SqlCommand comando = new SqlCommand(consulta, Conecconsulta);
            SqlDataReader lector;
            lector = comando.ExecuteReader();
            Conecconsulta.Close();

        }
    }
}
