using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InyeccionDeDependencias
{
    public class NotificarMensaje : Interface1
    {
        public void Ejecutar(string mensaje)
        {
            MessageBox.Show($"Notificar por mensaje de texto: {mensaje}");
        }

        public string Retornar()
        {
            throw new NotImplementedException();
        }
    }
}
