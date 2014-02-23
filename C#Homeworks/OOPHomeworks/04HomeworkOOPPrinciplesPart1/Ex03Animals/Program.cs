using System;
using System.Linq;

namespace Ex03Animals
{
    class Program
    {
        static void Main()
        {
            Animal[] fewAnimals = { new Cat(12,"pisi","female"), new Dog(9,"reks","male"),new Frog(6,"kvachko","male") };
            var averageAge = fewAnimals.Average(x => x.Age);
            Console.WriteLine("The average age of these 3 animals(cat,dog,frog) is: {0}",averageAge);

            Animal[] otherAnimals = { new Tomcat(16, "tommy", "male"), new Kitten(4, "pisanka", "female"),new Frog(8,"kvinka","female"),
                                    new Dog(12,"luki","male")};
            var averageAgeTwo = otherAnimals.Average(x => x.Age);
            Console.WriteLine("The average age of these 4 animals(tomcat,kitten,frog,dog) is: {0}", averageAgeTwo);
           
        }
    }
}
