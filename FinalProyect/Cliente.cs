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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }
        //Declarando variables para desplazar formularios sin bordes.
        int m, mx, my;

        //Conectando con base de datos.
        SqlConnection Conectcliente = new SqlConnection("server =LAPTOP-OE61GCCE ; database = USERS ; INTEGRATED SECURITY = true");
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlcliente_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pnlcliente_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;

        }

        private void btnnuevo_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.btnnuevo, "Añadir nuevo registro.");
        }

        private void btneditar_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.btneditar, "Editar registro.");
        }

        private void btnguardar_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.btnguardar, "Guardar registro.");
        }

        private void btneliminar_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.btneliminar, "Eliminar registro.");
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Conectcliente.Open();
            SqlCommand Cliente = new SqlCommand("Insert into Customers (Id,Nombre,Apellido,Correo,Sexo,Telefono)Values(" + this.txtidcliente.Text + ", ' " + this.txtnombre.Text + " ','" + this.txtapellido.Text + " ',' " + this.txtcedula.Text + " ',' " + this.txtsexo.Text + " ',' " + this.mtxttelefono.Text + ",')", Conectcliente);
            Cliente.ExecuteNonQuery();
            MessageBox.Show("Registro Añadido." , "Informacion",MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            autotableupdate();
            Conectcliente.Close();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtidcliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
           foreach(Control clean in this.Controls)
            {
                if(clean is TextBox)
                {
                    clean.Text = "";
                }
                if(clean is MaskedTextBox)
                {
                    clean.Text = "";
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Conectcliente.Open();
            string delete = " delete from Customers where Id="+txtidcliente.Text +"";
            SqlCommand Cliente = new SqlCommand(delete, Conectcliente);
            Cliente.ExecuteNonQuery();
            MessageBox.Show("Registro Eliminado.");
            autotableupdate();
            Conectcliente.Close();
        }

        public void autotableupdate()
        {
            String datagr = "Select * From Customers";
            SqlDataAdapter Cliente = new SqlDataAdapter(datagr, Conectcliente);
            DataTable dt = new DataTable();
            Cliente.Fill(dt);
            dgvclientes.DataSource = dt;

        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            String datagr = "Select * From Customers";
            SqlDataAdapter Cliente = new SqlDataAdapter(datagr, Conectcliente);
            DataTable dt = new DataTable();
            Cliente.Fill(dt);
            dgvclientes.DataSource = dt;


        }

        private void dgvclientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidcliente.Text = dgvclientes.SelectedCells[0].Value.ToString();
            txtnombre.Text = dgvclientes.SelectedCells[1].Value.ToString();
            txtapellido.Text = dgvclientes.SelectedCells[2].Value.ToString();
            txtcedula.Text = dgvclientes.SelectedCells[3].Value.ToString();
            txtsexo.Text = dgvclientes.SelectedCells[4].Value.ToString();
            mtxttelefono.Text = dgvclientes.SelectedCells[5].Value.ToString();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            Conectcliente.Open();
            String edit = "Update Customers set Id=" + txtidcliente.Text + ",Nombre='" + txtnombre.Text + "',Apellido='" + txtapellido.Text + "',Correo='" + txtcedula.Text + "',Sexo='" + txtsexo.Text + "',Telefono='" + mtxttelefono.Text+"' where Id_clientes="+txtidcliente.Text+" ";
            SqlCommand Cliente = new SqlCommand(edit, Conectcliente);
            int cant;
            cant = Cliente.ExecuteNonQuery();
            if (cant > 0)
            {
                MessageBox.Show("Registro Editado.");
            }
            autotableupdate();
            Conectcliente.Close();

        }

        private void pnlcliente_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void pnlcliente_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }
    }
}
