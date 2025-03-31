namespace listaDeCompras;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using NHunspell;

public class testeListaCompras
{
    static string path = @"C:\Users\hiago.carvalho\Documents\hiago\csharp-victorlima\files\";
    static string fileName = "shooping_list.txt";
    static string filePath = Path.Combine(path, fileName);
    static List<string> shoopingList = File.Exists(filePath) ? File.ReadAllLines(filePath).ToList() : new();

    public static void listaDeCompras()
    {
        while (true)
        {
            Console.WriteLine("\nPreparando Lista de Compras");
            Console.WriteLine("1 - Adicionar | 2 - Remover | 3 - Exibir | 4 - Exportar Lista");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("Digite o item:");
                    string itemInsert = Console.ReadLine();
                    if (!string.IsNullOrEmpty(itemInsert))
                    {
                        string corrigido = FormatProperly(CorrigirOrtografia(itemInsert));
                        shoopingList.Add(corrigido);
                        Console.WriteLine($"O item '{corrigido}' foi adicionado");
                    }
                    else
                        Console.WriteLine("O item não pode ser vazio!");
                    break;

                case 2:
                    Console.WriteLine("Digite o item para remover:");
                    string itemRemove = Console.ReadLine();
                    if (shoopingList.Remove(itemRemove))
                        Console.WriteLine($"Item '{itemRemove}' removido.");
                    else
                        Console.WriteLine("Item não encontrado!");
                    break;

                case 3:
                    Console.WriteLine("\nItens da Lista:");
                    Console.WriteLine(shoopingList.Count == 0 ? "Lista vazia!" : string.Join("\n", shoopingList));
                    break;

                case 4:
                    SalvarLista();
                    return;
            }
        }
    }

    static void SalvarLista()
    {
        var formatados = new HashSet<string>(shoopingList.Select(FormatProperly)); // Remove duplicatas mantendo acentuação
        File.WriteAllLines(filePath, formatados);
        Console.WriteLine("Lista salva com sucesso!");
    }

    static string FormatProperly(string input)
    {
        if (string.IsNullOrWhiteSpace(input)) return string.Empty;
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        return textInfo.ToTitleCase(input.Trim().ToLower()); // "Primeira Letra Maiúscula"
    }

    static string CorrigirOrtografia(string texto)
    {
        using (Hunspell hunspell = new Hunspell("Portuguese (Brazilian).aff", "Portuguese (Brazilian).dic")) // Certifique-se de ter esses arquivos no diretório
        {
            string[] palavras = texto.Split(' ');
            for (int i = 0; i < palavras.Length; i++)
            {
                if (!hunspell.Spell(palavras[i])) // Se estiver errado
                {
                    List<string> sugestoes = hunspell.Suggest(palavras[i]);
                    if (sugestoes.Count > 0)
                        palavras[i] = sugestoes[0]; // Usa a primeira sugestão
                }
            }
            return string.Join(" ", palavras);
        }
    }
}
