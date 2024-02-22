

using System.Globalization;

const char LIGNE_HORIZONTALE = '\u2550' ;
const char LIGNE_VERTICALE = '\u2551' ;
const char COIN_HAUT_GAUCHE = '\u2554' ;
const char COIN_HAUT_DROIT = '\u2557' ;
const char COIN_BAS_GAUCHE = '\u255A' ;
const char COIN_BAS_DROIT = '\u255D' ;



void rectangle(int X, int Y, string[] text) {

    System.Console.WriteLine(COIN_HAUT_GAUCHE.ToString() + new string(LIGNE_HORIZONTALE, X) + COIN_HAUT_DROIT.ToString());
    
    for (int i = 0; i < Y; i++) {
        
        System.Console.Write(LIGNE_VERTICALE.ToString() + new string(' ',( (X-(text[i].Length))/2 )) + $"{text[i]}" ) ;

        if ((X-(text[i].Length))%2 == 0) {
            System.Console.WriteLine(new string(' ',(X-(text[i].Length))/2) + LIGNE_VERTICALE.ToString()) ;
        } else {
            System.Console.WriteLine(new string(' ',( (X-(text[i].Length))/2 )+1) + LIGNE_VERTICALE.ToString()) ;
        }


    }

    System.Console.WriteLine(COIN_BAS_GAUCHE.ToString() + new string(LIGNE_HORIZONTALE, X) + COIN_BAS_DROIT.ToString());
}


void encadrer(string texte) {
    string[] splitted = texte.Split('\n');
    List<int> lineLenght = new List<int>();
    foreach (string s in splitted) {
        int longueur = s.Length;
        lineLenght.Add(longueur);
        longueur = 0;
    }
    lineLenght.Sort();
    int textLine = lineLenght.Last() ;
    
    int textHeight = splitted.Count();
    
    textLine += 2 ;

    rectangle(textLine, textHeight, splitted);

}


encadrer("hello !\nHow are you ?");





/* void encadr(string text) {

    // Calcul nombre de Lignes
    String[] lignes = text.Split('\n');
    int nb_lignes = lignes.Length ;
    System.Console.WriteLine($"{nb_lignes} lignes");

    // Calcul nombre de lignes 
    int nb_colonnes = 1;
    foreach (string l in lignes)  {
        if (l.Length > nb_colonnes) nb_colonnes =l.Length ;
    }
    System.Console.WriteLine($"{nb_colonnes} colonnes");

} */

