namespace metodoDoWhile;
public class aula11
{
    public static void metodoDoWhile()
    {
        /**A diferença é que o Do While executa a primera rodada do loop, mesmo sendo falsa. Igual no exemplo abaixo.**/
        int i = 6;

        do 
        {
            Console.WriteLine("Passou! "+ i);
            i++;
        } while(i<5);
    }
}