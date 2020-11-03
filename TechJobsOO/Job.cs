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

        public Job(int id, String name, String employerName, String employerLocation, String jobType, String jobCoreCompetency): this()
            {
            Value= id;
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
             if(obj.GetType== "job" && this.Id == obj.Id){
            return true;
            }
             return false;
        }



    }
}
