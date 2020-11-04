using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job test_job = new Job("fun", new Employer ("jacobson"), new Location("NC"), new PositionType ("coder"),new CoreCompetency ("level 1"));
            Job test_job2 = new Job("noob", new Employer("jump"), new Location("NC"), new PositionType("coder"), new CoreCompetency("level 1"));
            Assert.IsTrue(test_job.Id != test_job2.Id);

        }
        public void TestJobConstructorSetsAllFields()
        {
            Job test_job = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistance"));
            Assert.AreEqual(test_job.Name, "product Tester");
            Assert.AreEqual(test_job.EmployerName, "ACME");
            Assert.AreEqual(test_job.EmployerLocation, "desert");
            Assert.AreEqual(test_job.JobType, "quality control");
            Assert.AreEqual(test_job.JobCoreCompetency, "persistence");
        }
        public void TestJobsForEquality()
        {
            Job test_job = new Job("fun", new Employer("jacobson"), new Location("NC"), new PositionType("coder"), new CoreCompetency("level 1"));
            Job test_job2 = new Job("fun", new Employer("jacobson"), new Location("NC"), new PositionType("coder"), new CoreCompetency("level 1"));
            Assert.IsFalse(test_job.Id == test_job2.Id);
        }
    }
}
