/*
 * Ejercicio 1
   Escribe un programa que reciba tu nombre y lo escriba por consola.
*/

//Nombre?
Console.WriteLine("Introduce tu nombre: ");
string nombre = Console.ReadLine();

//Imprimir en pantalla
Console.WriteLine("Hola " + nombre);

/*
 * Ejercicio 2
   Escribe un programa que tome la hora y la escriba por pantalla.
*/

// Hora actual
string dateTime = DateTime.Now.ToString("HH:MM:ss");
Console.WriteLine("Hora local: " + dateTime);
