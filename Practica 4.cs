// See https://aka.ms/new-console-template for more information
using System.Diagnostics.SymbolStore;

Console.WriteLine("Hello, World!");
//for
/*
for (int i = 0; i <= 10; i++) {
    Console.WriteLine(i);
}

string text = "Este es un texto de ejemplo.";

for (int i = 0; i < text.Length; i++)
{
    Console.WriteLine(text[i]);
}

Console.ReadLine();
//while

int w = 0;
while (true)
{
    w++;
    if (w > 10)
    {
        break;
    }
    else {
        w++;
    }
}


//do while
*/


//hacer un programa que lea un numero, si el numero no es par, se volvera a pedir, de lo contrario mostrara todos los elemenros que hay entre 0 y el//
//nota el numero no debe ser negativio
Boolean ban = true;
do
{
    int n1 = 0;
    Console.WriteLine("Escribe un numero");
    n1 = Convert.ToInt32(Console.ReadLine());

    if (n1 <= 0)
    {
        Console.WriteLine("El numero ingresado es menor a 0");
    }
    else
    {
        if (n1 % 2 == 0)
        {
            for (int i = 0; i <= n1; i++)
            {
                Console.WriteLine(i);
            }
            ban = false;
        }
        else {
            Console.WriteLine("El numero no es par");
        }
    }


} while(ban);
