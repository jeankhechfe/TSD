using NUnit.Framework;
using Moq;
using Moq.Protected;

namespace MoqService
{
    [TestFixture]
    public class MoqTest
    {
        [Test]
        public void MoqTestInterface()
        {
            Robot robot;

            // Assume that there is no implemanation of the interafce IParameters
            // Althoug you want to test the Robot class

            // TODO 
            // Create Mock for IParameters
            // Assign new Robot to robot variable, and provide Mock.Object as a parameter to the constructor.
            // Setup a get for a name field
            // Setup two gets for health field (use Sequence)


            var Mock = new Mock<IParameters>();
            Mock.Setup(param => param.name).Returns("zucc");
            Mock.SetupSequence(param => param.health).Returns(100).Returns(70);

            robot = new Robot(Mock.Object);

            // You can't make any changes below this line.
            // -----------------------------------------------

            Assert.AreEqual("zucc", robot.Name());
            Assert.AreEqual(100, robot.Health());
            // meanwhile takes a bullet (-30 hp)
            Assert.AreEqual(70, robot.Health());
        }

        [Test]
        public void MoqTestProtected()
        {
            Robot robot;

            // Now that you've implemented the RandomDamage class test the Robot again

            // TODO
            // create Mock for RandomDamage
            // Assign new Robot to robot variable, and provide Mock.Object as a parameter to the constructor.
            // Setup proper protected function respond (use Moq.Protected)

            var Mock = new Mock<RandomDamage>();
            robot = new Robot(Mock.Object);
            Mock.Protected()
                .Setup<int>("damageRand")
                .Returns(7);

            // You can't make any changes below this line.
            // -----------------------------------------------

            Assert.AreEqual(7, robot.Damage());
        }
    }
}