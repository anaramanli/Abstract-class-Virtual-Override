using ConsoleApp1.Interface;
using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            new Student();
            new Student();
            new Student();
            new Student();
            new Student();
            Student s = new Student();




        }
    }
}
