using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz2 {
    class Program {
        static void Main(string[] args) {

            LinkedList<Pet> unsortedList = new LinkedList<Pet>();

            Pet p1 = new Pet();
            p1.Name = "Barley";
            p1.Age = 8;
            p1.Weight = 25;
            p1.Height = 40;

            Pet p2 = new Pet();
            p2.Name = "Boots";
            p2.Age = 4;
            p2.Weight = 23;
            p2.Height = 42;

            Pet p3 = new Pet();
            p3.Name = "Whiskers";
            p3.Age = 1;
            p3.Weight = 25;
            p3.Height = 31;


            unsortedList.AddLast(p1);
            unsortedList.AddLast(p2);
            unsortedList.AddLast(p3);

            IEnumerable<Pet> SortedListAge = unsortedList.OrderBy(pet => pet.Age);
            Console.WriteLine("****LIST OF PETS SORTED BY AGE****");
            printList(SortedListAge);


            IEnumerable<Pet> SortedListWeight = unsortedList.OrderBy(pet => pet.Weight);
            Console.WriteLine("****LIST OF PETS SORTED BY WEIGHT****");
            printList(SortedListWeight);

            Console.ReadLine();

        }

        static void printList(IEnumerable<Pet> list) {

            foreach (Pet pet in list) {
                Console.WriteLine("{0} - {1} - {2} - {3}", pet.Name, pet.Age, pet.Height, pet.Weight);
            }
            Console.WriteLine("");

        }

    }
}
