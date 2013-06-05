using System;
using System.Linq;

namespace RefactorCode
{
    public class Chef
    {
        private Bowl GetBowl()
        {
            return new Bowl();
        }

        private Potato GetPotato(int quantity)
        {
            return new Potato(quantity);
        }

        private Carrot GetCarrot(int quantity)
        {
            return new Carrot(quantity);
        }

        private void Peel(Vegetable vegetable)
        {
            Console.WriteLine("Peeling!: {0}, {1}", vegetable.Quantity, vegetable.GetType());
        }

        private void Cut(Vegetable vegetable)
        {
            Console.WriteLine("Cuting!: {0}, {1}", vegetable.Quantity, vegetable.GetType());
        }

        public void Cook()
        {
            Potato potato = GetPotato(444);
            Carrot carrot = GetCarrot(333);

            Peel(potato);
            Peel(carrot);
            Cut(potato);
            Cut(carrot);
            Bowl bowl = GetBowl();
            bowl.Add(carrot);
            bowl.Add(potato);
        }
    }
}