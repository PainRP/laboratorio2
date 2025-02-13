int num1, num2;

Console.WriteLine("Escriba el primer numero: ");
num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Escriba el segundo numero: ");
num2 = int.Parse(Console.ReadLine());

Console.WriteLine(num1+ " es mayor que " + num2 + " : " + (num1 > num2));
Console.WriteLine(num1+ " es menor que " + num2 + " : " + (num1 < num2));
Console.WriteLine(num1+ " es igual que " + num2 + " : " + (num1 == num2));
Console.WriteLine(num1+ " y " + num2 + " son mayores a 10: " + (num1 > 10 && num2 > 10));
Console.WriteLine(num1+ " o " + num2 + " es mayor a 10: " + (num1 > 10 || num2 > 10));