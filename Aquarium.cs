using System;

namespace generic
{
     using System.Collections.Generic;
    public class Aquarium<T> where T : IGrow
    {
         private List <T> aquarium;

        public Aquarium(){
            aquarium = new List<T>();
        }
        public void Add(T item)
        {
          aquarium.Add(item);
        }
        public T Get(int  d)
        {
          return aquarium[d];
        } 
        public void Grow()
        {
          foreach( var item in aquarium){
                item.Grow();
          }
        }
         public void Print (){
         foreach( var item in aquarium){
         Console.Write($"{item}.");
         Console.WriteLine();
          }
        }
    }
}