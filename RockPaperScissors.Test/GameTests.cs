using Moq;
using NUnit.Framework;
using RockPaperScissors.Domain;
using RockPaperScissors.Domain.Players;
using RockPaperScissors.Domain.SIgns;

namespace RockPaperScissors.Test
{
    [TestFixture]
    public class GameTests
    {
        private Game Sut;
        private Mock<IPlayer> player1;
        private Mock<IPlayer> player2;
        private GameResult result;

        [SetUp]
        public void Setup()
        {
            player1 = new Mock<IPlayer>();
            player2 = new Mock<IPlayer>();
            Sut = new Game(player1.Object, player2.Object);
        }

        [Test]
        public void RockVsPaper_Player1Loses()
        {
            player1.Setup(x => x.ChooseSign()).Returns(new Rock());
            player2.Setup(x => x.ChooseSign()).Returns(new Paper());

            result = Sut.Play();

            Assert.That(result, Is.EqualTo(GameResult.Lose));
        }

        [Test]
        public void RockVsRock_Tie()
        {
            player1.Setup(x => x.ChooseSign()).Returns(new Rock());
            player2.Setup(x => x.ChooseSign()).Returns(new Rock());

            result = Sut.Play();

            Assert.That(result, Is.EqualTo(GameResult.Draw));
        }

        [Test]
        public void RockVsScissors_Player1Wins()
        {
            player1.Setup(x => x.ChooseSign()).Returns(new Rock());
            player2.Setup(x => x.ChooseSign()).Returns(new Scissors());

            result = Sut.Play();

            Assert.That(result, Is.EqualTo(GameResult.Win));
        }

        [Test]
        public void PaperVsPaper_Tie()
        {
            player1.Setup(x => x.ChooseSign()).Returns(new Paper());
            player2.Setup(x => x.ChooseSign()).Returns(new Paper());

            result = Sut.Play();

            Assert.That(result, Is.EqualTo(GameResult.Draw));
        }

        [Test]
        public void PaperVsRock_Player1Wins()
        {
            player1.Setup(x => x.ChooseSign()).Returns(new Paper());
            player2.Setup(x => x.ChooseSign()).Returns(new Rock());

            result = Sut.Play();

            Assert.That(result, Is.EqualTo(GameResult.Win));
        }

        [Test]
        public void PaperVsScissors_Player2Wins()
        {
            player1.Setup(x => x.ChooseSign()).Returns(new Paper());
            player2.Setup(x => x.ChooseSign()).Returns(new Scissors());

            result = Sut.Play();

            Assert.That(result, Is.EqualTo(GameResult.Lose));
        }

        [Test]
        public void ScissorsVsPaper_Player1Wins()
        {
            player1.Setup(x => x.ChooseSign()).Returns(new Scissors());
            player2.Setup(x => x.ChooseSign()).Returns(new Paper());

            result = Sut.Play();

            Assert.That(result, Is.EqualTo(GameResult.Win));
        }

        [Test]
        public void ScissorsVsRock_Player1Loses()
        {
            player1.Setup(x => x.ChooseSign()).Returns(new Scissors());
            player2.Setup(x => x.ChooseSign()).Returns(new Rock());

            result = Sut.Play();

            Assert.That(result, Is.EqualTo(GameResult.Lose));
        }

        [Test]
        public void ScissorsVsScissors_Tie()
        {
            player1.Setup(x => x.ChooseSign()).Returns(new Scissors());
            player2.Setup(x => x.ChooseSign()).Returns(new Scissors());

            result = Sut.Play();

            Assert.That(result, Is.EqualTo(GameResult.Draw));
        }
    }
}
