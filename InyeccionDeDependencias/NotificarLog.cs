using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InyeccionDeDependencias
{
    public class NotificarLog : Interface1
    {
        public void Ejecutar(string mensaje)
        {
            MessageBox.Show($"Notificar al log: {mensaje}");
        }

        public string Retornar()
        {
            throw new NotImplementedException();
        }
    }
}
