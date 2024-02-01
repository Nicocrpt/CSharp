// <- Commentaire sur une ligne

/* 
 <- commentaire sur plusieurs lignes
*/


// Console est un OBJET du framework .NET
// WriteLine est une METHODE de l'objet Console qui permet d'afficher du texte dans la Console

Console.WriteLine("Programme de test sur les variables");


// déclaration de Variable de type entier :
int age;

// Affectation de Valeur à la variable age :
age = 40;

// tout d'un coup :
int taille = 180;

Console.WriteLine(age);
Console.WriteLine(taille);


// Variable de type Chaine de caractère :
string prénom = "Bertrand";
Console.WriteLine(prénom);

string nom = "dupont";
Console.WriteLine(nom);


// Concaténation :

Console.WriteLine("Bonjour " + prénom + " " + nom);

// version avec placeholders et signe dollar (interpolation de chaines de caractère) :

Console.WriteLine($"bonjour {prénom} {nom}, vous avez {age} ans et mesurez {taille} cm");


// Variables Booléennes :

bool estMariee = true ;

Console.WriteLine(estMariee) ; // affiche true

// variables numéraire de type decimal :
decimal salaire = 1500.50M ; // Le suffixe M indique que la valeur est de type "??"

Console.WriteLine(salaire) ;


// lecture de données saisis au clavier avec la methode ReadLine :
string chaine = Console.ReadLine(); // Erreur de compilation car la methode readline retourne une chaine de caractères

Console.WriteLine($"Vous avez saisi : {chaine}");

// console.write() rends une chaine de caractère sans passer a la ligne pour après..  permet de poser une question avant un input, sans passer à la ligne

