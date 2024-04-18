using ConsoleApp1.Interface;
using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Upcasting, Downcasting



            //Poly
            /*Wild wolf = new("Wolf");
            Birds pigeon = new("Pigeon");
            Animal[] animals = { wolf, pigeon, new Wild("Fox") };

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }

            wolf.Eat();*/


            //Interface
            /*List<ISwim> swimmers = new List<ISwim>();
            ISwim dog = new Dog("Toplan");*/
            /*swimmers.Add();*/
            /*Animal a = new Fish("Nemo");
            a.Eat();*/
            /*ISwim dog = new Dog("Max");
            ISwim fish = new Fish("Nemo");
            ISwim[] swimmers = new ISwim[] { fish, dog };
            foreach (var swimmer in swimmers)
            {
                swimmer.Swim();
            }*/

            //Static
            /*Student student = new Student();
            student.SayHi("Anar ");*/

            /*new Student();
            new Student();
            new Student();
            new Student();
            new Student();
            Student s = new Student();*/

            /*Birds toyuq = new Birds("toyuq");
            Dog pitbull = new Dog("Pitbull");
            Animal a = new Dog("pitbull");
            Animal[] animals = { toyuq, pitbull, a };

            foreach (var animal in animals)
            {
                /*Dog dog = animal as Dog;
                if (dog != null)
                {
                    dog.Swim();
                }#1#

                if (animal is Birds birds)
                {
                    //downcasting
                    /*Birds birds = (Birds) animal;#1#
                    birds.Fly();
                }
                else if (animal is Dog)
                {
                    Dog dog = (Dog)animal;
                    dog.Burry();
                }
            }*/
            #endregion

            #region Boxing, Unboxing
            //Boxing => value type-i reference type-a cevirmek
            //Unboxing => reference type-i value type-a cevirmek 
            string text = 5.ToString();//boxing
            int num = Convert.ToInt32(text); //unboxing

            #endregion

            #region Operator Overload
            /*Person Anar = new()
            {
                Name = "Anar",
                Surname = "Amanli",
                Age = 20
            };
            Person Mehriban = new()
            {
                Name = "Mehriban",
                Surname = "Amanli",
                Age = 19
            };
            Person Mehriban1 = new()
            {
                Name = "Mehriban",
                Surname = "Amanli",
                Age = 19
            };
            var a = Mehriban1 != Mehriban;
            Console.WriteLine(a);
            Console.WriteLine(Anar > Mehriban);*/


            #endregion

            Heyvan<Dog> park = new(new Dog[]
            {
                new Dog("Shahin"),
                new Dog("Qartal")
            });
            Heyvan<Fish> park1 = new(new Fish[]
            {
                new Fish("Shahin"),
                new Fish("Qartal")
            });
            Heyvan<int> nums = new Heyvan<int>(new int[] { 1, 2, 3, 4 });

        }
    }

    class Heyvan<T> where T : Animal,ISwim,new()
    {
        public T[] Animals { get; private set; }

        public Heyvan(T[] arr)
        {
            Animals = arr;
        }
    }
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Experience { get; set; }

        public static bool operator >(Person left, Person right)
        {
            return left.Age > right.Age;
        }

        public static bool operator <(Person left, Person right)
        {
            return left.Age < right.Age;

        }
        public static bool operator ==(Person left, Person right)
        {
            if (left.Name != right.Name || left.Surname != right.Surname || left.Age != right.Age)
                return false;
            return true;
        }

        public static bool operator !=(Person left, Person right)
        {
            return !(left == right);

        }
    }
}
