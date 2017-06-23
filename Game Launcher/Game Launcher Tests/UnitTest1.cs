using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game_Launcher;
using System.Collections.Generic;
using System.Diagnostics;

namespace Game_Launcher_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Spiel_hinzufügen_Test()
        {
            Controller c = new Controller();

            c.Spiel_hinzufügen("Dark SOULS 3", "22.06.2017", @"C:\Program Files (x86)\Steam\steamapps\common\DARK SOULS III\Game\DarkSoulsIII.exe", "Egoshooter", "idsoftware / Bethesda", 18);

            Assert.AreEqual(1, c.Spiel.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]

        public void Spiel_hinzufügen_Test2()
        {
            Controller c = new Controller();

            c.Spiel_hinzufügen("","", "", "", "", 21);

            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]

        public void Spiel_hinzufügen_Test3()
        {
            Controller c = new Controller();

            c.Spiel_hinzufügen("Prey", "22.06.2017", @"C:\", "Action", "Bethesda", 18);

            Assert.Fail();
        }

        [TestMethod]

        public void Spiel_entfernen_Test()
        {
            Controller c = new Controller();
            Spiele Spiel = new Spiele("Prey", "22.06.2017", @"C:\", "Action", "Bethesda", 18);
            c.Spiel.Add(Spiel);

            c.Spiel_entfernen(Spiel);

            Assert.AreEqual(0, c.Spiel.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]

        public void Spiel_entfernen_Test2()
        {
            Controller c = new Controller();
            Spiele Spiel = new Spiele("Dark SOULS 3", "22.06.2017", @"C:\Program Files(x86)\Steam\steamapps\common\DARK SOULS III\Game\DarkSoulsIII.exe", "Egoshooter", "idsoftware / Bethesda", 18);
            c.Spiel.Add(Spiel);

            c.Spiel_entfernen(new Spiele("Prey", "22.06.2017", @"C:\", "Action", "Bethesda", 18));

            Assert.Fail();
        }

        [TestMethod]

        public void Spiel_starten_Test()
        {
            Controller c = new Controller();
            Spiele Spiel = new Spiele("Dark SOULS 3", "22.06.2017", @"C:\Windows\System32\calc.exe", "Egoshooter", "idsoftware / Bethesda", 18);
            c.Spiel.Add(Spiel);

            c.Spiel_starten(Spiel);
            Process[] pro = Process.GetProcessesByName("calc");

            Assert.AreNotEqual(pro.Length, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]

        public void Spiel_starten_Test2()
        {
            Controller c = new Controller();
            Spiele Spiel = new Spiele("Dark SOULS 3", "22.06.2017", @"C:\", "Egoshooter", "idsoftware / Bethesda", 18);
            c.Spiel.Add(Spiel);

            c.Spiel_starten(Spiel);

            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]

        public void Spiel_starten_Test3()
        {
            Controller c = new Controller();
            Spiele Spiel = new Spiele("Dark SOULS 3", "22.06.2017", @"C:\Windows\System32\calc.exe", "Egoshooter", "idsoftware / Bethesda", 18);

            c.Spiel_starten(Spiel);

            Assert.Fail();
        }


    }
}
