namespace controleEstoque;

using System;
using System.Collections.Generic;
public class testeControleEstoque
{
    public static void controleEstoque(){
        List<string> car = new List<string>();
        List<int> balance = new List<int>();


    }

    public static void writeList(List<int> list || List<string> list)
    {
        if(typeof(T) == typeof(int))
        {
            foreach(int balance in list)
            {
                Console.WriteLine(balance);
            }
        }
        else
        {
            foreach(string car in list)
            {
                Console.WriteLine(car);
            }
        }
    }
}