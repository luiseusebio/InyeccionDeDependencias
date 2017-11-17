using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InyeccionDeDependencias
{
    public class NotificarSimulado : Interface1
    {
        public void Ejecutar(string mensaje)
        {
            Console.WriteLine($"para la prueba: {mensaje}");
        }

        public string Retornar()
        {
            return "Hola mundo";
        }
    }
}
