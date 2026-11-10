using LINQ_adatbazis_feladat;

namespace LINQ_adtabazis_feladat;

internal class Program
{
    private static void Main()
    {
        Database database = new();
        List<Diak> diakok = database.DiakokBetoltese();
        foreach(Diak diak in diakok)
        {
            Console.WriteLine(diak.Name);
        }
    }
}