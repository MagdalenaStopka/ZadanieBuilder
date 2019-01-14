
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ZadanieBuilder
{
    class TrescZadania
    {
        /*
         *Wstęp:
Użyjemy wzorca budowniczy do budowy samochodów marki Toyota. Każdy model jest budowany przez innego budowniczego.
Opis działania aplikacji do „produkcji samochodów Toyoty”:
Dyrektor odpowiada za zlecenie budowy konkretnemu budowniczemu. Uzyskuje informację które części są wykonane poprzez metodę GetBuildedParts()
Konkretny budowniczy posiada metody BuildChassis(), BuildEngine(), BuildBody() do budowy poszczególnych części samochodu. Ważne aby każdy budowniczy miał te same metody budowy aut. Kady budowniczy zapamiętuje które części zostały wykonane w jednej zmiennej typu string.
Zadanie:
Utwórz aplikację w której można będzie zlecać dyrektorowi tworzenie samochodów, na podstawie przekazanego konkretnego budowniczego.
Kod metody Main:
static void Main(string[] args)
{
Console.WriteLine("Wytwórnia Toyoty");
Director director = new Director(new Avensis());
director.Construct();
Console.WriteLine(director.GetBuildedParts());
director = new Director(new Corolla());
director.Construct();
Console.WriteLine(director.GetBuildedParts());
//wynik
//Wytwórnia Toyoty
//Podwozie Avensis Silnik Avensis Nadwozie Avensis
//Podwozie Corolla Silnik Corolla Nadwozie Corolla
Console.Read();
}
         */
    }
}