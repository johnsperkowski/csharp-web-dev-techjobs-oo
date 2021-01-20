using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job testJob1 = new Job();
            Job testJob2 = new Job();
            Assert.IsFalse(testJob1.Equals(testJob2));
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job testJob = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual(testJob.Name, "Product tester");
            Assert.AreEqual(testJob.EmployerName.Value, "ACME");
            Assert.AreEqual(testJob.EmployerLocation.Value, "Desert");
            Assert.AreEqual(testJob.JobType.Value, "Quality control");
            Assert.AreEqual(testJob.JobCoreCompetency.ToString(), "Persistence");
        }

        [TestMethod]
        public void TestJobForEquality()
        {
            Job testJob3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job testJob4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsFalse(testJob3.Equals(testJob4));
        }

        [TestMethod]
        public void TestJobToString()
        {
            Job testJob = new Job();
            Job testJob2 = new Job("test", new Employer("test"), new Location("test"), new PositionType("test"), new CoreCompetency(""));
            Assert.AreEqual(testJob.ToString(), "OOPS! This job does not seem to exist.");
            Assert.AreEqual(testJob2.ToString(), "ID: "+testJob2.Id+ "\nName: test\nEmployer: test\nLocation: test\nPosition Type: test\nCore Competency: Data not available");
        }
    }
}
