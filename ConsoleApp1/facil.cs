using System;

namespace EjerciciosFaciles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Llama aquí el ejercicio que quieras probar, por ejemplo:
            CalcularVelocidad();
            // MostrarMultiplosDe2();
            // PositivoONegativo();
        }

        // 1. Calcular velocidad = distancia/tiempo
        static void CalcularVelocidad()
        {
            Console.Write("Ingrese distancia: ");
            double distancia = double.Parse(Console.ReadLine());
            Console.Write("Ingrese tiempo: ");
            double tiempo = double.Parse(Console.ReadLine());
            double velocidad = distancia / tiempo;
            Console.WriteLine("Velocidad: " + velocidad);
        }

        // 2. Mostrar los primeros 20 múltiplos de 2
        static void MostrarMultiplosDe2()
        {
            for (int i = 1; i <= 20; i++)
                Console.WriteLine(i * 2);
        }

        // 3. Mostrar si un número es positivo o negativo
        static void PositivoONegativo()
        {
            Console.Write("Ingrese un número: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num >= 0 ? "Positivo" : "Negativo");
        }

        // 4. Calcular la hipotenusa
        static void CalcularHipotenusa()
        {
            Console.Write("Ingrese cateto A: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Ingrese cateto B: ");
            double b = double.Parse(Console.ReadLine());
            double h = Math.Sqrt(a * a + b * b);
            Console.WriteLine("Hipotenusa: " + h);
        }

        // 5. Cuadrado de un número
        static void CuadradoNumero()
        {
            Console.Write("Ingrese un número: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Cuadrado: " + (num * num));
        }

        // 6. Pedir nombre y saludar
        static void Saludo()
        {
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Hola, " + nombre);
        }

        // 7. Doble de un número
        static void DoblarNumero()
        {
            Console.Write("Ingrese un número: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Doble: " + (num * 2));
        }

        // 8. Dividir 2 números
        static void DividirNumeros()
        {
            Console.Write("Ingrese número 1: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Ingrese número 2: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Resultado: " + (a / b));
        }

        // 9. Sumar los primeros 10 números naturales
        static void SumarPrimeros10()
        {
            int suma = 0;
            for (int i = 1; i <= 10; i++)
                suma += i;
            Console.WriteLine("Suma: " + suma);
        }

        // 10. Convertir segundos a minutos
        static void SegundosAMinutos()
        {
            Console.Write("Ingrese segundos: ");
            double seg = double.Parse(Console.ReadLine());
            Console.WriteLine("Minutos: " + (seg / 60));
        }

        // 11. Calcular IVA
        static void CalcularIVA()
        {
            Console.Write("Ingrese precio: ");
            double precio = double.Parse(Console.ReadLine());
            double iva = precio * 0.15;
            Console.WriteLine("IVA: " + iva);
        }

        // 12. Último carácter de una cadena
        static void UltimoCaracter()
        {
            Console.Write("Ingrese texto: ");
            string texto = Console.ReadLine();
            Console.WriteLine("Último carácter: " + texto[texto.Length - 1]);
        }

        // 13. Convertir a minúscula
        static void TextoMinuscula()
        {
            Console.Write("Ingrese texto: ");
            string texto = Console.ReadLine();
            Console.WriteLine(texto.ToLower());
        }

        // 14. Convertir días a horas
        static void DiasAHoras()
        {
            Console.Write("Ingrese días: ");
            int dias = int.Parse(Console.ReadLine());
            Console.WriteLine("Horas: " + (dias * 24));
        }

        // 15. Números del 1 al 100
        static void Mostrar1Al100()
        {
            for (int i = 1; i <= 100; i++)
                Console.WriteLine(i);
        }

        // 16. Elevar al cubo
        static void CuboNumero()
        {
            Console.Write("Ingrese número: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Cubo: " + (num * num * num));
        }

        // 17. Mayor de dos números
        static void MayorDeDos()
        {
            Console.Write("Ingrese num1: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Ingrese num2: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Mayor: " + Math.Max(a, b));
        }

        // 18. Multiplicar 2 números
        static void Multiplicar()
        {
            Console.Write("Ingrese num1: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Ingrese num2: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Resultado: " + (a * b));
        }

        // 19. Verificar si son iguales
        static void SonIguales()
        {
            Console.Write("Num1: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Num2: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a == b ? "Son iguales" : "Son diferentes");
        }

        // 20. Área de un círculo
        static void AreaCirculo()
        {
            Console.Write("Radio: ");
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;
            Console.WriteLine("Área: " + area);
        }

        // 21. Descuento de un producto
        static void Descuento()
        {
            Console.Write("Precio: ");
            double p = double.Parse(Console.ReadLine());
            double d = p * 0.10;
            Console.WriteLine("Descuento: " + d);
        }

        // 22. Divisible por 5
        static void DivisibleEntre5()
        {
            Console.Write("Número: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n % 5 == 0 ? "Divisible" : "No divisible");
        }

        // 23. Menor de dos
        static void MenorDeDos()
        {
            Console.Write("Num1: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Num2: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Menor: " + Math.Min(a, b));
        }

        // 24. Clasificar edad
        static void ClasificarEdad()
        {
            Console.Write("Edad: ");
            int edad = int.Parse(Console.ReadLine());
            if (edad < 12) Console.WriteLine("Niño");
            else if (edad < 18) Console.WriteLine("Joven");
            else Console.WriteLine("Adulto");
        }

        // 25. Área triángulo
        static void AreaTriangulo()
        {
            Console.Write("Base: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Área: " + (b * h / 2));
        }

        // 26. Área cuadrado
        static void AreaCuadrado()
        {
            Console.Write("Lado: ");
            double l = double.Parse(Console.ReadLine());
            Console.WriteLine("Área: " + (l * l));
        }

        // 27. Más de 5 caracteres
        static void MasDe5Caracteres()
        {
            Console.Write("Texto: ");
            string t = Console.ReadLine();
            Console.WriteLine(t.Length > 5 ? "Tiene más de 5" : "No tiene más de 5");
        }

        // 28. Par o impar
        static void ParOImpar()
        {
            Console.Write("Número: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n % 2 == 0 ? "Par" : "Impar");
        }

        // 29. Tabla de multiplicar
        static void TablaMultiplicar()
        {
            Console.Write("Número: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
                Console.WriteLine(n + " x " + i + " = " + (n * i));
        }

        // 30. Múltiplo de 3
        static void MultiploDe3()
        {
            Console.Write("Número: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n % 3 == 0 ? "Es múltiplo" : "No es múltiplo");
        }

        // 31. Celsius a Fahrenheit
        static void CelsiusAFahrenheit()
        {
            Console.Write("Celsius: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Fahrenheit: " + (c * 9 / 5 + 32));
        }

        // 32. Repetir palabra
        static void RepetirPalabra()
        {
            Console.Write("Palabra: ");
            string p = Console.ReadLine();
            Console.Write("Veces: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) Console.WriteLine(p);
        }

        // 33. Primer carácter
        static void PrimerCaracter()
        {
            Console.Write("Texto: ");
            string t = Console.ReadLine();
            Console.WriteLine("Primer carácter: " + t[0]);
        }

        // 34. Calcular propina
        static void Propina()
        {
            Console.Write("Cuenta: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Porcentaje: ");
            double p = double.Parse(Console.ReadLine());
            Console.WriteLine("Propina: " + (c * p / 100));
        }

        // 35. Dólares a euros
        static void DolarAEuro()
        {
            Console.Write("Dólares: ");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Euros: " + (d * 0.90));
        }

        // 36. Perímetro triángulo
        static void PerimetroTriangulo()
        {
            Console.Write("Lado 1: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Lado 2: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Lado 3: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Perímetro: " + (a + b + c));
        }

        // 37. Vocal o consonante
        static void VocalOConsonante()
        {
            Console.Write("Letra: ");
            char l = char.Parse(Console.ReadLine().ToLower());
            Console.WriteLine("aeiou".Contains(l) ? "Vocal" : "Consonante");
        }

        // 38. Sumar 2 números
        static void SumarDos()
        {
            Console.Write("Num1: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Num2: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Suma: " + (a + b));
        }

        // 39. Metros a kilómetros
        static void MetrosAKm()
        {
            Console.Write("Metros: ");
            double m = double.Parse(Console.ReadLine());
            Console.WriteLine("Km: " + (m / 1000));
        }

        // 40. Texto a mayúscula
        static void TextoMayuscula()
        {
            Console.Write("Texto: ");
            string t = Console.ReadLine();
            Console.WriteLine(t.ToUpper());
        }

        // 41. Mayor de edad
        static void MayorEdad()
        {
            Console.Write("Edad: ");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine(e >= 18 ? "Mayor de edad" : "Menor de edad");
        }

        // 42. Calcular IVA (repetido)
        static void CalcularIVA2()
        {
            Console.Write("Precio: ");
            double p = double.Parse(Console.ReadLine());
            Console.WriteLine("IVA: " + (p * 0.15));
        }
    }
}
