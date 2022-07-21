/*Ejercicio 1

Crea una estructura de datos para un cliente con estos campos:

Nombre completo

Teléfono

Dirección

Email

Si es nuevo cliente

Bonus: escribe un método para presentar estos datos desde la estructura al hacer Console.WriteLine(...)

*/

Datos myCliente = new Datos("Miryam", 667256744, "Calle de la alegría 28, 1º 5ª", "cliente@gmail.com", true);

Console.WriteLine(myCliente);

public struct Datos
{
    public Datos(string name, long phone, string address, string email, bool newClient)
    {
        Name = name;
        Phone = phone;
        Address = address;
        Email = email;
        NewClient = newClient;
    }

    public string Name { get; set; }
    public long Phone { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public bool NewClient { get; set; }

    public override string ToString() => $"Nombre: {Name}. Telefono: {Phone}. Direccion: {Address}. Email: {Email}. Nuevo cliente: {NewClient}.";
}