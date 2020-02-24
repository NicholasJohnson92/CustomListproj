using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customlistassng
{
    public class Customlist<T>
    {//Membr Vars

        int count = 0;
        static int capacity = 4;

        T[] list = new T[capacity];

        //Constructor
        public Customlist()
        {

        }
            
            
           
       


       



             



        //methods


        public void Add(T item) 
        { int i = 0;
            if (count>=(capacity+1))
            {
                T[] list = new T[capacity*2];
            }

            else { list[count] = item; count++; }
        
        
        
        
        
        
        }


       


    }
}
