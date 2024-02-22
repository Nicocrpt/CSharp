


System.Console.WriteLine("\n-| Tables de multiplications |-\n");

const int MAX = 10 ;
bool retry = true ;

while (retry == true) {

    System.Console.Write("Quelle table souhaitez vous ? ");
    string tableUs = Console.ReadLine().Replace(".", ",") ;

    if (int.TryParse(tableUs, out int number)) {

        System.Console.WriteLine();
        
        for (int i = 0; i <= MAX; i++) {
            System.Console.WriteLine($"{i} x {tableUs} = {i*number}");
            System.Console.WriteLine("-----------");
        }
        System.Console.Write("\nRecommencer (o/n) ? ");
        string choice = Console.ReadLine() ;
        if (choice != "o") {
            retry = false ;
            System.Console.WriteLine("\nMerci au revoir !");
        }else {
            System.Console.WriteLine("\n---------------------------------\n");
        }

    }else if (decimal.TryParse(tableUs, out decimal numberDec)) {
        System.Console.WriteLine("\nVeuillez entrer un nombre ENTIER svp\n");
    }else {
        System.Console.WriteLine("\nVeuillez entrer un nombre svp\n");
    }
}








