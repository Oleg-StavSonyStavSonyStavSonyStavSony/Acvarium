using System;

namespace generic
{
    public class SmallFish : Fish
    {
        public override double Grow ()
            {
            if (Length < MaxLength) {
                return Length += 0.1;
            }
            else{
                Console.WriteLine("Max Length");
                return Length;
            }
        }
    }
}