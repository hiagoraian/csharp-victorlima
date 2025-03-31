namespace controleEstoque;

using System;
using System.Collections.Generic;
public class testeControleEstoque
{
    public static void controleEstoque()
    {
        List<string> car = new List<string>();
        List<int> balance = new List<int>();
        while(true)
        {
            Console.WriteLine("---------- Controle Geral ----------");
            Console.WriteLine("1 - Painel de carro | 2 - Painel de valores");
            int panel = Convert.ToInt32(Console.ReadLine());
            
            switch(panel)
            {
                case 1:
                    Console.WriteLine("1 - Adiconar carro | 2 - Remover carro | 3 - Lista de carros");
                    int panelCar = Convert.ToInt32(Console.ReadLine());
                    if(panelCar == 1)
                    {   
                        Console.WriteLine("Qual nome e ano do carro");
                        string nameCarAdd = Console.ReadLine();
                        car.Add(nameCarAdd);
                    }
                    else if(panelCar == 2)
                    {
                        Console.WriteLine("Qual nome e ano do carro");
                        string nameCarRemove = Console.ReadLine();
                        car.Remove(nameCarRemove);
                    }
                    else if(panelCar == 3)
                    {
                        Console.WriteLine("Lista de carros:\n");
                        writeList(car);
                    }
                    else 
                        Console.WriteLine("Opção Invalida");
                    break;

                case 2:
                    Console.WriteLine("1 - Adicionar valor | 2 - Remover valor | 3 - Balanço");
                    int panelBalance = Convert.ToInt32(Console.ReadLine());
                    if(panelBalance == 1)
                    {   
                        Console.WriteLine("Insira um valor: ");
                        int valueAdd = Convert.ToInt32(Console.ReadLine());
                        balance.Add(valueAdd);
                    }
                    else if(panelBalance == 2)
                    {
                        Console.WriteLine("Insira um valor: ");
                        int valueRemove = Convert.ToInt32(Console.ReadLine());
                        balance.Remove(valueRemove);;
                    }
                    else if(panelBalance == 3)
                    {
                        Console.WriteLine("Lista de valores:\n");
                        writeList(balance);
                    }
                    else 
                        Console.WriteLine("Opção Invalida");

                    break;

                default:
                    Console.WriteLine("Opção Invalida");
                    break;
            }
        }
    }

    public static void writeList<T>(List<T> list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}