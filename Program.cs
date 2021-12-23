using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Pet myDog = new Pet("Daisy", 2, "easygoing beautiful poodle");
            Pet myCat = new Pet("Fluffy", 1, "stubborn persian cat");
            Pet myBird = new Pet("Blue", 3, "playful arara");
            Pet myFish = new Pet("Nemo", 1, "silly clownfish");

            //2
            //List<Pet> myPets = new List<Pet>() { myDog, myCat, myBird, myFish };
            List<Pet> myPets = new List<Pet>();

            myPets.Add(myDog);
            myPets.Add(myCat);
            myPets.Add(myBird);
            myPets.Add(myFish);

            //3
            myDog.Train();
            myCat.Train();

            myCat.SetOwner("Jane");
            myBird.SetOwner("John");
            myFish.SetOwner("Jane");

            //4
            foreach (Pet p in myPets)
                Console.WriteLine(p.ToString());

            //5
            Console.WriteLine("-------------------------------");
            Console.Write("Find pets that belong to: ");
            string owner = Console.ReadLine();

            bool found = false;
            foreach (Pet p in myPets)
                if (p.Owner.ToUpper() == owner.ToUpper())
                {
                    Console.WriteLine(p.ToString());
                    found = true;
                }

            if (!found)
                Console.WriteLine($"No pets found belonging to {owner}");

            Console.WriteLine("-------------------------------");

        }
    }
}
