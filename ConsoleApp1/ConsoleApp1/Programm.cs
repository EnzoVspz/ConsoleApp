using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

class Programm
{
    static void Main(string[] args)
    {
        User test = new User(1, "Jess", "R", 23, 0 , 30);

        Console.WriteLine("Bonjour " + test.firstName + "\nFaire comme avant [1]\nCalculer les interets composes [2]\n");
        
        try
        {
            int choixUser = int.Parse(Console.ReadLine());
            float salaire = 0;
            float taux = 0;
            if (choixUser < 1 || choixUser > 2) 
            {
                Console.WriteLine("Le chiffre doit etre entre 1 et 2 !");
            }
            else if (choixUser == 1)
            {
                Console.WriteLine("On va faire comme avant ...\n");
                Console.WriteLine("Votre salaire ? => ");
                salaire = float.Parse(Console.ReadLine());
                taux = (100 - float.Parse(Console.ReadLine()) / 100);
            }
            else
            {
                Console.WriteLine("Calculons les interets composes.\n");
                Console.WriteLine("Votre salaire ? => ");
                salaire = float.Parse(Console.ReadLine());
                Console.WriteLine("Votre taux ? => ");
                taux = (100 - float.Parse(Console.ReadLine()) / 100);
                Console.WriteLine("Temps ? => ");
                int annee = int.Parse(Console.ReadLine());
                for (int i = 0; i < annee; i++)
                {
                    Console.WriteLine("Annee " + i+1 + " : salaire => " + salaire);
                    salaire = salaire + salaire * taux;
                }
            }
        }
        catch (FormatException e)
        {
            Console.WriteLine("C'est pas un chiffre. Fin du programme...\n" + e.Message);
            Environment.Exit(-1);
        }
        
        Console.WriteLine("Fin du programme...");
        Console.ReadLine();
    }
    public static void Un()
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

        if (testSalaire == false || testTax == false)
        {
            Console.WriteLine("Tant pis pour toi ^^");
        }
        else
        {
            Console.WriteLine("BG en vdv ^^");
        }

        if (leSalaireUtilisateur >= 50000)
        {
            Console.WriteLine("Fais un don sur ma chaine twitch stp.............................................................");
        }
        else if (leSalaireUtilisateur / 12 <= 1500)
        {
            Console.WriteLine("T'as pas d'argent mskn");
        }
        else if (leSalaireUtilisateur >= 30000 && leSalaireUtilisateur <= 40000)
        {
            Console.WriteLine("Go au CESI hein ^^^^^^^^^^^^^^^^^^^^^^");
        }
    }

    public static void Deux()
    {
        Console.WriteLine("oui");
        ISet<String> mois = new HashSet<String>();

        mois.Add("Janvier");
        mois.Add("Fevrier");
        mois.Add("Mars");
        mois.Add("Avril");
        mois.Add("Mai");
        mois.Add("Juin");
        mois.Add("Juillet");
        mois.Add("Aout");
        mois.Add("Septembre");
        mois.Add("Octobre");
        mois.Add("Novembre");
        mois.Add("Decembre");

        float leSalaireUtilisateur = 75000;
        float laTax = 37;
        float taux = 1 - (laTax / 100);
        float leSalaire = (leSalaireUtilisateur / 12) * taux;
        float bonus = leSalaire + (leSalaireUtilisateur * 10 / 100);
        float rien = 0;

        Console.WriteLine("oui");
        foreach (String s in mois)
        {
            if (s == "Decembre")
            {
                Console.WriteLine(s + " => " + bonus);
            }
            else if (s == "Aout")
            {
                Console.WriteLine(s + " => " + rien);
            }
            else
            {
                Console.WriteLine(s + " => " + leSalaire);
            }
        }
    }

    public static void Trois()
    {
        try
        {
            Console.WriteLine("Pourcentage => ");
            int pourcentage = int.Parse(Console.ReadLine());
            Console.WriteLine("");
        }
        catch (DivideByZeroException e)
        {
            Environment.Exit(-1);
        }
    }

}