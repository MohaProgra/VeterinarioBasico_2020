using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinarioBasico_2020
{
    public partial class VentanaLogin : Form
    {
        //Declaro la clase conexión

        Conexion conexion = new Conexion();

        public VentanaLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            String resultado = conexion.loginVeterinario(textBoxDNI.Text, textBoxcontraseña.Text);
            MessageBox.Show(resultado);
            //VentanaPrincipal v = new VentanaPrincipal();
            //v.Show();
        }
    }
}
