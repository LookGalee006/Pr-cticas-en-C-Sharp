Console.WriteLine("Hello, World!");

//break, continue, goto

int n1,n2,n3;
int par = 0, impar = 0;

Console.WriteLine("Escribe el numero 1");
n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Escribe el numero 2");
n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Escribe el numero 3");
n3 = Convert.ToInt32(Console.ReadLine());

//Muestra del promedio //____________________________________I

if ((n1 == n2) && (n2 == n3)) {
    Console.WriteLine("El promedio es: {0}", n1);
}

//Muestra de los numeros pares_______________________________I

if (n1 % 2 == 0)
{
    par = par + n1;
}
else { 
    impar = impar + n1;
}


if (n2 % 2 == 0)
{
    par = par + n2;
}
else
{
    impar = impar + n2;
}


if (n3 % 2 == 0)
{
    par = par + n3;
}
else
{
    impar = impar + n3;
}

//Cual es el numero mas Grande_______________________________I

if ((n1 > n2) && (n1 > n3)){
    Console.WriteLine("El numero mayor es: {0}", n1);
}

if ((n2 > n1) && (n2 > n3))
{
    Console.WriteLine("El numero mayor es: {0}", n2);
}

if ((n3 > n2) && (n3 > n2))
{
    Console.WriteLine("El numero mayor es: {0}", n3);
}

Console.WriteLine("La suma de los numero pares es: {0}", par);
Console.WriteLine("La suma de los numero impares es: {0}", impar);


//hacer un programa que lea tres numeros, si los numeros son iguales se calculara el promedio, de lo contrario
//se sumaran los numeros que son pares o impares entre ellos y por ultimo mostrara el mayor y menor de ellos//

