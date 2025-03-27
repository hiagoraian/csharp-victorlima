namespace estruturaCondicional;

public class aula05
{
    public static void estruturaCondicional()
    {
        Console.WriteLine("Verificando o nível");
        Console.WriteLine("Qual sua pontuação: ");
        int score = Convert.ToInt32(Console.ReadLine());

        if(score <= 3)
            Console.WriteLine("Ruim");

        else if(score >=4 && score <=7)
            Console.WriteLine("Média");
       
        else if(score>7 && score<=10)
            Console.WriteLine("Acima da média");

        else
            Console.WriteLine("Nota invalida");
    }
}