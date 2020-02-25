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
        public T[] list;

        //Constructor
        public Customlist()
        {

            list = new T[capacity];


        }
            
            
           
       


       



             



        //methods


        public int Add(T item) 
        {
            
            if (count>=(capacity))
            {
                int count2 = 0;
                int count1 = count;
                T[] list1 = new T[capacity*2];
                int capacity1 = capacity*2;
                while (count2 < capacity) 
                {
                     
                    
                    list1[count2] = list[count2];


                    count2++;
                }
                capacity = capacity1;
                count = count1;
                list1[count] = item;
                list = list1;

                count++;





            }

            else { list[count] = item; count++; }
            return count;
        
        
        
        
        
        
        }
        public int Remove(T item)
        {
            
            if (count <= (capacity/2)&& count>3)
            {

                RemoveAct(item);
                int count2 =0;
                T[] list1 = new T[capacity / 2];
                int capacity1 = capacity /2;

                while (count2 < capacity1)
                {


                    list1[count2] = list[count2];


                    count2++;
                }
                
                capacity = capacity1;
                list = list1;
                
            }

            else {
                RemoveAct(item
                    );
            }
            count--;
            

            return count;
           


        }

        private void RemoveAct(T item) 
            {
            int counter1 = 0;
            int i = 0;
                while (i == 0)
                    if (list[counter1].Equals(item)) { list[counter1] = default(T); i++; }
                    else { i = 0; counter1++; }
            }


    }
}
