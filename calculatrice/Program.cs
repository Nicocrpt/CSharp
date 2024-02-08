System.Console.WriteLine("------ Calculatrice ------");

decimal a, b ;
decimal result ;
string operation ;

System.Console.Write("Veuillez entrer votre opération : ");

/* a = Convert.ToDecimal(Console.Readkey());
operation = Console.Readkey();
a = Convert.ToDecimal(Console.Readkey());
*/

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


