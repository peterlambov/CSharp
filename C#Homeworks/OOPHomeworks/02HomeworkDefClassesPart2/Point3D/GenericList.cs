using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


  public  class GenericList<T>
    {
        private T[] elements;
        private int count = 0;

        public GenericList(int capacity)
        {
            this.elements = new T[capacity];
        }

        public int Count
        {
            get { return this.count; }
        }

        public void Add(T element)
        {
            
                if (count == elements.Length)
                {
                    GrowCapacity();
                }
            this.elements[count] = element;
            count++;
        }

        public void RemoveByIndex(int index)
        {
            if (index < this.elements.Length && index >= 0)
            {
                T[] tempList = new T[this.elements.Length - 1];
                bool mark = true;
                for (int i = 0; i < elements.Length - 1; i++)
                {
                    if (index == i)
                    {
                        mark = false;
                    }

                    if (mark == true)
                    {
                        tempList[i] = this.elements[i];
                    }

                    else
                    {
                        tempList[i] = this.elements[i + 1];
                    }
                }
                this.elements = tempList;
            }

            else
            {
                throw new IndexOutOfRangeException("Invalid index!");
            }
        }

        public void InsertElementAtPosition(int index,T element)
        {
            if (count == elements.Length)
            {
                GrowCapacity();
            }
            if (index < this.elements.Length && index >= 0)
            {
                T[] tempList = new T[this.elements.Length + 1];
                bool mark = true;
                for (int i = 0; i < elements.Length + 1; i++)
                {
                    if (index == i)
                    {
                        mark = false;
                        elements[index] = element;
                        continue;

                    }

                    if (mark == true)
                    {
                        tempList[i] = this.elements[i];
                    }

                    else
                    {
                        tempList[i] = this.elements[i - 1];
                    }
                }
                this.elements = tempList;
            }

            else
            {
                throw new IndexOutOfRangeException("Invalid index!");
            }
        }

        public void GrowCapacity()
        {

            T[] tempArray = new T[elements.Length * 2];
            Array.Copy(elements, 0, tempArray, 0, elements.Length);
            elements = tempArray;
        }

        public  T Min()
           // where T:IComparable<T>  This is a constraint.
        {
            dynamic smallestElement = long.MaxValue; //using dynamic type is another hint that enables the compilator to make the comparison.
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] < smallestElement)
                {
                    smallestElement = this.elements[i];
                }
            }
            return smallestElement;
        }

        public  T Max()
        //where T:IComparable<T>   Constraint again.
        {
            dynamic biggestElement = int.MinValue;
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] > biggestElement)
                {
                    biggestElement = this.elements[i];
                }   
            }
            return biggestElement;
        }
        public T this[int index]
        {
            get
            {
                if (index >= count || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                T result = elements[index];
                return result;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            foreach (var item in elements)
            {
                result.AppendLine(item.ToString());
            }
            return result.ToString();
        }
    }

