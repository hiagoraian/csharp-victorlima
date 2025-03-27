namespace operadoresLogicos;
public class aula08
{
    public static void operadoresLogicos()
    {
        bool isLogged = false;
        bool hasAdminAcces = true;

        /**Operadores Lógicos, E &&, OU ||, Negação !**/

        if(isLogged)
        {
            if(isLogged && hasAdminAcces)
                {
                    Console.WriteLine("Acesso ao painel de administrador");
                }
                else
                {
                    Console.WriteLine("Acesso negado!");
                }
        }
        else
            Console.WriteLine("Usuário não está logado");

        /**Será usado a negação quando (!islogged), quando for verificar se o usuário não esta logado de cara.**/

        if(!isLogged)
            Console.WriteLine("Usuário indisponivel");
        else
        {
            isLogged= false;
        }

        Console.WriteLine("\nVerificando usuário: "+ isLogged);

    }
}