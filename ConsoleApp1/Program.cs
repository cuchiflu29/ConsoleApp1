using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosNivelMedio
{
    class Program
    {
        static void Main(string[] args)
        {
            TotalSupermercado();
            // Llama aquí el que quieras probar
        }

        // 1. Total a pagar en supermercado
        static void TotalSupermercado()
        {
            double total = 0;
            for (int i = 1; i <= 3; i++)
            {
                Console.Write($"Precio producto {i}: ");
                total += double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Total a pagar: " + total);
        }

        // 2. Eliminar nombre por índice
        static void EliminarNombrePorIndice()
        {
            List<string> nombres = new List<string>() { "Ana", "Luis", "Carlos", "Maria" };
            Console.Write("Índice a eliminar: ");
            int i = int.Parse(Console.ReadLine());
            nombres.RemoveAt(i);
            foreach (string n in nombres) Console.WriteLine(n);
        }

        // 3. Convertir temperaturas a Celsius
        static void ListaACelsius()
        {
            double[] f = { 32, 50, 77, 104 };
            foreach (double t in f)
                Console.WriteLine((t - 32) * 5 / 9);
        }

        // 4. Menú de opciones
        static void MenuCalculadora()
        {
            Console.WriteLine("1. Sumar\n2. Restar");
            int op = int.Parse(Console.ReadLine());
            Console.Write("A: "); int a = int.Parse(Console.ReadLine());
            Console.Write("B: "); int b = int.Parse(Console.ReadLine());

            if (op == 1) Console.WriteLine("Suma: " + (a + b));
            else Console.WriteLine("Resta: " + (a - b));
        }

        // 5. Registrar nombres
        static void RegistrarNombres()
        {
            List<string> lista = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Nombre: ");
                lista.Add(Console.ReadLine());
            }
            foreach (string n in lista) Console.WriteLine(n);
        }

        // 6. Llenar arreglo 10 posiciones
        static void LlenarArreglo10()
        {
            int[] v = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Valor {i}: ");
                v[i] = int.Parse(Console.ReadLine());
            }
            foreach (int n in v) Console.WriteLine(n);
        }

        // 7. Contar mayores a 50
        static void ContarMayores50()
        {
            int[] v = { 10, 60, 80, 30, 90 };
            int c = v.Count(n => n > 50);
            Console.WriteLine("Mayores a 50: " + c);
        }

        // 8. Mayor de 5 números
        static void MayorDe5()
        {
            int[] v = new int[5];
            for (int i = 0; i < 5; i++) v[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Mayor: " + v.Max());
        }

        // 9. Promedio de 5 números
        static void Promedio5()
        {
            double suma = 0;
            for (int i = 0; i < 5; i++)
                suma += double.Parse(Console.ReadLine());
            Console.WriteLine("Promedio: " + (suma / 5));
        }

        // 10. Ordenar 5 números
        static void Ordenar5()
        {
            int[] v = new int[5];
            for (int i = 0; i < 5; i++) v[i] = int.Parse(Console.ReadLine());
            Array.Sort(v);
            foreach (int n in v) Console.WriteLine(n);
        }

        // 11. Promedio de arreglo
        static void PromedioArreglo()
        {
            int[] v = { 10, 20, 30 };
            Console.WriteLine("Promedio: " + v.Average());
        }

        // 12. Quitar espacios
        static void QuitarEspacios()
        {
            Console.Write("Texto: ");
            string t = Console.ReadLine();
            Console.WriteLine(t.Replace(" ", ""));
        }

        // 13. Palabra más larga
        static void PalabraMasLarga()
        {
            Console.Write("Frase: ");
            string[] p = Console.ReadLine().Split(' ');
            Console.WriteLine(p.OrderByDescending(x => x.Length).First());
        }

        // 14. Buscar número en arreglo
        static void BuscarNumero()
        {
            int[] v = { 5, 10, 15, 20 };
            Console.Write("Buscar: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(v.Contains(b) ? "Encontrado" : "No encontrado");
        }

        // 15. Invertir cadena
        static void InvertirCadena()
        {
            string t = Console.ReadLine();
            char[] a = t.ToCharArray();
            Array.Reverse(a);
            Console.WriteLine(new string(a));
        }

        // 16. Eliminar espacios (repetido)
        static void EliminarEspacios()
        {
            Console.WriteLine(Console.ReadLine().Replace(" ", ""));
        }

        // 17. Menor de 5 números
        static void MenorDe5()
        {
            int[] v = new int[5];
            for (int i = 0; i < 5; i++) v[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Menor: " + v.Min());
        }

        // 18. Factorial
        static void Factorial()
        {
            int n = int.Parse(Console.ReadLine());
            int f = 1;
            for (int i = 1; i <= n; i++) f *= i;
            Console.WriteLine("Factorial: " + f);
        }

        // 19. Contar vocales
        static void ContarVocales()
        {
            string t = Console.ReadLine().ToLower();
            int c = t.Count(x => "aeiou".Contains(x));
            Console.WriteLine("Vocales: " + c);
        }

        // 20. Sumar arreglo
        static void SumarArreglo()
        {
            int[] v = { 1, 2, 3, 4 };
            Console.WriteLine("Suma: " + v.Sum());
        }

        // 21. Contar palabra repetida
        static void ContarPalabra()
        {
            string frase = Console.ReadLine();
            string buscar = Console.ReadLine();
            int c = frase.Split(' ').Count(p => p == buscar);
            Console.WriteLine("Aparece: " + c);
        }

        // 22. Llenar arreglo (repetido)
        static void LlenarArreglo10_2()
        {
            LlenarArreglo10();
        }

        // 23. Simular cajero
        static void Cajero()
        {
            double saldo = 1000;
            Console.Write("Retiro: ");
            double r = double.Parse(Console.ReadLine());
            if (r <= saldo) Console.WriteLine("Nuevo saldo: " + (saldo - r));
            else Console.WriteLine("Fondos insuficientes");
        }

        // 24. Ordenar 10 de mayor a menor
        static void Ordenar10Desc()
        {
            int[] v = new int[10];
            for (int i = 0; i < 10; i++) v[i] = int.Parse(Console.ReadLine());
            Array.Sort(v);
            Array.Reverse(v);
            foreach (int n in v) Console.WriteLine(n);
        }

        // 25. Palabras en líneas
        static void PalabrasPorLinea()
        {
            foreach (string p in Console.ReadLine().Split(' '))
                Console.WriteLine(p);
        }

        // 26. Login simple
        static void Login()
        {
            Console.Write("Usuario: ");
            string u = Console.ReadLine();
            Console.Write("Clave: ");
            string c = Console.ReadLine();
            Console.WriteLine(u == "admin" && c == "1234" ? "Bienvenido" : "Error");
        }

        // 27. Contar palabras
        static void ContarPalabras()
        {
            Console.WriteLine(Console.ReadLine().Split(' ').Length);
        }

        // 28. Contar letra
        static void ContarLetra()
        {
            string t = Console.ReadLine();
            char l = char.Parse(Console.ReadLine());
            Console.WriteLine(t.Count(x => x == l));
        }

        // 29. Contraseña aleatoria
        static void ContrasenaAleatoria()
        {
            Random r = new Random();
            string c = "123456789abcdefghijklmnopqrstuvwxyz";
            string pass = "";
            for (int i = 0; i < 8; i++)
                pass += c[r.Next(c.Length)];
            Console.WriteLine(pass);
        }

        // 30. Días entre fechas
        static void DiasEntreFechas()
        {
            DateTime f1 = DateTime.Parse(Console.ReadLine());
            DateTime f2 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine((f2 - f1).Days);
        }

        // 31. Adivinar número
        static void JuegoAdivinar()
        {
            Random r = new Random();
            int secreto = r.Next(1, 51);
            int n;
            do
            {
                n = int.Parse(Console.ReadLine());
            } while (n != secreto);
            Console.WriteLine("Ganaste");
        }

        // 32. Editar nombre por índice
        static void EditarNombre()
        {
            List<string> l = new List<string>() { "Ana", "Luis" };
            int i = int.Parse(Console.ReadLine());
            l[i] = Console.ReadLine();
            foreach (var x in l) Console.WriteLine(x);
        }

        // 33. Restar matrices 2x2
        static void RestarMatrices()
        {
            int[,] A = { { 5, 5 }, { 5, 5 } };
            int[,] B = { { 2, 2 }, { 2, 2 } };

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    Console.WriteLine(A[i, j] - B[i, j]);
        }

        // 34. Convertir a Fahrenheit
        static void CelsiusAFahrenheitLista()
        {
            double[] c = { 0, 10, 20 };
            foreach (double x in c)
                Console.WriteLine(x * 9 / 5 + 32);
        }

        // 35. Contar impares
        static void ContarImpares()
        {
            int c = 0;
            for (int i = 0; i < 10; i++)
                if (int.Parse(Console.ReadLine()) % 2 != 0) c++;
            Console.WriteLine(c);
        }

        // 36. Simular dado
        static void SimularDado()
        {
            Random r = new Random();
            Console.WriteLine(r.Next(1, 7));
        }

        // 37. Fibonacci
        static void Fibonacci()
        {
            int n = int.Parse(Console.ReadLine());
            int a = 0, b = 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                int t = a + b;
                a = b;
                b = t;
            }
        }

        // 38. Triángulo asteriscos
        static void TrianguloAsteriscos()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
                Console.WriteLine(new string('*', i));
        }

        // 39. Cuadrado asteriscos
        static void CuadradoAsteriscos()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
                Console.WriteLine(new string('*', n));
        }

        // 40. Sumar pares
        static void SumarPares()
        {
            int s = 0;
            for (int i = 2; i <= 100; i += 2) s += i;
            Console.WriteLine(s);
        }

        // 41. Sumar impares
        static void SumarImpares()
        {
            int s = 0;
            for (int i = 1; i <= 100; i += 2) s += i;
            Console.WriteLine(s);
        }

        // 42. Palabra más corta
        static void PalabraMasCorta()
        {
            string[] p = Console.ReadLine().Split(' ');
            Console.WriteLine(p.OrderBy(x => x.Length).First());
        }
    }
}
