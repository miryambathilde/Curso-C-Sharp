/*
Ejercicio 2 - Switch

Haz una lista de lenguajes de programación, por ejemplo: C#, Java, C++. Presenta la lista en consola y pide que el usuario seleccione el lenguaje mediante 1, 2, 3 o a, b, c. Presenta el resultado en consola.

Nota: puedes añadir al resultado el “Hola, mundo” para el caso de C#.
*/

Console.WriteLine("Pulsa el número correspodiente al lenguaje quieres seleccionar:");

string[] languages = new string[3];
languages[0] = "1: Javascript";
languages[1] = "2: Java";
languages[2] = "3: C#";

foreach (var language in languages)
{
    Console.Write(language + " \n");
}
char yourChoose = Convert.ToChar(Console.ReadLine());

switch (yourChoose)
{
    case '1':
        Console.WriteLine("Has seleccionado: Javascript");
        break;
    case '2':
        Console.WriteLine("Has seleccionado: Java");
        break;
    case '3':
        Console.WriteLine("Has seleccionado: Hello World C#!");
        break;
    default:
        Console.WriteLine("No has seleccionado ninguno. Por favor, selecciona uno.");
        break;
}


// Ejercicio 1 - If

// Escribe un programa que:
//  - Pida datos a un cliente: Nombre, email, cupón
//  - Determine si un cliente tiene un cupon descuento
//  - Muestre un precio rebajado en función del descuento
//  - Muestre el precio de un producto sin descuento si no hay cupón

//Nota: puedes poner un precio fijo de un producto o uno variable.

int price = 300;
int discount = 50;
Cliente cliente = new Cliente();

if (cliente.HasCupon)
{
    Console.WriteLine($"El precio a pagar con el descuento aplicado es de: {price - discount}€");
}
else
{
    Console.WriteLine($"El precio total a pagar es: {price}€");
}
public struct Cliente
{

    public string? Name { get; set; }
    public string? Email { get; set; }
    public bool HasCupon { get; set; }
    public Cliente()
    {

        Console.WriteLine("Introduce tu nombre:");
        Name = Console.ReadLine();

        Console.WriteLine("Introduce tu Email:");
        Email = Console.ReadLine();

        Console.WriteLine("Dispones de cupón de descuento? s / n");
        HasCupon = Console.ReadLine() == "s" ? true : false;
    }

    public override string ToString() => $"(Nombre: {Name} \n Email: {Email}\n)";

}