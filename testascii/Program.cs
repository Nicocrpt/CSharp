

const char LIGNE_HORIZONTALE = '\u2550' ;
const char LIGNE_VERTICALE = '\u2551' ;
const char COIN_HAUT_GAUCHE = '\u2554' ;
const char COIN_HAUT_DROIT = '\u2557' ;
const char COIN_BAS_GAUCHE = '\u255A' ;
const char COIN_BAS_DROIT = '\u255D' ;

int surface(int X, int Y) {
    int surface = X*Y;
    return surface; 
}

void rectangle(int X, int Y, string[] text) {



    System.Console.Write(COIN_HAUT_GAUCHE);
    for (int i = 0; i < X; i++) {
    System.Console.Write(LIGNE_HORIZONTALE); 
    }
    System.Console.WriteLine(COIN_HAUT_DROIT);

    for (int i = 0; i < Y; i++) {
        System.Console.Write(LIGNE_VERTICALE);
        for (int e = 0; e < X; e++) {
            System.Console.Write(" ");
        }
        System.Console.Write(text[i]);
        
        System.Console.WriteLine(LIGNE_VERTICALE);

    }

    System.Console.Write(COIN_BAS_GAUCHE);
    for (int i = 0; i < X; i++) {
        System.Console.Write(LIGNE_HORIZONTALE); 
    }
    System.Console.WriteLine(COIN_BAS_DROIT);

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
    System.Console.WriteLine(textLine);
    int textHeight = splitted.Count();
    System.Console.WriteLine(textHeight);
    textLine += 2 ;

    rectangle(textLine, textHeight, splitted);

}


encadrer("bonjour\nJe suis nicolas");