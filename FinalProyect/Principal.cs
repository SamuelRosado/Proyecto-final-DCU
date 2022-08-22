using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProyect
{
   
    public partial class Principal : Form
    {

        public Principal()

        {
            InitializeComponent();
           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void s_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            btnlogout.BackColor = Color.DimGray;
            if(MessageBox.Show("¿Estas seguro que quieres salir?", "Aviso importante.", 
             MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            this.Close();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            btndashboard.BackColor = Color.DimGray;
        }

      
        private void btnganancias_Click(object sender, EventArgs e)
        {
            btnganancias.BackColor = Color.DimGray;
        }

        private void btnproveedores_Click(object sender, EventArgs e)
        {
            btnproveedores.BackColor = Color.DimGray;
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            btnclientes.BackColor = Color.DimGray;
        }

        private void btntrabajadores_Click(object sender, EventArgs e)
        {
            btntrabajadores.BackColor = Color.DimGray;
        }

        private void btncompras_Click(object sender, EventArgs e)
        {
            btncompras.BackColor = Color.DimGray;
        }

        private void btnventas_Click(object sender, EventArgs e)
        {
            btnventas.BackColor = Color.DimGray;
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            btnproductos.BackColor = Color.DimGray;
        }

        private void btndashboard_Leave(object sender, EventArgs e)
        {
            btndashboard.BackColor = Color.Snow;
        }

        private void btnproductos_Leave(object sender, EventArgs e)
        {
            btnproductos.BackColor = Color.Snow;
        }

        private void btnventas_Leave(object sender, EventArgs e)
        {
            btnventas.BackColor = Color.Snow;
        }

        private void btncompras_Leave(object sender, EventArgs e)
        {
            btncompras.BackColor = Color.Snow;
        }

        private void btntrabajadores_Leave(object sender, EventArgs e)
        {
            btntrabajadores.BackColor = Color.Snow;

        }

        private void btnclientes_Leave(object sender, EventArgs e)
        {
            btnclientes.BackColor = Color.Snow;
        }

        private void btnproveedores_Leave(object sender, EventArgs e)
        {
            btnproveedores.BackColor = Color.Snow;
        }

        private void btnganancias_Leave(object sender, EventArgs e)
        {
            btnganancias.BackColor = Color.Snow;
        }

        private void btnlogout_Leave(object sender, EventArgs e)
        {
            btnlogout.BackColor = Color.Snow;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Hours_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
            lblfecha.Text = DateTime.Now.ToShortDateString();
        }

        private void lblfecha_Click(object sender, EventArgs e)
        {

        }

        private void timeoff_Tick(object sender, EventArgs e)
        {
            
            
        }

        private void lbltimeoff_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente PantallaCliente = new Cliente();
            PantallaCliente.Show();
            
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta PantallaConsulta = new Consulta();
            PantallaConsulta.Show();
        }
    }

}
