/* 
 1. Validar si es usuario existente o si se debe registrar y generar un sistema de registro o login
 2. El programa debe ser capaz de darle la bienvenida a un usuario existente si en efecto existe
 3. El programa debe repetirse hasta que se registren las 10 personas
 
 */

string[] nombresUsuarios = new string[10] { "", "", "", "", "", "", "", "", "", "" };
int arrayCurrentIndex = 0;
int userType;
string userToSeach;

Console.WriteLine("Bienvenido a uno de los mejores restaurantes del mundo");

while (arrayCurrentIndex==10)
{
    Console.WriteLine("***Seleccione una opcion***");
    Console.WriteLine("1. Tengo un usuario");
    Console.WriteLine("2. Deseo registrarme");
    Console.WriteLine("3. Cancelar");

    userType = Convert.ToInt32(Console.ReadLine());

    if (userType==1)
    {
        Console.WriteLine("Ingresa nombre de usuario");
        userToSeach = Console.ReadLine();
        Console.WriteLine("El usuario es {0}", userToSeach);
        int index = Array.IndexOf(nombresUsuarios, userToSeach);
        if (index==-1)
        {
            Console.WriteLine("Usuario no ingresado, reintentalo o registrate");
        }
        else
        {
            Console.WriteLine("Bienvenido {0}, que disfrutes el menu", nombresUsuarios[index]);
        }
    }
    else if (userType==2){
        Console.WriteLine("Por favor, escribe tu nombre de usuario");
        nombresUsuarios[arrayCurrentIndex]= Console.ReadLine();
        Console.WriteLine("Tu usuario fue creado con exito\n" +
            "tu nombre de usuario es> {0}", nombresUsuarios[arrayCurrentIndex]);
        arrayCurrentIndex++;
    }
    else
    {
        Environment.Exit(0);
    }
    Console.WriteLine("El restaurante esta lleno, vuelve el proximo evento \n Esta es la lista de invitados" );
    int auxIndex = 0;
    foreach (string element in nombresUsuarios)
    {
        Console.WriteLine("Numero de usuario: {0}", auxIndex+1, nombresUsuarios[auxIndex]);
        auxIndex++;
    }
}