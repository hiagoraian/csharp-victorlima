namespace metodoForeach;
public class aula13
{
    public static void metodoForeach()
    {
        /**A instrução For executa um bloco de código enquanto uma expressão booleana for verdadeira.
        Já a instrução Foreach executa um bloco de códgio para cada elemento de uma coleção.**/

        List<int> numberList = new List<int>(){1,2,3,4,5,6,7,8,9,10};

        foreach(int number in numberList)
        {
            Console.WriteLine(number);
        }

    }
}