using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
 // randomgenerator.Next(1, 3);      // Използване на "рандом", искаме числа в интервал 1 и 3, ще ни връща числа 1 2, разбъркан и    

struct Car
{
    public int x;
    public int y;
    public char c;
    public ConsoleColor color;      // Променлива от тип колор
}
class JustCars
{
    private static List<Car> newList; 
                                                  

    static void PrintonPosition(int x, int y, char c, ConsoleColor color = ConsoleColor.Red)// Метод, който изпълнява това което му казвам. На позиция "х" и "у", кой сомвол да принтира там и също някакъв цвят на определен символ
    {
        Console.SetCursorPosition(x, y);           //Метод за писане по консолата, мести нашия курсор 
        Console.ForegroundColor = color;       // Цвета на който изписваме "с" да е равем на колор
        Console.Write(c);         // На тази позиция изписваме символа "с"      
    }
    static void PrintStringonPosition(int x, int y, string str, ConsoleColor color = ConsoleColor.Yellow) // Метод, който няма да принтира сумвол, но ще изпише стринг на определена позиция 
    {
        Console.SetCursorPosition(x, y);           //Метод за писане по консолата, мести нашия курсор 
        Console.ForegroundColor = color;       // Цвета на който изписваме "с" да е равем на колор
        Console.Write(str);         // На тази позиция изписваме символа "с"      
    }
    static void Main(string[] args)
    {
        int liveScore = 5; 
        int playfieldWight =8;                            // Дефиниране размера на полето
            Console.BufferHeight = Console.WindowHeight = 30;
            Console.BufferWidth = Console.WindowWidth = 30;    // Махане на скролбара, да го няма

            Car userCar = new Car();                              // Oбект от тип "кар", който ще пази кординатите на нашата количка
        userCar.x = 2;
        userCar.y = Console.WindowHeight-1;
        userCar.c = '^';
        userCar.color = ConsoleColor.Magenta;
        Random randomgenerator = new Random();  // Рандом за изкарване на произволни числа

        List<Car> cars = new List<Car>();   // Прибавяме и методите от по-рано: add,remove, работим с този списък.Списък с дуги колички т.е, списък с обекти от горните "х","у","color", същите като на наща, но с променени параметри

        while (true)
        {
            {
                Car newCar = new Car();           // За да имаме и други колички, правим си обект от тип количка  
                newCar.color = ConsoleColor.Green;
                newCar.x = randomgenerator.Next(0, playfieldWight);   // "х" трябва да бъде произволно число между 0 и горното "playfieldWight", ще ни връща числа в интервал между 0 и 4                                  
                newCar.y = 0;    // Винаги трябва да бъде горе и за това е 0
                newCar.c = '@';   // Символ на колата 
                cars.Add(newCar);         // Тази количка всеки път е нова и всеки път се създава, защото цикъла всеки път се извиква. Тази нова количка я добавяме в списъка с колички, с новата количка 
            }
            while (Console.KeyAvailable)         // Булево свойство в конзолата "кеи авелабал". Дали потребителя е натиснал копче, ако не е продължава надоло, ако да го взимаме
            {
                ConsoleKeyInfo pressedkey = Console.ReadKey(true);   // Местим нашата количка. Гледаме дали потребителя е натиснал няколе копче и ако е натиснал местим нашата кола(key pressed)

                
                                                             // В един безкраен цикъл, прочитам копчето. Докато има копче в буфера се чете копчето, с цел да върви по-плавно местенето      
                

               if (pressedkey.Key == ConsoleKey.LeftArrow)        // Проверяваме ако натиснатото копче е равно на зададеното в "конзолкей.лефтаррол" - копче на ляво
                {
                    if (userCar.x - 1 >= 0)
                    {
                        userCar.x = userCar.x - 1;             // Тогава на потребителя му намаляваме с единица "х" 
                    }
                }
               if (pressedkey.Key == ConsoleKey.UpArrow)        
               {
                   if (userCar.y - 1 >= 0)
                   {
                       userCar.y = userCar.y - 1;             
                   }
               }
               if (pressedkey.Key == ConsoleKey.DownArrow)
               {
                   if (userCar.y + 1 >= 0)
                   {
                       userCar.y = userCar.y + 1;
                   }
               }
                else if (pressedkey.Key == ConsoleKey.RightArrow)       // Ако натиснатото копче е "райдерол", стрелка на дясно, отново правим следната проверка
                {
                    if (userCar.x + 1 < playfieldWight)
                    {
                        userCar.x = userCar.x + 1;
                    }
                }
            }
            List<Car> newList = new List<Car>(); 
            for (int i = 0; i < cars.Count; i++)// Местим количките, всеки път количките сализат към нас, ние бягаме от тях (Move cars)
            {
              
                Car oldCar = cars[i];
                Car newCar = new Car();
                newCar.x = oldCar.x;
                newCar.y = oldCar.y + 1;
                newCar.c = oldCar.c;
                newCar.color = oldCar.color;
                if (newCar.y == userCar.y && newCar.x == userCar.x)
                {
                    cars.Clear();
                    liveScore--;
                    if (liveScore<=0)
                    {
                        PrintStringonPosition(15, 7, "GAME OVER!!!!", ConsoleColor.Blue);
                        PrintStringonPosition(14, 10, "Press [Enter] to exit", ConsoleColor.Blue);
                        Console.ReadLine();
                        return;

                    }
                }
                if (newCar.y < Console.WindowHeight)
                {
                     newList.Add(newCar);
                }

            }
            cars = newList;
             // Ако някоя количка ни блъсне ни взима живот, и ни показва колко живота имаме. Проверяваме дали сме блъснати

            Console.Clear();             // Изчистване на всичко преди да пречертае игралното поле (Clear the consle)

            PrintonPosition(userCar.x, userCar.y, userCar.c, userCar.color);     // Тази функсзия ще изпише количката. Написване на резултата, ще бъде в две полета, на едното ще бъде резултата на другото действието (Draw info)

            foreach (Car car in cars)
            {
                PrintonPosition(car.x, car.y, car.c, car.color);   // Рисуваме всички тия колички. Взимаме от колекцията карс всяка една количка 
            }

            PrintStringonPosition(12, 4, "Lives:" + liveScore, ConsoleColor.Cyan);     // Начертаване на игралното поле (Draw playfield)

            Console.Beep();
            Thread.Sleep(300);     // Кара нашето приложение да спре, за да не паднат бързо, защото конзолата действа бързо, трябва да се забавят (Slow down program)
        }
}



   
}
    