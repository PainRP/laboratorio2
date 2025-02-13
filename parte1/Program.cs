int numeroEntero;
double numeroDecimal;
string texto;
bool valorBooleano;

Console.Write("Ingrese un número entero: ");
numeroEntero = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese un número decimal: ");
numeroDecimal = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese un texto: ");
texto = Console.ReadLine();

Console.Write("Ingrese un valor verdadero o falso (true/false): ");
valorBooleano = Convert.ToBoolean(Console.ReadLine());
        
Console.WriteLine("Número entero: " + numeroEntero);
Console.WriteLine("Número decimal: " + numeroDecimal);
Console.WriteLine("Texto: " + texto);
Console.WriteLine("Valor verdadero o falso: " + valorBooleano);
    