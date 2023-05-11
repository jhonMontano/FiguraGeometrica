// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Figura;

Cuadrado cuadrado = new Cuadrado();

cuadrado.alto = 10;
cuadrado.ancho = 10;

Triangulo triangulo = new Triangulo();

triangulo.alto = 10;
triangulo.ancho = 10;

Console.WriteLine("El ares del cuadrado es: "+cuadrado.area());
Console.WriteLine("El area del triangulo es: "+triangulo.area());
