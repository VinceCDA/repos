using Bibliotheque.BOL;
using NUnit.Framework;
using System;
using System.Linq;


namespace Bibliotheque.Test
{
    [TestFixture]
    public class TestAdherent
    {
        

        [Test]
        public void NomAdherentTropCourt()
        {
            Adherent adherent = new Adherent
            {
                NomAdherent = "b"
            };
            
            Assert.IsTrue(ValidationService.ValidateModel(adherent).Any(
                va => va.MemberNames.Contains("NomAdherent") &&
             va.ErrorMessage.Contains("2")));
        }
        [Test]
        public void NomAdherentNull()
        {
            Adherent adherent = new Adherent
            {
                NomAdherent = null
            };
            Assert.IsTrue(ValidationService.ValidateModel(adherent).Any(
                va => va.MemberNames.Contains("NomAdherent") &&
             va.ErrorMessage.Contains("requis")));
        }
        [Test]
        public void NomAdherentVide()
        {
            Adherent adherent = new Adherent
            {
                NomAdherent = ""
            };
            Assert.IsTrue(ValidationService.ValidateModel(adherent).Any(
                va => va.MemberNames.Contains("NomAdherent") &&
             va.ErrorMessage.Contains("requis")));
        }
        [Test]
        public void NomAdherentAvecNombre()
        {
            Adherent adherent = new Adherent
            {
                NomAdherent = "123456"
            };
            Assert.IsTrue(ValidationService.ValidateModel(adherent).Any(
                va => va.MemberNames.Contains("NomAdherent") &&
             va.ErrorMessage.Contains(" ")));
        }
        [Test]
        public void NomAdherentAvecEspace()
        {
            Adherent adherent = new Adherent
            {
                NomAdherent = "De la Gruity"
            };
            Assert.IsFalse(ValidationService.ValidateModel(adherent).Any(
                va => va.MemberNames.Contains("NomAdherent") &&
             va.ErrorMessage.Contains(" ")));
        }
    }
    [TestFixture]
    [Serializable]
    public class TestEntityBase : Adherent
    {
        
        //public object Cloned => base._clone;
        [Test]
        public void TestClone()
        {
            Adherent adherent = new Adherent
            {
                NomAdherent = "De la Gruity"
            };
            Adherent adherentClone = (Adherent)adherent.Clone();
            Assert.AreEqual(adherent.NomAdherent, adherentClone.NomAdherent);
        }
        [Test]
        public void TestBeginEdit()
        {
            TestEntityBase adherent = new TestEntityBase
            {
                NomAdherent = "De la Gruity"
            };
            adherent.BeginEdit();
            TestEntityBase adherent2 = (TestEntityBase)adherent._clone;
            Assert.IsTrue(adherent2.NomAdherent == adherent.NomAdherent && adherent.inTxn);
        }
        [Test]
        public void TestCancelEdit()
        {
            TestEntityBase adherent = new TestEntityBase
            {
                NomAdherent = "De la Gruity"
            };
            adherent.BeginEdit();
            adherent.NomAdherent = "JeanMiche";
            adherent.CancelEdit();
            Assert.IsTrue(adherent.NomAdherent == "De la Gruity");
        }
        [Test]
        public void TestEndEdit()
        {
            TestEntityBase adherent = new TestEntityBase
            {
                NomAdherent = "De la Gruity"
            };
            adherent.inTxn = true;
            adherent.EndEdit();
            TestEntityBase adherent2 = (TestEntityBase)adherent._clone;
            Assert.IsTrue(adherent2.NomAdherent == adherent.NomAdherent && !adherent.inTxn);
        }
    }
}