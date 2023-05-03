namespace LuzDeAdvertencia;
class Program
{
    static void Main(string[] args)
    {
        string T, P, R;

        Console.Clear();
        
        Console.WriteLine("Ativado ou Desativado...");

        Console.WriteLine();
        
        Console.Write("Temperatura.............: ");
        T = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper();

        Console.Write("Pressão.................: ");
        P = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper();

        Console.Write("Rotação.................: ");
        R = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper();


        if (T != "A" && T != "D"
        || P != "A" && P != "D"
        || R != "A" && R != "D")

        {
            Console.Write("Algo de errado não está certo...");
        }

        else if (T == "A" && (P == "A" || R == "D"))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("ATIVADO!");
            Console.ResetColor();
        }

        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("DESATIVADO!");
            Console.ResetColor();
        }
    }
}
