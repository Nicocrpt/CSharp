using System;
using System.Collections.Generic;

System.Console.WriteLine("-~-~-~-THE MYSTERY NUMBER-~-~-~-");
System.Console.WriteLine();




// CONSTANTES :

const int MIN = 0 ;
const int MAX = 100 ;
const int numberToFind = 45 ;


// VARIABLES

System.Console.Write("Please enter your name : ");
string firstName = Console.ReadLine() ;
System.Console.WriteLine();

// System.Console.Write($"Enter your guess (between {MIN} and {MAX}) : ");
// int numberUser = int.Parse(Console.ReadLine()) ;

List<int> tried = new List<int>() ;

bool found = false ;

while(!found) {

    int numberUser = 0;

    if (tried.Count() != 0) {
        System.Console.Write("Numbers already tried : ");

        foreach (int nb in tried) {
            System.Console.Write($"{nb} ");
        }
        
    }

    System.Console.WriteLine();
    System.Console.WriteLine();
    System.Console.Write($"Enter your guess (between {MIN} and {MAX}) : ");
    numberUser = int.Parse(Console.ReadLine()) ;
    tried.Add(numberUser) ;
    System.Console.WriteLine();


    if (numberUser == numberToFind) {
        System.Console.WriteLine("Congrats, you've guessed right !");
        found = true ;
        System.Console.WriteLine();
    }else if (numberUser < numberUser) {
        System.Console.WriteLine("Try again, the right number is higher !");
        System.Console.WriteLine();
        found = false ;
    }else {
        System.Console.WriteLine("Try again, the right number is lower !");
        System.Console.WriteLine();
        found = false ;
    }
}   