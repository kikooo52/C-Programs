using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class GenericList<T> where T:IComparable
    {

        private T[] elements;
        private int capacity;
        private int count = 0;
        private bool hasUsed = false;



        public GenericList(int capacity)      
        {
            if (capacity > 0)
            {
                this.capacity = capacity;
                this.elements = new T[capacity];
            }
            else
            {
                throw new ArgumentOutOfRangeException("The indexes must to be bigger of 0");   
            }       
        }

        public void AddElement(T element)
        {
            if (count < capacity)
            {
                this.elements[count] = element;
                count++;
                hasUsed = true;
                if (count == elements.Length)
                {
                    autoGrow();
                }
            }
            else
            {                                                              
                throw new ArgumentOutOfRangeException("Capacyry Full, plase cleer array");
            }
        }

        public int FindIndex(T element)
        {          
            if (Array.IndexOf(elements, element) == -1)
            {
                throw new IndexOutOfRangeException("'FindIndex' There are not such index");  
            }
            return Array.IndexOf(elements, element);
        }

        public void RemoveElemenByIndext(int IndexOfElement)
        {
            if (IndexOfElement >= count)
            {
                throw new IndexOutOfRangeException("'RemoveElemenByIndext'There are not such element");
            }
            this.elements[IndexOfElement] = elements[count +1];
            

        }

        public void InsertElement(int Index,T Element)
        {
            if (Index >= capacity)
            {
                throw new IndexOutOfRangeException("'InsertElement' Index is outsite of the array");
            }
            this.elements[Index] = Element;            
        }

        public void Clear()
        {
            if (hasUsed)
            {
            elements = new T[elements.Length];
            count = 0;
            hasUsed = false;
            }
            else
            {
                throw new FormatException("'Clear' Please first add elements");
            }
        }

        public override string ToString()
        {
            StringBuilder elementResult = new StringBuilder();
            for (int i = 0; i < count; i++)
			{
                elementResult.Append(elements[i].ToString() +" ");
			}
            return elementResult.ToString();
        }

        private void autoGrow()
        {
            T[] DoubleArray = new T[elements.Length * 2];
            Array.Copy(elements, DoubleArray, elements.Length);
            elements = DoubleArray;
            capacity *= 2;
        }

        public T Max()
        {
            if (hasUsed)
            {
                var maxT = elements.Max(x => x);
                return maxT;
            }
            else
            {
                
                throw new InvalidProgramException("There are not elements");
            }
        }

        public T Min()
        {
            if (hasUsed)
            {
                var minT = elements.Min(x => x);
                return minT;
            }
            else
            {

                throw new InvalidProgramException("There are not elements");
            }
        }

    }
}
