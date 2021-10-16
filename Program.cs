using System;

namespace generic
{
    using System.Collections;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Aquarium <IGrow> myAquarium = new Aquarium<IGrow>();
            
                    myAquarium.Add(new SmallFish {
                    Name = "SmallFish",
                    Length = 1,
                    MaxLength = 10
                    });
                    myAquarium.Add(new MediumFish {
                    Name = "MediumFish",
                    Length = 1,
                    MaxLength = 10
                     });
                    myAquarium.Add(new BigFish {
                    Name = "BigFish",
                    Length = 1,
                    MaxLength = 10
                     });

            myAquarium.Print();
            myAquarium.Grow();

           // for( int i = 0; i < 6; i++ ){
           //     myAquarium.Get(i).Grow();
          // }
            myAquarium.Print();


        }
    }
}
