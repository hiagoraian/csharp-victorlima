namespace operadoresAtribuicao;

public class aula06
{
    public static void operadoresAtribuicao()
    {
        /**Operador de Atribuição Simples (=)**/
        int valueA = 10;
        Console.WriteLine("\nValor da atribuição simples: "+ valueA);

        /**Atribução Composta(incremento ++)(decremento --)**/
        valueA--;
        Console.WriteLine("\nValor decremento: "+ valueA);
        valueA++;
        Console.WriteLine("Valor incremento: "+ valueA);

        /**Atribuição Composta(+= e -=) => (valueB = valueB +1 -- valueB = valueB-1)**/ 
        int valueB = 20;
        valueB +=1;
        Console.WriteLine("\nValor da atribuição adição: "+valueB);
        valueB -=1;
        Console.WriteLine("Valor da atribuição subtração: "+valueB);

    }
}