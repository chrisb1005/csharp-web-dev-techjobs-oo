using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public Job()
        {
             Id = nextId;
      nextId++;
        }

        public Job( String name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency): this()
            {
            
        Name= name;
            EmployerName= employerName;
            EmployerLocation= employerLocation;
            JobType= jobType;
            JobCoreCompetency= jobCoreCompetency;
        }

        // TODO: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
             if (obj == obj)
                {return true;
            }
             if(this == obj && obj == this){
            return true;
            }
             if(obj is Job && this.Id == ((Job)obj).Id){
            return true;
            }
             return false;
        }

        public override string ToString()
        {
            // string jobPrint = "\n" + "ID: " + "\n" + "Name:" + "\n" + "Employer: " + "\n" + "Location: " + "\n" + "Position Type: " + "\n" + "Core Competency: " + "\n";
           // Job test_job = new Job("fun", new Employer("jacobson"), new Location("NC"), new PositionType("coder"), new CoreCompetency("level 1"));
           // Name= 
           
            if (EmployerName.Value == "" || EmployerName.Value == null)
            {
                EmployerName.Value = "Data not available";
            }
             if(Name == "" || Name == null )
            {
                Name = "Data not available";
            }
            if (EmployerLocation.Value == "" || EmployerLocation.Value == null)
            {
                EmployerLocation.Value = "Data not available";
            }
             if (JobType.Value == "" || JobType.Value == null)
            {
                JobType.Value = "Data not available";
            }
             if (JobCoreCompetency.Value == "" || JobCoreCompetency.Value == null)
            {
                JobCoreCompetency.Value = "Data not available";
            }
            string jobPrint = "\n" +$"{Id}" + "\n" + $"Name: {Name}" + "\n" + $"Employer: {EmployerName.Value}" + "\n" + $"Location: {EmployerLocation.Value}" + "\n" + $"Position Type: {JobType.Value}" + "\n" + $"Core Competency: {JobCoreCompetency.Value}" + "\n";
            return jobPrint;
        }

    }
}
