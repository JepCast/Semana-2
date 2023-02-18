
string nombre;
int edad, m1, m2;
long l1, l2;

Console.Write("Hola, por favor ingrese su nombre: ");
    nombre = Console.ReadLine();
Console.Write("Ingrese su edad: ");
    edad = Convert.ToSByte(Console.ReadLine());
Console.WriteLine("Hola " + nombre + " aparentemente tienes " + edad + " años de edad wow! No aparentas tantos años!");
    Console.ReadLine();

Console.WriteLine("A continuación se te solicitarán dos números enteros de dos cifras");
        Console.ReadLine();
    Console.WriteLine("Inserte el primer numero entero de dos cifras: ");
        m1 = Convert.ToUInt16((string)Console.ReadLine());
    Console.WriteLine("Inserte el segundo numero entero de dos cifras: ");
        m2 = Convert.ToUInt16((string)Console.ReadLine());
Console.Write("Bien hecho " + nombre + ", el resultado de la multiplicación de ambos numeros es: " + m1 * m2 + ".");

    Console.ReadLine();
    Console.WriteLine();

Console.WriteLine("Ahora por ultimo por favor " + nombre + " inserta dos números enteros largos: ");
    Console.WriteLine("Inserte el primer numero entero largo: ");
        l1 = Convert.ToInt64((string)Console.ReadLine());
    Console.WriteLine("Inserte el segundo numero entero largo: ");
        l2 = Convert.ToInt64((string)Console.ReadLine());
Console.WriteLine("Excelente " + nombre + ", los resultados son: ");
        Console.WriteLine($"Suma:  {l1 + l2}");
        Console.WriteLine($"Resta: {l1 - l2}");
        Console.WriteLine($"Multiplicación: {l1 * l2}");

Console.ReadLine();