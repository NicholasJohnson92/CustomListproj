using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Customlistassng
{
    public class Customlist<T> : IEnumerable
    {//Membr Vars
        
        private int count = 0;
        public int Count { get { return count; } }

        private int capacity = 4;
        public int Capacity { get { return capacity; } }
        private T[] list;
        public T this[int index]
        {
            get
            {
                if (index < 0 && index >= capacity + 1)
                    throw new IndexOutOfRangeException(" Index out of Range!! ");
                return list[index];



            }


            set
            {
                if (index < 0 || index >= capacity + 1)
                    throw new IndexOutOfRangeException(" Index out of Range!! ");

                list[index] = value;

            }




        }




        
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

        private int RemoveAct(T item)
        {
            int capacity1 = capacity;
            int k = 0;
            int j = 0;
            int i = 0;

            T[] list1 = new T[capacity1];


            while (i == 0)
            {
                if (list[j].Equals(item)) { list[j] = default(T); j++; i++; }
                else
                {
                    i = 0; i++; j++; k++;

                }
                while (j < count)
                {
                    list1[k] = list[j];
                    list[j] = list1[j];
                    list[k] = list1[k];
                    j++;
                    k++;
                }
            }

            return j;
        }

        public override string ToString()
        {
            string newstr2 = null;
            string newstr=",";
            int counter = 0;
            while (counter < count-1)
            {
             string newstr1=  list[counter].ToString();
                 newstr2 =newstr2+ newstr1 + newstr;
                counter++;
                
            }
            if (counter == count - 1)
            {
                string newstr1 = list[counter].ToString();

                newstr2 = newstr2 + newstr1;
            }
            
            
            
           
            return newstr2;
        }

        public IEnumerator GetEnumerator()
        {
            for (int index = 0; index < count ; index++)
            {
                yield return list[index];
            }
        }

        public static Customlist<T> operator +(Customlist<T> one, Customlist<T> two)
        {
            int counter2 = 0;
            int counter = 0;
            Customlist<T> newlist = new Customlist<T>();
            while (counter < (one.count))
            {


                newlist.Add(one[counter]);

                counter++;


            }
            while (counter2 < (two.count))
            {


                newlist.Add(two[counter2]);

                counter2++;


            }

            return newlist;
        }
        //public static Customlist<T> operator -(Customlist<T> one, Customlist<T> two)
        //{
        //    T deadThing;
        //    int counteer2 = 0;
        //    int counteer = 0;
        //    int delCounter2 = 0;
        //    int delCounter = 0;
        //    while (counteer2 < two.Count)
        //    {
        //        while (counteer < one.Count)
        //        {
        //            if (one[delCounter].Equals(two[delCounter2])) 
        //            { deadThing = one[delCounter];
        //                int counta=0;foreach
        //                int counta1=0;
        //                int counta2 = 0;
        //                while (counta < one.Count)
        //                {
        //                    if (deadThing.Equals(one[counta]))
        //                    {
        //                        counta++;
        //                        counta1++;



        //                    }
        //                    else
        //                    {

        //                    }
        //                }

        //                    while (counta1 > 0) { one.Remove(deadThing); counta1--; }



        //                 counta = 0;
        //                while (counta < two.Count)
        //                {
        //                    if (deadThing.Equals(two[counta]))
        //                    {
        //                        counta++;
        //                        counta2++;



        //                    }
        //                    else
        //                    {
        //                        counta++;
        //                    }




        //                } while (counta2 > 0) { two.Remove(deadThing); counta2--; }




        //            }
        //            counteer++;
        //        }



        //        counteer2++;




        //    }

        //    return one + two;
        //}


        public static Customlist<T> operator -(Customlist<T> one, Customlist<T> two)
        {
            
            foreach (T item in one)
            {

                for (int index = 0; index < two.count; index++)
                {
                    if (item.Equals(two[index])) 
                    { one.Remove(item); }
                }
               
            }
            
            return one;
        }
























        }      
}
