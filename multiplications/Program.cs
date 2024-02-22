// Boucle for :


// Affichage de toutes les tables :

// for (int e = 1; e < 10; e++) {
//     for (int i = 0; i < 11; i++) {
//     System.Console.WriteLine(i*e);
//     }
//     System.Console.WriteLine();
// }




System.Console.Write("Quelle table souhaitez vous ? ");
int tableUser = int.Parse(Console.ReadLine()) ;
const int MAX = 10 ;

System.Console.WriteLine();

for (int i = 0; i <= MAX; i++) {
    System.Console.WriteLine(i*tableUser);
}




