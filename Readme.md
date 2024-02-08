Dépot pour exercice C#

creer un nouveau projet console : "dotnet new console -n nomDuProjet"


-INT-

Entier signés :

int (vrai nom : System.Int32) -> 32bit (4 bytes) : valeurs limités de -2,147,483,648 à 2,147,483,647
long (vrai nom : System.Int64) -> 64bits (8 bytes) : va à des valeurs bien plus élevés


Entier non signés (1er bit non utilisé pour signer le int, donc forcément positif) :

uint (System.UInt32)
ulong (System.UInt64)


-REELS-

float (System.Single) -> 32 bits (4 bytes) 
double (System.Double) -> 64 bits (8 bytes) 

decimal (System.Decimal) -> 128 bits (16 bytes) <- Peut aller moins loin en taille que les autres, mais possède plus de chiffres apres la virgule, il est plus précis.


Lorsque on rentre une valeur décimale dans une variable autre que de type "double", il faut ajouter un suffixe, comme "m" à la suite de notre nombre (ex : 0.2m ), pour renseigner une variable "decimale" par exemple.


-TEXTE-

string -> "Hello" <- Chaine de caractère (guillemets double obligatoires)
char -> 'A' <- Caractère unique (guillemets simples obligatoires)

