//Crear una función que calcule el área de un círculo, recibiendo como parámetro el radio.

static double Area(double radio)
{
    double area = Math.PI * Math.Pow(radio, 2);
    return area;
}

/*Marh.PI, valor de pi
 Math.Pow, devuelve el valor especifico elevado a un potencia en este caso de valor 2*/

double radio = 45.2789;
double area = Area(radio);
Console.WriteLine($"El área del círculo  es {area}");

/*Crear una función que calcule
 * el perímetro de un rectángulo, 
 * recibiendo como parámetros el
 * ancho y la altura..*/

static double Perimetro(double ancho, double altura)
{
    double perimetro= 2 * (ancho + altura);
    return perimetro;
}
double ancho = 10.12423;
double altura =5.47789;
double perimetro=Perimetro(ancho, altura);
Console.WriteLine($"El perimetro del rectangulo es: {perimetro}");

/*Crear una función que calcule el
promedio de una lista de números,
recibiendo como parámetro una lista
de enteros*/

static double Promedio(List<int> n)
{
    int suma = 0;
    foreach(int elemetos in n )//foreach recorre la lista de elementos 
    {
        suma += elemetos;
    }
    Double promedio = suma/n.Count; // Count se usa para devolver el conjunto de numeros de la lista 
    return promedio;
}

List<int> numeros = new List<int>() { 5, 15, 13, 10, 12 };
double promedio = Promedio(numeros);
Console.WriteLine("El promedio de la lista de números es: ", promedio);

/*Crear una función que determine si un
número es par o impar, recibiendo 
como parámetro el número.*/

static string Par_impar(int num)
{
    if (num % 2 == 0)
    {
        return "El número es par.";
    }
    else
    {
        return "El número es impar.";
    }
}
int num;
Console.WriteLine("ingrese un numero entero");
num=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Par_impar(num));

/*Crear una función que convierta una 
cadena a mayúsculas,
recibiendo como parámetro la cadena.*/

static string Mayusculas(string cadena)
{
    return cadena.ToUpper();
}
string minus = "soy gimena";
string MAYUS = Mayusculas(minus);
Console.WriteLine( MAYUS );

/*Crear una función que calcule 
 * la distancia entre dos puntos 
 * en un plano cartesiano, recibiendo 
 * como parámetros las coordenadas x e
 * y de ambos puntos.*/

static double Distancia(double x1, double x2, double y1, double y2)
{//Math.Sqrt calcula la raiz cuadrada 
    double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    return distancia;
}
double  x1=4.6756, x2=8.47879, y1=1.05123, y2=10.2374;
Console.WriteLine("la ditancia entre los dos puntos es de: " + Distancia(x1, x2, y1, y2));

/*Crear una función que calcule la suma
 * de los primeros n números naturales,
 * recibiendo como parámetro el número n.*/ 

static int Suma_naturales(int n)
{
    int suma = (n*(n + 1)) / 2;
    return suma;
}
int n = 5;
Console.WriteLine("la suma de los primeros numeros naturales es: \n " + Suma_naturales(n));

/*Crear una función que calcule el 
 * factorial de un número,
 * recibiendo como parámetro el número.*/

static int Factorial(int x)
{
    int factorial = 1;
    for (int i = 1; i <= x; i++)
    { 
    factorial *= i; 
    }
    return factorial;
}
int x = 20;
Console.WriteLine("el factorial de " + x + "es:" + Factorial(x));