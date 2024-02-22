// Boucle for :


// Affichage de toutes les tables :

// for (int e = 1; e < 10; e++) {
//     for (int i = 0; i < 11; i++) {
//     System.Console.WriteLine(i*e);
//     }
//     System.Console.WriteLine();
// }




const int MAX = 10 ;
bool retry = true ;

while (retry == true) {

    System.Console.Write("Quelle table souhaitez vous ? ");
    string tableUs = Console.ReadLine() ;

    if (int.TryParse(tableUs, out int number)== true) {

        System.Console.WriteLine();
        for (int i = 0; i <= MAX; i++) {
        int result = i*number ;
        System.Console.WriteLine($"{i} x {tableUs} = {result}");
        System.Console.WriteLine("-----------");
        }
        System.Console.WriteLine();
        System.Console.Write("Recommencer (o/n) ? ");
        string choice = Console.ReadLine() ;
        if (choice != "o") {
            retry = false ;
            System.Console.WriteLine();
            System.Console.WriteLine("Merci au revoir !");
        }else {
            System.Console.WriteLine();
            System.Console.WriteLine("---------------------------------");
            System.Console.WriteLine();
        }

    }else if (decimal.TryParse(tableUs, out decimal numberDec) == true) {

        System.Console.WriteLine();
        System.Console.WriteLine("Veuillez entrer un nombre ENTIER svp");
        System.Console.WriteLine();

    }else {

        System.Console.WriteLine();
        System.Console.WriteLine("Veuillez entrer un nombre svp");
        System.Console.WriteLine();
    }
}








