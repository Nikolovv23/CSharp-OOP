using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        private Dummy dummy;
        [SetUp]
        public void SetUp()
        {
            dummy = new Dummy(5, 2);
        }


        [Test]
        public void NewDummy_ShouldSetDataCorrect()
        {
            Assert.AreEqual(dummy.Health, 5);
        }


        [Test]
        public void TakeAttack_ShouldLowerHealth()
        {
            dummy.TakeAttack(3);
            Assert.AreEqual(dummy.Health, 2);
        }


        [Test]
        public void TakeAttack_WhenDead_ShouldThrowError()
        {
            dummy.TakeAttack(6);
            Assert.Throws<InvalidOperationException> (() =>
            {
                dummy.TakeAttack(1);
            });
        }


        [Test]
        public void WhenNotDead_GiveExperience_ShouldThrowError()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                dummy.GiveExperience();
            });
        }


        [Test]
        public void WhenDead_GiveExperience_ShouldWork()
        {
                dummy.TakeAttack(6);
                Assert.AreEqual(dummy.GiveExperience(), 2);
        }
    }
}