namespace metodoSwitch;
public class aula09 
{
    public static void metodoSwitch()
    {
        int number = 2;

        switch(number)
        {
            case 1:
                Console.WriteLine("Número 1");
                break;

            case 2:
                Console.WriteLine("Número 2");
                break;

            default:
                Console.WriteLine("Opção Invalida");
                break;
        }
    }
}