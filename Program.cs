using System;
using System.Collections;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Creating list of strings.
            var names = new List<String>();
            names.Add("Benji");
            names.Add("Arab Money");
            names.Add("Hameed");
            names.Add("Oseremhen");
            names.Add("Barca");

            // create number List.

            var nums = new List<int>();
            nums.Add(12);
            nums.Add(23);
            nums.Add(34);
            nums.Add(45);
            nums.Add(56);

            foreach(int i in nums)
            {
                Console.WriteLine(i);
            }

            //interate the elements using for loop.

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}