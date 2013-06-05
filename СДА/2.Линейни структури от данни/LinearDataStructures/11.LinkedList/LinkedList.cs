using System;

namespace _11.LinkedList
{
   public class LinkedList<T>
    {
        private ListItem<T> FirstElement { get; set; }

        public int Count()
        {
            if (FirstElement == null)
            {
                return 0;
            }

            int count = 1;

            var listItem = this.FirstElement;
            while (listItem.NextItem != null)
            {
                count++;

                listItem = listItem.NextItem;

            }
            return count;
        }

        public void AddFirst(T value)
        {
            if (this.FirstElement == null)
            {
                this.FirstElement = new ListItem<T>(value);
            }
            else
            {
                ListItem<T> element = new ListItem<T>(value);

                element.NextItem = this.FirstElement;
                this.FirstElement = element;
            }
        }

        public void AddLast(T value)
        {
            if (this.FirstElement == null)
            {
                this.FirstElement = new ListItem<T>(value);
            }
            else
            {
                ListItem<T> element = this.FirstElement;

                while (element.NextItem != null)
                {
                    element = element.NextItem;
                }

                element.NextItem = new ListItem<T>(value);
            }
        }
        public void Remove(T value)
        {
            if (this.FirstElement == null)
            {
                throw  new ArgumentNullException("There aren`t elements in the list");
            }

            var listItem = this.FirstElement;

            ListItem<T> removeElement = listItem;
            ListItem<T> element = new ListItem<T>(value);
 
            while (listItem.NextItem != null)
            {           

                if ((dynamic)listItem.Value == (dynamic)element.Value)
                {
                    removeElement = listItem.NextItem;

                    this.FirstElement.NextItem = removeElement;

                    break;                    
                }

                this.FirstElement.NextItem = removeElement.NextItem;
                listItem = listItem.NextItem;

            }
        }

       public void PrintList()
       {
           var listItem = this.FirstElement;

           Console.WriteLine(listItem.Value);
            
           while (listItem.NextItem != null)
           {
               listItem = listItem.NextItem;
               Console.WriteLine(listItem.Value);
           }
       }
    }
}
