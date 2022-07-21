/*
 * Ejercicio 1 - While

Escribe una tabla de multiplicar del 1 al 10 para un número entero que recibe por consola. Es decir, un programa que presente para el 1:

1 x 1 = 1
1 x 2 = 2
...
1 x 10 = 10
*/

int num1 = 1;
int num2 = 1;
while (num1 < 11)
{
    while (num2 < 11)
    {
        int resultado = num1 * num2;
        Console.WriteLine($"{num1} x {num2} = {resultado}");
        num2++;
    }
    num2 = 1;
    num1++;
    Console.WriteLine(" ");
}

/*
 * Ejercicio 2 - Do while

Escribe un programa que realice estos pasos:
 - Reciba al menos un número por consola
- Determine si el número es positivo o negativo
- Presente un contador para cada tipo (positivo y negativo).

Nota: el cero se puede abordar en una clase adicional ya que no es ni positivo ni negativo. Tienes completa libertad para elegir el formato de la salida.
*/

Console.WriteLine("Escribe un numero: ");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero < 0)
{
    Console.WriteLine($"{numero} es negativo");
    do
    {
        Console.WriteLine($" {numero} ");
        numero++;
    } while (numero != 0);
}
else if (numero > 0)
{
    Console.WriteLine($"{numero} es postivo");
    do
    {
        Console.Write($" {numero} ");
        numero--;
    } while (numero != 0);
}
else if (numero == 0)
{
    Console.WriteLine("El numero ya es 0");
}

/*
 * Escribe un programa que realice estos pasos:

Reciba 3 datos:

ancho

alto

relleno o no

Dibuje en consola con un mismo caracter, por ejemplo *, un rectángulo de las dimensiones introducidas y use el tercer dato para discernir si el rectángulo está relleno (tiene más * dentro) o no.

En caso de recibir el mismo número n dos veces debe dibujar un cuadrado de lado n.

Reto: Extiende el programa anterior para recibir otro número que sea el número de cuadrados o rectángulos que se deben dibujar en la pantalla. Ejemplos:

Input: 2,2,2, relleno = true

Output:

** **

** **

Input: 3, 4, 1, relleno = false

Output:

***

* *

* *

***
*/

Console.WriteLine("\nEscribe un numero para definir el ancho: ");
int ancho = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Escribe un numero para definir el alto: ");
int alto = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Escribe un numero para definir cuantas copias quieres: ");
int numeroCopias = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Escribe true o false, para definir si quieres que tenga relleno: ");
bool relleno = Convert.ToBoolean(Console.ReadLine());

int altura = alto;
while (altura > 0)
{
    int copias = numeroCopias;
    while (copias >= 1)
    {
        int anchura = ancho;
        while (anchura > 0)
        {
            if (relleno)
            {
                Console.Write("*");
                anchura--;
            }
            else
            {
                if ((altura == alto || anchura == ancho) || (altura == 1 || anchura == 1))
                {
                    Console.Write("*");
                    anchura--;
                }
                else if (altura != alto && altura != 1)
                {
                    Console.Write(" ");
                    anchura--;
                }
            }
        }
        anchura = ancho;
        if (copias > 1)
        {
            Console.Write("  ");
        }
        copias--;
    }
    Console.Write("\n");
    altura--;
}