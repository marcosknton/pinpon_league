using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class LigaTests
    {
        Partido partido;
        Liga liga;
        int contador;


        [TestMethod()]
       
        public void getPartidoTest()
        {
            liga = new Liga();
            contador=liga.getListaPartits.Count;
            Assert.IsTrue(contador<0);
        }
    }
}