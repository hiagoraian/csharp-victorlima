namespace files;

using System.IO;
public class aula16
{
    public static void files()
    {   
        /**Criando um arquivo**/
        string path = @"C:\Users\hiago.carvalho\Documents\hiago\csharp-victorlima\files\";
        string fileName = "myDocument.Doc";
        string filepath = path + fileName;

        string content = "Hiago Raian Gonçalves Carvalho\n";
        File.WriteAllText(filepath,content);

        /**Adicionando Conteúdo**/

        string additionalContent = "Dia 01, iniciando em C#\n";
        File.AppendAllText(filepath,additionalContent);

        /**Ler arquivo**/
        string fileContent = File.ReadAllText(filepath);
        Console.WriteLine("Conteúdo do Arquivo: " + fileContent);
    }
}