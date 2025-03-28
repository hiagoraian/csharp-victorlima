namespace metodoList;
public class aula15
{
    public static void metodoList()
    {
        /**Listas são mais utilizadas que arrays no C#, na documentação tem varias funções que são permitidas de usar com Listas: como remover, adicionar, alterar,limpar, ordenar, etc**/
        List<int> numbers = new List<int>();
        List<string> fruits = new List<string>()
        {
            "manga","banana","caju","abacaxi"
        };

        writeFruits(fruits);

       Console.WriteLine("\nAdiconando um novo elementos\n");
        fruits.Add("limão");
        writeFruits(fruits);

        Console.WriteLine("\nRemovendo um elementos\n");
        fruits.Remove("banana");
        writeFruits(fruits);
    }
    public static void writeFruits(List<string> x)
    {
        foreach (string fruit in x)
        {
            Console.WriteLine(fruit);
        }
    }
}