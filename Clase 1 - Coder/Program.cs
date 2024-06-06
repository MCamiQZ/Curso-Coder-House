// See https://aka.ms/new-console-template for more information

Console.WriteLine("Bienvenido");
string nombre;
nombre = "Juan";

Console.WriteLine("Mi nombre es: " + nombre);

string apellido;
apellido = "quiroz";

Console.WriteLine("Mi nombre es: " + apellido);

Console.WriteLine("ingrese su dni");
int dni;
dni = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("su numero de DNI ES: " + dni);

int num1;
int num2;

Console.WriteLine("ingrese el primer numero.");

num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero.");
num2 = Convert.ToInt32(Console.ReadLine());

int total = num1 + num2;

Console.WriteLine("La suma de estos dos numeros es: " + total);

Console.ReadKey(); 