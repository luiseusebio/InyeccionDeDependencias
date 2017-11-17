using Microsoft.VisualStudio.TestTools.UnitTesting;
using InyeccionDeDependencias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace InyeccionDeDependencias.Tests
{
    [TestClass()]
    public class NotificarSimulaoTests
    {
        [TestMethod()]
        public void TestPorConstructor()
        {
            var simulacro = new NotificarSimulado();
            var aplicacion = new Aplicacion(simulacro);
            aplicacion.Enviar("Probando");
            
        }

        [TestMethod()]
        public void TestPorMetodo()
        {
            var simulacro = new NotificarSimulado();
            var aplicacion = new Aplicacion();
            aplicacion.Enviar(simulacro, "");
        }

        [TestMethod()]
        public void TestPorPropiedad()
        {
            var simulacro = new NotificarSimulado();
            var aplicacion = new Aplicacion();
            aplicacion.Nterface1 = simulacro;
            aplicacion.Enviarp("Probando");
        }
        [TestMethod()]
        public void TestConMock()
        {
            var mock = new Mock<Interface1>();
            mock.Setup(x => x.Retornar()).Returns("como estas");
            Assert.AreEqual("como estas", mock.Object.Retornar());
        }

    }
}