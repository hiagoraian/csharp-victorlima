namespace Calculadora;
public class testeCalculadora
{
    public static void result()
    {
        Console.WriteLine("----------Calculadora de 2 números inteiros----------");
        Console.WriteLine("\n1- Soma | 2-Subtração | 3-Multiplicação | 4-Divisão\n ");
        int op = Convert.ToInt32(Console.ReadLine());

        if(op>4)
        {
            Console.WriteLine("Opção Invalida!");
            //Environment.Exit(1); -> Finalizar a operação
            result();  // Chama a função novamente para reiniciar
            return;  // Interrompe a execução da função atual
        }

        Console.WriteLine("Primeiro número: ");
        int valueA = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Segundo número: ");
        int valueB = Convert.ToInt32(Console.ReadLine());

        if(op==1)
        {   
            int result = valueA+valueB;
            Console.WriteLine("O valor da Soma é: "+ result);
        }
        else if(op==2)
        {
            int result = valueA-valueB;
            Console.WriteLine("O valor da Subtração é: "+ result);
        }
        else if(op==3)
        {
            int result = valueA*valueB;
            Console.WriteLine("O valor da Multiplicação é: "+ result);
        }
        else if(op==4)
        {
            int result = valueA/valueB;
            Console.WriteLine("O valor da Divisão é: "+ result);
        }
        else
            Console.WriteLine("Resultado não encontrado");
    }
}