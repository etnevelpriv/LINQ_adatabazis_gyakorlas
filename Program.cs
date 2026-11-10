using LINQ_adatbazis_feladat;

namespace LINQ_adtabazis_feladat;

internal class Program
{
    private static Database database = new();
    private static List<Diak> diakok = database.DiakokBetoltese();

    private static void ClassAvgByClassname()
    {
        Console.WriteLine("\n1. feladat");
        var eredmeny = diakok
            .GroupBy(diak => diak.ClassName)
            .Select(csoport => new { Osztaly = csoport.Key, Atlag = csoport.Average(diak => diak.Average) });
        foreach (var adat in eredmeny)
        {
            Console.WriteLine($"{adat.Osztaly} : {adat.Atlag:f2}");
        }
    }

    private static void RankDescAvgByClassnameGroup()
    {
        Console.WriteLine("\n2. feladat");
        var eredmeny = diakok
            .GroupBy(diak => diak.ClassName)
            .Select(csoport => new { Osztaly = csoport.Key, Atlag = csoport.Average(diak => diak.Average) })
            .OrderByDescending(csoport => csoport.Atlag);
        foreach (var adat in eredmeny)
        {
            Console.WriteLine($"{adat.Osztaly} : {adat.Atlag:f2}");
        }

    }

    private static void MaxStudentAvgGroupByClassname()
    {
        Console.WriteLine("\n3. feladat");
        var eredmeny = diakok
            .GroupBy(diak => diak.ClassName)
            .Select(csoport =>
            {
                double legjobbAtlag = csoport.Max(diak => diak.Average);
                return csoport
                    .Where(diak => diak.Average == legjobbAtlag)
                    .Select(diak => new
                    {
                        diak.Name,
                        diak.ClassName,
                        diak.Average
                    }
                    );
            }
            );
        foreach (var adat in eredmeny)
        {
            foreach (var adattag in adat)
            {
                Console.WriteLine(adattag);
            }
        }
    }

    private static void StatWhitStudentsAge()
    {
        Console.WriteLine("\n4. feladat");
        var eredmeny = diakok
            .GroupBy(diak => diak.Age)
            .Select(csoport => new
            {
                Age = csoport.Key,
                Counter = csoport.Count()
            });
        foreach (var adat in eredmeny)
        {
            Console.WriteLine($"{adat.Age} : {adat.Counter}");
        }
    }

    private static void StudentsWithUnderTwoAvg()
    {
        Console.WriteLine("\n5. feladat");
        var eredmeny = diakok
            .Where(
                diak => diak.Average < 2
            )
            .Select(diak => new
            {
                Name = diak.Name
            });
        if (eredmeny.Count() == 0)
        {
            Console.WriteLine("Nincs olyan diak, aki 2-es atlag alatt lenne");
        }
        else
        {
            foreach (var adat in eredmeny)
            {
                Console.WriteLine(adat.Name);
            }
        }
    }

    private static void Main()
    {
        ClassAvgByClassname();
        RankDescAvgByClassnameGroup();
        MaxStudentAvgGroupByClassname();
        StatWhitStudentsAge();
        // Otodik feladat ugyan az, mint a harmadik
        StudentsWithUnderTwoAvg();
    }
}