using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<string> Products = new List<string>{"Nike Shoes", "Adidas Hoodie", "Puma Cap", "Apple Watch", "Samsung Phone"};
        Console.Write("Search: ");
        string keyword = Console.ReadLine()?.ToLower()?? "";
        Console.Write("\nSearch Results: ");
        bool found = false;
        for(int i=0;i<Products.Count;i++)
        {
            if(Products[i].ToLower().Contains(keyword))
            {
                Console.Write("- "+Products[i]);
                found = true;
            }
        }
        if(!found)
        {
            Console.WriteLine("No products matched your search.");
        }
    }
}