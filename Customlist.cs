using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customlistassng
{
    public class Customlist<T>
    {//Membr Vars

        private int count = 0;
        public int Count { get { return count; } }

        private int capacity = 4;
        public int Capacity { get { return capacity; } }
      public   T[] list;

        //Constructor
        public Customlist()
        {

          list  = new T[capacity];


        }
            
            
           
       


       



             



        //methods


        public int Add(T item) 
        { 
            if (count>=(capacity+1))
            {
                T[] list = new T[capacity*2];
                count = count + 1;
            }

            else { list[count] = item; count++; }
            return count;
        
        
        
        
        
        
        }
        public int Remove(T item)
        {
            
            if (count <= (capacity/2)&& count>3)
            {
                T[] list = new T[capacity / 2];
                count = count - 1;
            }

            else { list[count] = default(T); count--; }



            return count;


        }





    }
}
