using NUnit.Framework;
using Moq;
using ServiceMail;
using System.Collections.Generic;

namespace TestProjectMailing
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void MailingGroupeTest()
        {
            Mock<IMailService> mockMail = new Mock<IMailService>();
            List<Mail> mails = new List<Mail>();
            mails.Add(new Mail()
            {
                AdresseMail = "Vincent.bost@afpa.fr",
                Sujet = "Entretien CDI",
                Corps = "Bonjour...."
            });
            mails.Add(new Mail()
            {
                AdresseMail = "Vincent.bost@campus.afpa.fr",
                Sujet = "Entretien CDI",
                Corps = "Bonjour...."
            });
            mails.Add(new Mail()
            {
                AdresseMail = "Vincent.bost@afpa.fr",
                Sujet = "Entretien CDI",
                Corps = "Bonjour...."
            });
            mockMail.Setup(a => a.SendMail(It.IsAny<Mail>())).Returns(true);
            MailService mailService = new MailService();
            EnvoiMailsGroupes envoiMailsGroupes = new EnvoiMailsGroupes(mockMail.Object, mails);
            var res = envoiMailsGroupes.EnvoiMailing();
            Assert.IsTrue(res == 3);
            mockMail.VerifyAll();
        }
        [Test]
        public void MailingGroupeVideTest()
        {
            Mock<IMailService> mockMail = new Mock<IMailService>();
            List<Mail> mails = new List<Mail>();
            
            mockMail.Setup(a => a.SendMail(It.IsAny<Mail>())).Returns(true);
            MailService mailService = new MailService();
            EnvoiMailsGroupes envoiMailsGroupes = new EnvoiMailsGroupes(mockMail.Object, mails);
            var res = envoiMailsGroupes.EnvoiMailing();
            Assert.IsTrue(res == 0);
            mockMail.VerifyAll();
        }
    }
}