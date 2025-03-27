namespace operadoresRelacionais;

public class aula07
{
    public static void operadoresRelacionais()
    {
        Console.WriteLine("Digite o primeiro número: ");
        int valueA = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        int valueB = Convert.ToInt32(Console.ReadLine());
  


        /**Operador de igualdade**/
        /**Operador maior, menor, maior igual, menor igual**/
        if(valueA == valueB)
            Console.WriteLine("Número igual");
        else 
           {        
            if(valueA >= valueB)
                Console.WriteLine("Primeiro número maior");
            else 
                Console.WriteLine("Segundo número maior");

           }
    }
}