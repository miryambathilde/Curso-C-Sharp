// Ejercicio 1 - Variables

// - Escribe un programa que reciba datos de una persona y genera un mensaje, usa una variable para cada dato y otra para el mensaje.
//      Ej: nombre, apellido, edad, sabe programar, etc.


Console.WriteLine("Escribe tu nombre: ");
string? nombre = Console.ReadLine();

Console.WriteLine("Escribe tu apellido: ");
string? apellido = Console.ReadLine();

Console.WriteLine("Escribe tu edad: ");
int? edad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Sabes programar? (si - no) ");
string? programar = Console.ReadLine();

Console.WriteLine("Te llamas " + nombre + " " + apellido + " y tienes " + edad + " años, y " + programar + " sabes programar.");

//Ejercicio 2 - Tipos
//
// Usando los tipos de variables más adecuados, describe los objetos siguientes:
//  - Coche: puertas, ruedas, marca, ITV vigente
//  - Mesa: peso, largo, material, color

// Nota: puedes escribir estos datos por consola si prefieres verlos. La idea del ejercicio es almacenar los datos en los tipos más adecuados.

// coche:

int doors = 5;
int wheels = 4;
string branding = "Peugeot";
bool itv = true;

string itvpassed = "caducada";

if (itv)
{
    itvpassed = "pasada";
}

Console.WriteLine("El coche tiene " + doors + " puertas y " + wheels + " ruedas, es de la marca " + branding + ", y tiene la itv " + itvpassed);

// mesa

double weight = 10;
double large = 23.5;
string material = "madera";
string color = "marrón";

Console.WriteLine("La mesa pesa " + weight + "kg, mide " + large + "cm, y está hecha de " + material + " de color " + color);

// Ejercicio 3

// Operadores Determina los operadores para verificar las siguientes condiciones:
//  - Un número es mayor o igual a 18
//  - Un char es ‘a’
//  - Se cumplen dos conciones a la vez (ambas verdaderas)
//  - Se cumple una de dos condiciones a la vez (una true y otra false)

// Nota: puedes escribir estos datos por consola si prefieres verlos. La idea del ejercicio es almacenar los datos en los tipos más adecuados.

int num = 20;
bool greatherThan = (num >= 18);


char m = 'm';
Type char1 = m.GetType();
Type char2 = typeof(char);
bool miryam = (char2 == char1);


int num1 = 30;
int num2 = 40;
bool doubleTrueCondition = (num1 >= 18 && num2 >= 25);


bool condition = (num1 >= 15 || num2 >= 65);


Console.WriteLine("Es mayor o igual a 18? " + greatherThan);
Console.WriteLine("Es un char? " + miryam);
Console.WriteLine("Se cumplen dos condiciones a la vez (las dos true)? " + doubleTrueCondition);
Console.WriteLine("Se cumple una de las dos condiciones (una true y una false)? " + condition);