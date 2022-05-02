using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            // T => it is type of object
            
            //A list which contains integer type values
            List<int> numberList = new List<int>();
            numberList.Add(4);
            numberList.Add(5);
            numberList.Add(1);

            //A list which contains string type values
            List<string> colorList = new List<string>();
            colorList.Add("Kırmızı");
            colorList.Add("Sarı");
            colorList.Add("Mavi");

            //Let's write those lists
            foreach(var item in colorList)
            { Console.WriteLine(item); }
            foreach(var item in numberList)
            { Console.WriteLine(item); }

            //Writing the number of List members
            Console.WriteLine("the Color List has " + numberList.Count + " members.");

            //Another way of write lists
            numberList.ForEach(color => Console.WriteLine(color));
            colorList.ForEach(number => Console.WriteLine(number));

            //Removing member from lists
            colorList.Remove("Mavi");

            //Removing member by index number from lists
            colorList.RemoveAt(1);

            //Searching member from lists
            bool isContains = colorList.Contains("Kırmızı");
            colorList.ForEach(color => Console.WriteLine(color));
            if (isContains)
                Console.WriteLine("Yes, 'colorList' list contains member that named 'Kırmızı'.");

            //Getting index of member
            int index = colorList.IndexOf("Kırmızı");
            Console.WriteLine(index);

            //Another way to getting index of member form lists
            int index2 = colorList.BinarySearch("Kırmızı");
            Console.WriteLine(index2);

            //Converting a Array to List
            string[] animalArray = new string[] { "Bird", "Monkey", "Lion", "Pigeon", "Donkey", "Giraffe" };
            List<string> animalList = new List<string>(animalArray);

            //Clearing a list
            List<string> verbs = new List<string>();
            verbs.AddRange(new string[]{ "Veni", "Vidi", "Vici"});
            verbs.Clear();

            //Holding an object in a list
            //Before getting started we must create a new class, we have a class in our program named 'Object'
            Object object1 = new Object(1);
            Object object2 = new Object(2);
            List<Object> ObjectList = new List<Object>();
            ObjectList.AddRange(new Object[] { object1, object2 });
            ObjectList.ForEach(objectInstance => Console.WriteLine(objectInstance.objectID));

            Console.ReadLine();
        }
    }

    class Object
    {
        public int objectID;
        public Object(int id)
        {
            objectID = id;
        }
    }
}
