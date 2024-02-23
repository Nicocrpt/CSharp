// Fonction Addition
using System.Diagnostics;

int addition(int a, int b) {
    return a + b ;
}
System.Console.WriteLine($"\naddition : {addition(-12, 3)}\n") ;

double addition2(double a, double b) {
    return a+b ;
}
System.Console.WriteLine($"addition2 : {addition2(1, 1.5)}\n");

// Fonction Surface triangle

double getSurface(double b, double h) {
    return (b*h)/2 ;
}

System.Console.WriteLine($"getSurface : {getSurface(3,5)} m2\n");


// Fonction Reste de division

int resteDiv(int a, int b) {
    return a%b ;
}

System.Console.WriteLine($"resteDiv : {resteDiv(20,3)}\n");


// Fonction Incrementation 

int increment(int a) {
    return a+1 ;
}
System.Console.WriteLine($"increment : {increment(7)}\n");