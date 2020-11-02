using System;
namespace TechJobsOO
{
    public class PositionType
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public PositionType()
        {
            Id = nextId;
            nextId++;
        }

        public PositionType(string value) : this()
        {
            Value = value;
        }
         public override bool Equals(object obj)
        {
            return obj is Location location &&
                   Id == location.Id;
        }
         public override int GetHashCode()
        {
            return HashCode.Combine(id);
        }

        public override string ToString()
        {
            return value;
        }
        // TODO: Add custom Equals(), GetHashCode(), and ToString() methods.
    }
}
