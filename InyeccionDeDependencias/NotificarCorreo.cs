using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InyeccionDeDependencias
{
    public class NotificarCorreo : Interface1
    {
        public void Ejecutar(string mensaje)
        {
            MessageBox.Show($"Notificar Por correo {mensaje}");
        }

        public string Retornar()
        {
            throw new NotImplementedException();
        }
    }
}
