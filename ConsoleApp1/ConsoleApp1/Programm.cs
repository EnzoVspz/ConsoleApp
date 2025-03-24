using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Programm
{
    static void Main(string[] args)
    {
        Console.WriteLine("Votre salaire => ");
        string salaireUtilisateur = Console.ReadLine();
        bool testSalaire = int.TryParse(salaireUtilisateur, out int nombre);
        int leSalaireUtilisateur = 0;
        if (testSalaire == true)
        {
            leSalaireUtilisateur = int.Parse(salaireUtilisateur);
        }

        Console.WriteLine("Le tax => ");
        string taxUtilisateur = Console.ReadLine();
        bool testTax = int.TryParse(taxUtilisateur, out int autreNombre);
        int laTaxUtilisateur = 0;
        if (testTax == true)
        {
            laTaxUtilisateur = int.Parse(taxUtilisateur);
        }

        if(testSalaire == false || testTax == false)
        {
            Console.WriteLine("Tant pis pour toi ^^");
        }
        else
        {
            Console.WriteLine("BG en vdv ^^");
        }

        if(leSalaireUtilisateur >= 50000)
        {
            Console.WriteLine("Fais un don sur ma chaine twitch stp.............................................................");
        }
        else if (leSalaireUtilisateur / 12 <= 1500)
        {
            Console.WriteLine("T'as pas d'argent mskn");
        }
        else if(leSalaireUtilisateur >=30000 && leSalaireUtilisateur <= 40000)
        {
            Console.WriteLine("Go au CESI hein ^^^^^^^^^^^^^^^^^^^^^^");
        }
    }

}