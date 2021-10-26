using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using Bibliotheque.BOL;
using NUnit.Framework;
using System.Linq;
using Bibliotheque.Repository;
using Bibliotheque.BLL;

namespace Bibliotheque.Test
{
    class AdherentTestMoq
    {
        [Test]
        public void ListeAdherentTest()
        {
            Mock<IAdherentRepository> mockAdhReop = new Mock<IAdherentRepository>();
            List<Adherent> adherents = new List<Adherent>()
            {
                new Adherent{NomAdherent="Yuidsqf",PrenomAdherent="qsqdfqs",IdAdherent="1234567"},
                new Adherent{NomAdherent="Azertrt",PrenomAdherent="Treza",IdAdherent="7654321"}
            };
            mockAdhReop.Setup(adhR => adhR.ListerAdherents()).Returns(adherents);
            AdherentManager adherentManager = new AdherentManager(mockAdhReop.Object);
            var res = adherentManager.Lister();
            Assert.AreSame(adherents, res, "obj non eagaux");
            mockAdhReop.Verify(a => a.ListerAdherents());
        }
        [Test]
        public void AdherentByIdTest()
        {
            Mock<IAdherentRepository> mockAdhReop = new Mock<IAdherentRepository>();
            List<Adherent> adherents = new List<Adherent>()
            {
                new Adherent{NomAdherent="Yuidsqf",PrenomAdherent="qsqdfqs",IdAdherent="1234567"},
                new Adherent{NomAdherent="Azertrt",PrenomAdherent="Treza",IdAdherent="7654321"}
            };
            Adherent adherent = new Adherent() { NomAdherent = "Yuidsqf", PrenomAdherent = "qsqdfqs", IdAdherent = "1234567" };
            mockAdhReop.Setup(a => a.SelectionnerAdherentByID("1234567")).Returns(adherent);
            AdherentManager adherentManager = new AdherentManager(mockAdhReop.Object);
            var res = adherentManager.GetAdherentByID("1234567");
            Assert.AreSame(res, adherent, "non eagux");
            mockAdhReop.VerifyAll();
        }
        [Test]
        public void CreerAdherentTest()
        {
            Mock<IAdherentRepository> mockAdhReop = new Mock<IAdherentRepository>();
            List<Adherent> adherents = new List<Adherent>()
            {
                new Adherent{NomAdherent="Yuidsqf",PrenomAdherent="qsqdfqs",IdAdherent="1234567"},
                new Adherent{NomAdherent="Azertrt",PrenomAdherent="Treza",IdAdherent="7654321"}
            };
            Adherent adherent = new Adherent() { NomAdherent = "Asceft", PrenomAdherent = "Uioqs", IdAdherent = "9874563" };
            mockAdhReop.Setup(a => a.AjouterAdherent(adherent)).Returns(adherent);
            AdherentManager adherentManager = new AdherentManager(mockAdhReop.Object);
            var res = adherentManager.CreerAdherent(adherent);
            Assert.AreSame(res, adherent);
            mockAdhReop.VerifyAll();
        }
    }
}
