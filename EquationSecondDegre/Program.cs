
// Variables :

using System.Globalization; // je ne sais pas pourquoi il m'a rentré cette ligne, je ne l'ai jamais voulu..

float a, b, c, x, f, D ;

Console.Write("Entrez A : ") ;
a = Convert.ToSingle(Console.ReadLine()) ;

Console.Write("Entrez B : ") ;
b = Convert.ToSingle(Console.ReadLine()) ;

Console.Write("Entrez C : ") ;
c = Convert.ToSingle(Console.ReadLine()) ;

// UTILISER PLUTOT LA CONVERSION "to decimal" et une variable decimal pour eviter les problemes d'arrondis

x = 0 ;

f = 0 ;

// CODE :

if (a == 0) {
    if (b != 0) {
        x = (-c)/b;
        Console.Write($"La solution est {x}");
    }
    else {
        Console.Write("Il n'y a pas de solution");
    };
}
else {
    D = (b * b) - (4*a*c);

    if (D<0) {
        Console.Write("Il n'y a pas de solution");
    }
    else if (D==0) {
        x = (-b)/(2*a);
        Console.Write($"La solution est {x}");
    }
    else {
        D = Convert.ToSingle(Math.Sqrt(D));
        x = ((-b) - D)/(2*a);
        f = ((-b) + D)/(2*a);
        Console.Write($"Il existe 2 solutions : x = {x} et x = {f}");
    }
};

