using KingdomsArmies.Server;
using KingdomsArmies.Server.Values;
using KingdomsArmies.Server.Values.CultureClasses;

namespace KingdomTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
            

        }

        [Test]
        public void TestArcanaCorrectDouble()
        {
            Sciences testScience = new Sciences(false, 10, 5, 5, 5);
            Assert.That(testScience.Arcana, Is.EqualTo((double)1/(double)3));
        }
        [Test]
        public void TestAlchemyCorrectDouble()
        {
            Sciences testScience = new Sciences(false,10, 1, 4, 5);
            Assert.That(testScience.Alchemy, Is.EqualTo((double)1/(double)2));
        }

        [Test]
        public void TestAlchemyCorrectValueWith0Numbers()
        {
            Sciences testScience = new Sciences(false, 0, 0, 0, 0);
            Assert.That(testScience.Alchemy, Is.EqualTo(1/(double)3));
        }
        [Test]
        public void TestArcanaCorrectRaw()
        {
            Sciences testScience = new Sciences(true, 10, 6, 5, 6);
            Assert.That(testScience.Arcana, Is.EqualTo(5));
        }
        [Test]
        public void TestArtsIsTheSameRaw()
        {
            Arts testArts = new Arts(true, 10, 6, 5, 6);
            Assert.That(testArts.Commercial, Is.EqualTo(5));
        }
        [Test]
        public void TestPersonalCorrectDouble()
        {

            Arts testArts = new Arts(false, 10, 5, 5, 5);
            Assert.That(testArts.Personal, Is.EqualTo((double)1 / (double)3));
        }
        [Test]
        public void TestPopulationAverage()
        {

            Sciences testScience = new Sciences(false, 10, 1, 4, 5);
            Arts testArts = new Arts(false, 10, 5, 5, 5);

            Population pop1 = new(testScience, testArts, LivingStandard.poor3);
            Population steve = new Population(testScience, testArts, LivingStandard.poor3);
            Population brian = new Population(testScience, testArts, LivingStandard.poor3);
            Population gertrude = new Population(testScience, testArts, LivingStandard.poor3);
            List<Population> popList = new List<Population>() { pop1, steve, brian, gertrude };

            LivingStandard average = Wealth.MeanAverage(popList);
            Assert.That(average, Is.EqualTo(LivingStandard.poor3));
        }
        [Test]
        public void TestPopulationAverageWithUnevenStartValues()
        {

            Sciences testScience = new Sciences(false, 10, 1, 4, 5);
            Arts testArts = new Arts(false, 10, 5, 5, 5);

            Population pop1 = new(testScience, testArts, LivingStandard.poor3);
            Population steve = new Population(testScience, testArts, LivingStandard.poor3);
            Population brian = new Population(testScience, testArts, LivingStandard.poor3);
            Population gertrude = new Population(testScience, testArts, LivingStandard.poor3);
            List<Population> popList = new List<Population>() { pop1, steve, brian, gertrude };

            LivingStandard average = Wealth.MeanAverage(popList);
            Assert.That(average, Is.EqualTo(LivingStandard.poor3));
        }

        [Test]
        public void TestPopulationAverageWithLowestStartValues()
        {

            Sciences testScience = new Sciences(false, 10, 1, 4, 5);
            Arts testArts = new Arts(false, 10, 5, 5, 5);

            Population pop1 = new(testScience, testArts, LivingStandard.destitute1);
            Population steve = new Population(testScience, testArts, LivingStandard.destitute1);
            Population brian = new Population(testScience, testArts, LivingStandard.destitute1);
            Population gertrude = new Population(testScience, testArts, LivingStandard.destitute1);
            List<Population> popList = new List<Population>() { pop1, steve, brian, gertrude };

            LivingStandard average = Wealth.MeanAverage(popList);
            Assert.That(average, Is.EqualTo(LivingStandard.destitute1));
        }

        [Test]
        public void TestPopulationAverageWithMixedValues()
        {

            Sciences testScience = new Sciences(false, 10, 1, 4, 5);
            Arts testArts = new Arts(false, 10, 5, 5, 5);

            Population pop1 = new(testScience, testArts, LivingStandard.destitute1);
            Population steve = new Population(testScience, testArts, LivingStandard.poor3);
            Population brian = new Population(testScience, testArts, LivingStandard.wealthy1);
            Population gertrude = new Population(testScience, testArts, LivingStandard.extravagant1);
            List<Population> popList = new List<Population>() { pop1, steve, brian, gertrude };

            LivingStandard average = Wealth.MeanAverage(popList);
            Assert.That(average, Is.EqualTo(LivingStandard.wealthy1));
        }
    }
}