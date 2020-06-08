using System;

namespace AVLTree
{
    class Program
    {
        static void Main(string[] args)
        {
            AVLTree<int> oak = new AVLTree<int>();

            oak.Add(7);
            oak.Add(2);
            oak.Add(6);
            oak.Add(3);
            oak.Add(10);
            oak.Add(13);
            oak.Add(16);

            foreach (var item in oak)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(oak.Contains(5));

            oak.Remove(3);

            foreach (var item in oak)
            {
                Console.WriteLine(item);
            }

            oak.Clear();

            foreach (var item in oak)
            {
                Console.WriteLine(item);
            }
        }
    }
}