namespace inputOutput;

public class aula03
{
    public static void inputOutput()
    {
        Console.WriteLine("----------Dados Pessoais----------");
         
        Console.WriteLine("Digite seu nome: ");
        string name = Console.ReadLine();

        Console. WriteLine("Qual sua idade: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Seu nome é "+ name + " e sua idade é " +age);
    }

}