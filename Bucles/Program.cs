// Bucles

// While - MIENTRAS

int i = 1;
Console.WriteLine("WHILE:");
while (i < 10) {
    // codigo que se ejecuta mientras la condición es "true"
    Console.WriteLine(i + " ");
    i++; // i = i+1;
}
Console.WriteLine("\nDespués del while: " + i);
// For
Console.WriteLine("FOR:");
for (int j = 0; j < 10; j++)
{
    Console.WriteLine(j + " ");
}

// DO... WHILE
Console.WriteLine("DO...WHILE");
i = 10;
do {
    Console.WriteLine(i);
} while (i > 10);

// FOR EACH

Console.WriteLine("FOR EACH:");
var lista = new List<string> { "Pepe", "Juan", "Miryam"};

foreach (var elemento in lista)
{
    Console.WriteLine(elemento);
}

// Sumar los 100 primeros números enteros
int num = 0;
int suma = 0;
for (num = 0; num < 100; num++)
{
    suma += num;
}
Console.WriteLine("La suma de los 100 primeros números enteros es: " + suma);

// Expandimos el código para que el usuario pueda introducir un número hasta donde vamos a sumar
int suma2 = 0;
int resultado = 0;
int limite = 0;
Console.WriteLine("Introduce el límite de la suma:");
limite = Convert.ToInt32(Console.ReadLine());
for (suma2=0; suma2 <= 100; suma2++)
{
    resultado += suma2;
}
Console.WriteLine($"Resultado: {resultado}");

// Escribir todos los elementos de un array
int[] arr = new int[3];
arr[0] = 1;
arr[1] = 2;
arr[2] = 3;

// con bucle for
for (i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}

// con bucle for each
foreach (var item in arr)
{
    Console.WriteLine(item + " ");
}