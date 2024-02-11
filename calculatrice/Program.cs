﻿using System;
using System.Linq;

System.Console.WriteLine("------ Calculatrice ------");

decimal a, b ;
decimal resultat ;
string operation ;
bool check = true ;
char[] symbols = {'+','-','/','*','%'} ;


while (check == true) {

    System.Console.WriteLine();
    System.Console.Write("Veuillez entrer votre opération : ");
    operation = Console.ReadLine();
    System.Console.WriteLine();

    // Ajout (apres recherche sur internet..) d'un booléen pour verifier si le contenu de l'opération contient bien un opérateur valide
    bool verificationSymbol = symbols.Any(a => operation.Contains(a)); 

    if (verificationSymbol == false ) {
        System.Console.WriteLine("Votre operation n'est pas valide !");
    } else {

        string[] elements = operation.Split('+', '-', '/', '*', '%');  
        
        bool c = decimal.TryParse(elements[0], out a ) ;
        bool d = decimal.TryParse(elements[1], out b ) ;

        if (c == false || d == false) {
            System.Console.WriteLine("Votre opération n'est pas valide !");
        } else {
        /* a = Convert.ToDecimal(elements[0]);
        b = Convert.ToDecimal(elements[1]); */
        
            if (operation.Contains("+")) {
                resultat = a+b ;
                System.Console.WriteLine($"{a} + {b} = {resultat}");

            } else if (operation.Contains("-")) {
                resultat = a-b ;
                System.Console.WriteLine($"{a} - {b} = {resultat}");

            } else if (operation.Contains("*")) {
                resultat = a*b ;
                System.Console.WriteLine($"{a} * {b} = {resultat}");

            } else if (operation.Contains("/")) {
                if (b == 0) {
                    resultat = 0 ;
                    System.Console.WriteLine("votre opération n'est pas valide !");

                } else {
                    resultat = a/b ; 
                    System.Console.WriteLine($"{a} / {b} = {resultat}");
                }
                
            } else if (operation.Contains("%")) {
                resultat = a%b ;
                System.Console.WriteLine($"{a} % {b} = {resultat}");

            } else {
                System.Console.WriteLine("Votre opérateur n'est pas bon !");
            }
        }

        System.Console.WriteLine();
        Console.Write("Voulez vous Effectuer une nouvelle opération (o/n) ? ") ;

        string answ = Console.ReadLine() ;

        if (answ != "o" && answ != "n" ) {

            while (answ != "o" && answ != "n" ) {
                System.Console.Write("veuillez répondre par oui (o) ou non (n) : ");
                answ = Console.ReadLine();
            }

            if (answ == "n") {
                System.Console.WriteLine();
                System.Console.WriteLine("Merci et au revoir !");
                System.Console.WriteLine();
                check = false ;
            } else {
                System.Console.WriteLine();
                System.Console.WriteLine("----------------------------------------------");
            }

        } else if (answ == "n") {
            System.Console.WriteLine();
            System.Console.WriteLine("Merci et au revoir !");
            System.Console.WriteLine();
            check = false ;

        } else {
            System.Console.WriteLine();
            System.Console.WriteLine("----------------------------------------------");
        }
    }
}



