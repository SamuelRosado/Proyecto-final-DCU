using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace FinalProyect
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
       //Declarando variables para desplazar formularios sin bordes.
        int m, mx, my;
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        SqlConnection Coneccion = new SqlConnection("server =LAPTOP-OE61GCCE ; database = USERS ; INTEGRATED SECURITY = true");
         
        private void btnentrar_Click(object sender, EventArgs e)
        {          
            Coneccion.Open();
            SqlCommand comando = new SqlCommand("SELECT Usuarios, Contraseña FROM Users WHERE Usuarios = @usuario AND Contraseña = @contraseña ", Coneccion);
            comando.Parameters.AddWithValue("@usuario", txtusuario.Text);
            comando.Parameters.AddWithValue("@contraseña", txtcontraseña.Text);
            SqlDataReader Lector = comando.ExecuteReader();
            
            if (Lector.Read())
            {
                
                Principal PantallaPrincipal = new Principal();
                PantallaPrincipal.Show();
            }
            else
            { 
                MessageBox.Show("La contraseña o el usuario no estan correctos.");              
            }
                 
            
            Coneccion.Close();
        }
        private void txtusuario_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text == "Username")
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.DimGray;
            }
        }
        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                txtusuario.Text = "Username";
                txtusuario.ForeColor = Color.DimGray;

            }
        }
        private void txtcontraseña_Enter(object sender, EventArgs e)
        {
            if(txtcontraseña.Text == "Password")
            {
                txtcontraseña.Text = "";
                txtcontraseña.ForeColor = Color.DimGray;
                txtcontraseña.UseSystemPasswordChar = true;
            }
        }
        private void txtcontraseña_Leave(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "")
            {
                txtcontraseña.Text = "Password";
                txtcontraseña.ForeColor = Color.DimGray;
                txtcontraseña.UseSystemPasswordChar = false;

            }
        }
        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }
    }
}
