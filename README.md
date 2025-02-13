# Laboratorio 2
**¿Para qué crees que se usan los operadores lógicos en programación?**

Los operadores lógicos en programación se utilizan para realizar comprobaciones y tomar decisiones en el código. 
Me parecen que son útiles en estructuras condicionales, búsquedas de datos y funciones que requieren evaluar múltiples condiciones.

**¿Por qué es importante declarar correctamente el tipo de dato de una variable?**

Es importante declarar correctamente el tipo de dato de una variable para evitar errores en la ejecución del programa. 
Por ejemplo, si se necesita se va a utilizar un número muy grande y se usa un int16, este podría no ser suficiente, causando un desbordamiento.

## Enunciados 

### Enunciado 1: Clasificación de edad
**Código**
```csharp
int edad;

 Console.WriteLine("Introduce tu edad");
 
 while (!int.TryParse(Console.ReadLine(), out edad))

{
    Console.WriteLine("Introduce un número válido:")
}

if (edad < 12){
    Console.WriteLine("Niño");
} else if (edad >= 12 && edad <= 17){
    Console.WriteLine("Adolescente");
} else if (edad >= 18 && edad <= 59){
    Console.WriteLine("Adulto");
} else if (edad > 60){
    Console.WriteLine("Adulto mayor");
} else {
    Console.WriteLine("Edad no valida");
}
```
**¿Qué estructura usarías? ¿if-else o switch? ¿Por qué?**

Utilizo la estructura if-else debido a que me permite hacer comparacioens logicas entre diferentes rangos 
lo que me permite determinar en que rango de edad se encuentra la persona y asi poder mostrar un mensaje

### Enunciado 2: Día de la semana
**código**
```csharp
int dia;

Console.WriteLine("Coloque un numero indicando el dia de la semana (1 = Lunes)");
while (!int.TryParse(Console.ReadLine(), out dia))
{
    Console.WriteLine("Introduce un numero");
}

switch (dia)
{
    case 1:
        Console.WriteLine("Lunes");
        break;
    case 2:
        Console.WriteLine("Martes");
        break;
    case 3:
        Console.WriteLine("Miercoles");
        break;
    case 4:
        Console.WriteLine("Jueves");
        break;
    case 5:
        Console.WriteLine("Viernes");
        break;
    case 6:
        Console.WriteLine("Sabado");
        break;
    case 7:
        Console.WriteLine("Domingo");
        break;
    default:
        Console.WriteLine("Dia no valido");
        break;
}
```
**¿Qué estructura usarías? ¿if-else o switch? ¿Por qué?**

Utilizo switch debido a que estoy comparando una entrada con diferentes valores posibles  y dependiendo del valor de la entrada se muestra el día

### Enunciado 3: Verificación de acceso
**código**
```csharp
string userAdmin = "Admin";
string passwordAdmin = "Password";

string user,password;

Console.WriteLine("Ingrese el usuario: ");
user = Console.ReadLine();

Console.WriteLine("Ingrese la contraseña: ");
password = Console.ReadLine();

if (user == userAdmin && password == passwordAdmin)
{
    Console.WriteLine("Acceso concedido");
}
else if (user == userAdmin && password != passwordAdmin)
{
    Console.WriteLine("Contraseña incorrecta");
}
else
{
    Console.WriteLine("Usuario no registrado");
}
```
Utilizo un if-else debido a que me permite realizar operciones logicas en este caso el comparar las variables de usuario y contraseña y ver si son correctas.


