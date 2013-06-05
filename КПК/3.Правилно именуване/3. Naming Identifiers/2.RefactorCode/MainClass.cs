using System;
using System.Linq;

namespace RefactorCode
{
    class MainClass
    {
        enum Sex
        {
            Male,
            Female
        };

        class Person
        {
            public Sex Sex { get; set; }
            public string NamePerson { get; set; }
            public int Age { get; set; }           
        }
        private Person CreateHuman(int age)
        {
            Person someHuman = new Person();
            someHuman.Age = age;

            if (age % 2 == 0)
            {
                someHuman.NamePerson = "Tim Tebow";
                someHuman.Sex = Sex.Male;
            }
            else
            {
                someHuman.NamePerson = "Susan Wesly";
                someHuman.Sex = Sex.Female;
            }
            return someHuman;
        }

        public static void Main()
        {
            MainClass creating = new MainClass();
            Person human = creating.CreateHuman(33);
            Console.WriteLine("Age:"+human.Age + "\nName:" + human.NamePerson + "\nSex:" + human.Sex);
        }
    }
}
  