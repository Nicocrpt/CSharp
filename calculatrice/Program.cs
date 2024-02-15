using System;


System.Console.WriteLine("------ Calculatrice ------");

decimal a, b ;
decimal resultat ;
string operation ;
bool check = true ;
string[] symbols = {"+","-","/","*","%","^"} ;


while (check == true) {

    System.Console.WriteLine();
    System.Console.Write("Veuillez entrer votre opération : ");
    operation = Console.ReadLine();
    System.Console.WriteLine();

    // 11/02/2024 Ajout (apres recherche sur internet..) d'un booléen pour verifier si le contenu de l'opération contient bien un opérateur valide

    // bool verificationSymbol = symbols.Any(a => operation.Contains(a)); 


    // 11/02/2024 Version plus "Maison" apres reflexion....

    bool verificationSymbol = false ;

    foreach (string c in symbols) {
        if (operation.Contains(c) == true) {
            verificationSymbol = true ;
            break ;
        }
    }

    if (verificationSymbol == false ) {
        System.Console.WriteLine("Votre operation n'est pas valide !");
    } else {

        string[] elements = operation.Split('+', '-', '/', '*', '%','^');  
        
        bool c = decimal.TryParse(elements[0].Replace('.', ','), out a ) ;
        bool d = decimal.TryParse(elements[1].Replace('.', ','), out b ) ;


        if (c == false || d == false) {
            System.Console.WriteLine("Votre opération n'est pas valide !!");
        } else {
        
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
                    System.Console.WriteLine("On ne peut pas diviser par 0 !");
                } else {
                    resultat = a/b ; 
                    System.Console.WriteLine($"{a} / {b} = {resultat}");
                }
                
            } else if (operation.Contains("%")) {
                resultat = a%b ;
                System.Console.WriteLine($"{a} % {b} = {resultat}");

            } else if (operation.Contains('^')) {
                double resultatPow = Math.Pow(Convert.ToSingle(a), Convert.ToSingle(b)) ;
                System.Console.WriteLine($"{a} ^ {b} = {resultatPow}");
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
                    System.Console.WriteLine("-------------------------------------");
                }

            } else if (answ == "n") {
                System.Console.WriteLine();
                System.Console.WriteLine("Merci et au revoir !");
                System.Console.WriteLine();
                check = false ;

            } else {
                System.Console.WriteLine();
                System.Console.WriteLine("--------------------------------------");
            }
        }
    }
}



