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
            string jobPrint = "\n" + "ID: " + "\n" + "Name:" + "\n" + "Employer: " + "\n" + "Location: " + "\n" + "Position Type: " + "\n" + "Core Competency: " + "\n";
            return jobPrint;
        }

    }
}
