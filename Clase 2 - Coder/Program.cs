int pass = 123456789;
int passIngresado;
String perfilingresado;

Console.WriteLine("ingrese su perfil");
perfilingresado = Console.ReadLine();
Console.WriteLine("Ingrese su contraseña");
passIngresado = Convert.ToInt32(Console.ReadLine());

if (pass == passIngresado)
{
    switch (perfilingresado)
    {
        case "A":
            Console.WriteLine("Bienvenido Administrador");
            break;
        case "U":
             Console.WriteLine("Bienvenido usuario");
            break;
       
    }
}
else
{
    Console.WriteLine("Debe reiniciar el sistema");
}