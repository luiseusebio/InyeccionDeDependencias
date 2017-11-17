using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDeDependencias
{
    public class Aplicacion
    {
        private Interface1 nterface = null;
        public Interface1 Nterface1 { get; set; }
        public Aplicacion(Interface1 nterface1)
        {
            nterface = nterface1;
        }
        public Aplicacion()
        {
        }

        //Enviar via constructor
        public void Enviar(string mensaje)
        {
            nterface.Ejecutar(mensaje);
        }
        public void Enviar()
        {
            nterface.Ejecutar("Hola");
        }

        //Enviar via propiedad
        public void Enviarp(string mensaje)
        {
            Nterface1.Ejecutar(mensaje);
        }
        //Enviar via metodo
        public void Enviar(Interface1 nterface1, string mensaje)
        {
            if (!String.IsNullOrEmpty(mensaje))
            {
                nterface1.Ejecutar(mensaje);
            }
        }

    }
}
