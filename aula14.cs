namespace metodoArray;
public class aula14
{
    public static void metodoArray()
    {
        string[] fruits = {"maçã" ,"banana", "caju", "manga"};

        foreach(string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine("\nO array tem "+ fruits.Length +" elementos");

        fruits[1] = "Abacaxi";

    }
}