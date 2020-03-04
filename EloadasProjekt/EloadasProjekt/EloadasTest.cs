using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EloadasProjekt.Test
{
    [TestFixture]
    class EloadasTest
    {
        Eloadas eloadas;
        [SetUp]
        public void SetUp()
        {
            eloadas = new Eloadas(5, 5);
        }

        [TestCase]
        public void SzabadHelyekSzama()
        {
            Eloadas e = new Eloadas(3, 3);
            eloadas.Lefoglal();
            eloadas.Lefoglal();
            Assert.AreEqual(7, eloadas.SzabadHelyek);
        }

        [TestCase]
        public void SzabadelyfoglalasUtanAHelyekSzamaCsokken()
        {
            eloadas.Lefoglal();
            Assert.AreEqual(7, eloadas.SzabadHelyek);
        }

        [TestCase]
        public void EloadasNincsTeli()
        {
            for (int i = 0; i < 7; i++)
            {
                eloadas.Lefoglal();
            }
            Assert.IsTrue(eloadas.Teli());
        }

        [TestCase]
        public void EloadasTeli()
        {
            Assert.IsFalse(eloadas.Teli());
        }
    }
}
