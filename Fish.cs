using System;

namespace generic 
{
    public abstract class Fish : IGrow
    {
        public string Name { get; set; }
        public double Length { get; set; } 
        public int MaxLength { get; set; } 
        public abstract double Grow ();

        public override string ToString()
        {
            return $"{Name} - {Length} - {MaxLength} ";
        }
    }
}