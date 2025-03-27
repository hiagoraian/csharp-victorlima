namespace operadoresAritmeticos;

public class aula04
{
    public static void operadoresAritmeticos()
    {
        int valueA = 2;
        int valueB = 10;
        int valueC = 30;


        int soma = valueA + valueB;
        int subtracao = valueC - valueA;
        double divisao = valueB / valueA;
        int multiplicacao = valueA * valueC;

        Console.WriteLine("soma: "+soma+" subtracao: "+subtracao+" multiplicacao: "+multiplicacao+" divisao: "+divisao);

    }
}