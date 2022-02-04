using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using FusionCalculator;
using Persona_Compendium.Models;

namespace Persona_Compendium_Tests
{
    [TestClass]
    public class CombinationTableTest
    {
        [TestMethod]
        public void PairEquality()
        {
            // Test pair equality cases
            var pairA = new Pair<Arcana, Arcana>(Arcana.Faith, Arcana.Fool);
            var pairB = new Pair<Arcana, Arcana>(Arcana.Fool, Arcana.Faith);
            var pairC = new Pair<Arcana, Arcana>(Arcana.Faith, Arcana.Fool);
            var pairD = new Pair<Arcana, Arcana>(Arcana.Chariot, Arcana.Fool);
            var pairE = new Pair<Arcana, Arcana>(Arcana.Fortune, Arcana.Hanged);

            Assert.AreEqual(pairA, pairC, "Identical pairs reported as unequal");
            Assert.AreEqual(pairA, pairB, "Swapped pairs reported as unequal");
            Assert.AreEqual(pairA.GetHashCode(), pairC.GetHashCode(), "Identical pair hash codes unequal");
            Assert.AreEqual(pairA.GetHashCode(), pairB.GetHashCode(), "Swapped pair hash codes unequal");
            Assert.AreNotEqual(pairA, pairD, "Half-distinct pairs equal");
            Assert.AreNotEqual(pairA, pairE, "Fully-distinct pairs equal");
        }

        [TestMethod]
        public void CombinationTable()
        {
            var table = new CombinationTable<Arcana, Arcana, Arcana>() {
                { Arcana.Chariot, Arcana.Councillor, Arcana.Death }
            };

            Assert.IsTrue(table.ContainsKey(Arcana.Chariot, Arcana.Councillor), "Table does not contain key from initializer");
            Assert.AreEqual(table[Arcana.Chariot, Arcana.Councillor], Arcana.Death, "Table access did not yield the correct result");
            Assert.AreEqual(table[Arcana.Councillor, Arcana.Chariot], Arcana.Death, "Swapped-pair table access did not yield the correct result");

            table[Arcana.Chariot, Arcana.Councillor] = Arcana.Devil;
            Assert.AreEqual(table[Arcana.Chariot, Arcana.Councillor], Arcana.Devil, "Table access after change did not yield the correct result");
            Assert.AreEqual(table[Arcana.Devil, Arcana.Emperor], default, "Unknown-pair table access did not yield default value");

            table[Arcana.Emperor, Arcana.Faith] = Arcana.Unset;
            Assert.IsTrue(table.ContainsKey(Arcana.Emperor, Arcana.Faith), "Table does not contain added key");
        }
    }
}
