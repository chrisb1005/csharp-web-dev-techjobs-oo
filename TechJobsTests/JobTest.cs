using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
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
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job test_job = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistance"));
            Assert.AreEqual(test_job.Name, "Product Tester");
            Assert.AreEqual(test_job.EmployerName.Value, "ACME");
            Assert.AreEqual(test_job.EmployerLocation.Value, "Desert");
            Assert.AreEqual(test_job.JobType.Value, "Quality Control");
            Assert.AreEqual(test_job.JobCoreCompetency.Value, "Persistance");
        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            Job test_job = new Job("fun", new Employer("jacobson"), new Location("NC"), new PositionType("coder"), new CoreCompetency("level 1"));
            Job test_job2 = new Job("fun", new Employer("jacobson"), new Location("NC"), new PositionType("coder"), new CoreCompetency("level 1"));
            Assert.IsFalse(test_job.Id == test_job2.Id);
        }

        [TestMethod]
        public void TestToString()
        {
            Job test_job = new Job("fun", new Employer("jacobson"), new Location("NC"), new PositionType("coder"), new CoreCompetency("level 1"));
            
           
            Assert.IsTrue(test_job.ToString()[0] == '\n');
            Assert.IsTrue(test_job.ToString()[test_job.ToString().Count() - 1] == '\n');
           
        }
        [TestMethod]
        public void TestToString2()
        {
            //string jobPrint = "\n" + "ID: " + "\n" + "Name:" + "\n" + "Employer: " + "\n" + "Location: " + "\n" + "Position Type: " + "\n" + "Core Competency: " + "\n";
            Job test_job = new Job("fun", new Employer("jacobson"), new Location("NC"), new PositionType("coder"), new CoreCompetency("level 1"));
           // Console.WriteLine(test_job);
            Assert.AreEqual(test_job.ToString(), "\n" + $"Name: {test_job.Name}" + "\n" + $"Employer: {test_job.EmployerName}" + "\n" + $"Location: {test_job.EmployerLocation}" + "\n" + $"Position Type: {test_job.JobType}" + "\n" + $"Core Competency: {test_job.JobCoreCompetency}" + "\n");
        }

        [TestMethod]

        public void TestEmptyField()
        {
            Job test_job = new Job("fun", new Employer(""), new Location("NC"), new PositionType("coder"), new CoreCompetency("level 1"));
            string test_out = "\n" + $"Name: {test_job.Name}" + "\n" + $"Employer: Data not available" + "\n" + $"Location: {test_job.EmployerLocation.Value}" + "\n" + $"Position Type: {test_job.JobType.Value}" + "\n" + $"Core Competency: {test_job.JobCoreCompetency.Value}" + "\n";
            Assert.AreEqual(test_job.ToString(), test_out);
        }
    }
}
