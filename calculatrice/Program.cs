System.Console.WriteLine("------ Calculatrice ------");

decimal a, b ;
decimal result ;
string operation ;
bool check = true ;


/* a = Convert.ToDecimal(Console.Readkey());
operation = Console.Readkey();
a = Convert.ToDecimal(Console.Readkey());
*/

while (check == true) {

    System.Console.Write("Veuillez entrer votre opération : ");
    operation = Console.ReadLine();
    

    string[] elements = operation.Split('+', '-', '/', '*', '%');


    a = Convert.ToDecimal(elements[0]);
    b = Convert.ToDecimal(elements[1]);

    if (operation.Contains("+")) {
        result = a+b ;
        System.Console.WriteLine($"{a} + {b} = {result}");
    } else if (operation.Contains("-")) {
        result = a-b ;
        System.Console.WriteLine($"{a} - {b} = {result}");
    } else if (operation.Contains("*")) {
        result = a*b ;
        System.Console.WriteLine($"{a} * {b} = {result}");
    } else if (operation.Contains("/")) {
        result = a/b ;
        System.Console.WriteLine($"{a} / {b} = {result}");
    } else if (operation.Contains("%")) {
        result = a%b ;
        System.Console.WriteLine($"{a} % {b} = {result}");
    } else {
        System.Console.WriteLine("Votre opérateur n'est pas bon !");
    }

    Console.Write("Voulez vous Effectuer une nouvelle opération (o/n) ? ") ;

    string answ = Console.ReadLine() ;
    System.Console.WriteLine(answ);

    if (answ != "o" && answ != "n" ) {
        while (answ != "o" && answ != "n" ) {
            System.Console.Write("veuillez répondre par oui (o) ou non (n) : ");
            answ = Console.ReadLine();
        }
        if (answ == "n") {
            check = false ;
        } else {
            check = true ;
        }
    } else if (answ == "n") {
        check = false ;
    }
}


