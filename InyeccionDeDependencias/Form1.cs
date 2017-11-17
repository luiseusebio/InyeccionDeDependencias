using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InyeccionDeDependencias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NotificarLog notificarLog = new NotificarLog();
        NotificarCorreo notificarCorreo = new NotificarCorreo();
        NotificarMensaje notificarMensaje = new NotificarMensaje();
        Aplicacion aplicacion;
       
        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show($"\r\n\r\n{"".PadLeft(20,'_')}\r\n\r");
        }

        private void brnLog_Click(object sender, EventArgs e)
        {
            aplicacion =  new Aplicacion();

            //(Via constructor)
            //aplicacion.Enviar(txtMensaje.Text);

            //(Via metodo)
            //aplicacion.Enviar(notificarLog,txtMensaje.Text); 

            //(Via propiedad)
            aplicacion.Nterface1 = notificarLog;
            aplicacion.Enviarp(txtMensaje.Text); 

        }

        private void btnCorreo_Click(object sender, EventArgs e)
        {
            aplicacion = new Aplicacion(notificarCorreo);
            aplicacion.Enviar(txtMensaje.Text);
        }

        private void btnMensaje_Click(object sender, EventArgs e)
        {
            aplicacion = new Aplicacion(notificarMensaje);
            aplicacion.Enviar(txtMensaje.Text);
        }
    }
}
