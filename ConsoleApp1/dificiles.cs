using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("¿Cuántas líneas de log va a ingresar? ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Número inválido. Saliendo.");
            return;
        }

        var infoSamples = new List<string>();
        var warnSamples = new List<string>();
        var errorSamples = new List<string>();
        int info = 0, warn = 0, error = 0, other = 0;

        Console.WriteLine("Ingrese las líneas de log (ej: INFO - Mensaje):");
        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();
            if (string.IsNullOrEmpty(line)) { other++; continue; }
            string up = line.ToUpper();

            if (up.Contains("ERROR"))
            {
                error++;
                if (errorSamples.Count < 5) errorSamples.Add(line);
            }
            else if (up.Contains("WARNING") || up.Contains("WARN"))
            {
                warn++;
                if (warnSamples.Count < 5) warnSamples.Add(line);
            }
            else if (up.Contains("INFO"))
            {
                info++;
                if (infoSamples.Count < 5) infoSamples.Add(line);
            }
            else
            {
                other++;
            }
        }

        int total = info + warn + error + other;
        Console.WriteLine();
        Console.WriteLine("=== REPORTE DE LOGS ===");
        Console.WriteLine("Total líneas: " + total);
        Console.WriteLine("INFO: " + info);
        Console.WriteLine("WARNING: " + warn);
        Console.WriteLine("ERROR: " + error);
        Console.WriteLine("OTRAS / SIN NIVEL DETECTADO: " + other);
        Console.WriteLine();

        void Print(string title, List<string> samples)
        {
            Console.WriteLine($"--- Muestra {title} (máx 5) ---");
            if (samples.Count == 0) Console.WriteLine("  (ninguna)");
            else foreach (var s in samples) Console.WriteLine("  " + s);
            Console.WriteLine();
        }

        Print("INFO", infoSamples);
        Print("WARNING", warnSamples);
        Print("ERROR", errorSamples);

        Console.WriteLine("Nota: la clasificación busca las palabras INFO, WARNING/WARN y ERROR (no distingue posicion exacta).");
    }
}






using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("¿Cuántas transacciones va a ingresar? ");
        if (!int.TryParse(Console.ReadLine(), out int m) || m <= 0)
        {
            Console.WriteLine("Número inválido. Saliendo.");
            return;
        }

        Console.WriteLine("Ingrese cada transacción en una línea con formato: Id,Fecha(YYYY-MM-DD),Monto,Descripcion");
        bool anyAnomaly = false;
        for (int i = 1; i <= m; i++)
        {
            string line = Console.ReadLine() ?? "";
            if (string.IsNullOrWhiteSpace(line))
            {
                Console.WriteLine($"L{i}: Línea vacía -> Formato incorrecto.");
                anyAnomaly = true;
                continue;
            }

            var parts = line.Split(',');
            if (parts.Length < 4)
            {
                Console.WriteLine($"L{i}: Formato incorrecto (se requieren 4 columnas). Línea: \"{line}\"");
                anyAnomaly = true;
                continue;
            }

            string id = parts[0].Trim();
            string fechaStr = parts[1].Trim();
            string montoStr = parts[2].Trim();
            // descripcion puede contener comas en entradas reales, pero aquí asumimos CSV simple
            if (string.IsNullOrEmpty(id))
            {
                Console.WriteLine($"L{i}: Id vacío.");
                anyAnomaly = true;
            }

            // Validar fecha (YYYY-MM-DD preferido)
            if (!DateTime.TryParseExact(fechaStr, new[] { "yyyy-MM-dd", "yyyy/MM/dd", "dd/MM/yyyy" },
                                       CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fecha))
            {
                Console.WriteLine($"L{i} ({id}): Fecha inválida -> \"{fechaStr}\"");
                anyAnomaly = true;
            }

            // Validar monto
            if (!double.TryParse(montoStr, NumberStyles.Any, CultureInfo.InvariantCulture, out double monto))
            {
                // intentar con separador local si falla (por si usan coma)
                if (!double.TryParse(montoStr, out monto))
                {
                    Console.WriteLine($"L{i} ({id}): Monto no numérico -> \"{montoStr}\"");
                    anyAnomaly = true;
                }
            }

            // monto negativo
            if (double.TryParse(montoStr, NumberStyles.Any, CultureInfo.InvariantCulture, out double parsed) || double.TryParse(montoStr, out parsed))
            {
                if (parsed < 0)
                {
                    Console.WriteLine($"L{i} ({id}): Monto negativo -> {parsed}");
                    anyAnomaly = true;
                }
            }
        }

        if (!anyAnomaly) Console.WriteLine("No se detectaron anomalías en las transacciones ingresadas.");
        else Console.WriteLine("Revisión completada. Revise las líneas marcadas arriba.");
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese su texto (varias líneas). Escriba una línea con solo END para terminar:");
        var sb = new StringBuilder();
        while (true)
        {
            string line = Console.ReadLine();
            if (line != null && line.Trim() == "END") break;
            sb.AppendLine(line ?? "");
        }
        string text = sb.ToString();

        // Tokenizar sin Regex: caracteres alfanuméricos forman una palabra
        var words = new List<string>();
        var token = new StringBuilder();
        foreach (char c in text)
        {
            if (char.IsLetterOrDigit(c))
            {
                token.Append(char.ToLower(c));
            }
            else
            {
                if (token.Length > 0)
                {
                    words.Add(token.ToString());
                    token.Clear();
                }
            }
        }
        if (token.Length > 0) words.Add(token.ToString());

        if (words.Count == 0)
        {
            Console.WriteLine("No se detectaron palabras.");
            return;
        }

        var groups = words.GroupBy(w => w)
                          .Select(g => new { Word = g.Key, Count = g.Count() })
                          .OrderByDescending(x => x.Count)
                          .ThenBy(x => x.Word)
                          .ToList();

        int totalWords = words.Count;
        int uniqueWords = groups.Count;
        int singleAppearances = groups.Count(g => g.Count == 1);

        Console.WriteLine();
        Console.WriteLine($"Total tokens: {totalWords}");
        Console.WriteLine($"Palabras únicas: {uniqueWords}");
        Console.WriteLine($"Palabras que aparecen 1 vez: {singleAppearances}");
        Console.WriteLine();

        int topN = 10;
        Console.WriteLine($"Top {topN} palabras más frecuentes:");
        foreach (var it in groups.Take(topN))
            Console.WriteLine($"  {it.Word} -> {it.Count}");

        int minFreq = groups.Min(g => g.Count);
        Console.WriteLine();
        Console.WriteLine($"Palabras menos comunes (frecuencia = {minFreq}):");
        foreach (var it in groups.Where(g => g.Count == minFreq).Take(20))
            Console.WriteLine($"  {it.Word} -> {it.Count}");
    }
}




using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("¿Cuántos números ingresará? ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Número inválido. Saliendo.");
            return;
        }

        double[] data = new double[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Valor #{i + 1}: ");
            while (!double.TryParse(Console.ReadLine(), out data[i]))
            {
                Console.Write("Entrada inválida. Ingrese un número válido: ");
            }
        }

        Console.Write("Ingrese umbral sigma (ej. 2.0, 2.5, 3.0): ");
        if (!double.TryParse(Console.ReadLine(), out double sigma) || sigma <= 0)
        {
            Console.WriteLine("Umbral inválido. Usando 3.0 por defecto.");
            sigma = 3.0;
        }

        double mean = data.Average();
        double variance = data.Select(x => (x - mean) * (x - mean)).Average(); // poblacional
        double stdDev = Math.Sqrt(variance);

        Console.WriteLine();
        Console.WriteLine($"N = {n}");
        Console.WriteLine($"Media = {mean:F4}");
        Console.WriteLine($"Desviación estándar (poblacional) = {stdDev:F4}");
        Console.WriteLine($"Umbral = {sigma} * stdDev = {sigma * stdDev:F4}");
        Console.WriteLine();

        var outliers = data.Select(x => new { Value = x, Z = (stdDev == 0 ? 0 : (x - mean) / stdDev) })
                           .Where(x => Math.Abs(x.Value - mean) > sigma * stdDev)
                           .ToList();

        if (outliers.Count == 0)
        {
            Console.WriteLine("No se detectaron outliers con el umbral indicado.");
        }
        else
        {
            Console.WriteLine("Outliers detectados:");
            foreach (var o in outliers)
            {
                double delta = o.Value - mean;
                Console.WriteLine($"  Valor: {o.Value}  Δ={delta:F4}  Z-score={o.Z:F4}");
            }
            Console.WriteLine();
            Console.WriteLine("Explicación: Un valor se considera atípico si su distancia absoluta a la media\n" +
                              $"es mayor que {sigma} veces la desviación estándar.");
        }
    }
}




using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class Program
{
    class Producto
    {
        public string Id;
        public string Nombre;
        public double Precio;
    }

    static void Main()
    {
        Console.Write("¿Cuántos productos ingresará? ");
        if (!int.TryParse(Console.ReadLine(), out int p) || p <= 0)
        {
            Console.WriteLine("Número inválido. Saliendo.");
            return;
        }

        var productos = new List<Producto>();

        Console.WriteLine("Ingrese cada producto como: Id,Nombre,Precio  (ej: p1,Pan,1.50)");
        for (int i = 0; i < p; i++)
        {
            string line = Console.ReadLine() ?? "";
            var parts = line.Split(',');
            if (parts.Length < 3)
            {
                Console.WriteLine("Formato inválido en la línea. Se omitirá.");
                continue;
            }
            string id = parts[0].Trim();
            string nombre = parts[1].Trim();
            string priceText = parts[2].Trim();

            double precio;
            if (!double.TryParse(priceText, NumberStyles.Any, CultureInfo.InvariantCulture, out precio))
            {
                // intentar parse local
                if (!double.TryParse(priceText, out precio))
                {
                    Console.WriteLine("Precio inválido; se usará 0.0");
                    precio = 0.0;
                }
            }

            productos.Add(new Producto { Id = id, Nombre = nombre, Precio = precio });
        }

        // Agrupar por nombre
        var grupos = productos.GroupBy(x => x.Nombre)
                              .Select(g => new { Nombre = g.Key, Count = g.Count(), Items = g.ToList() })
                              .Where(g => g.Count > 1)
                              .ToList();

        if (grupos.Count == 0)
        {
            Console.WriteLine("No se encontraron duplicados por nombre.");
        }
        else
        {
            Console.WriteLine("Duplicados encontrados (agrupados por Nombre):");
            foreach (var g in grupos)
            {
                Console.WriteLine($"Nombre: \"{g.Nombre}\" - Aparece {g.Count} veces");
                Console.WriteLine(" Ejemplos:");
                foreach (var it in g.Items.Take(5))
                    Console.WriteLine($"   Id:{it.Id} Nombre:{it.Nombre} Precio:{it.Precio}");
            }
        }

        // Depurar: mantener la PRIMERA ocurrencia de cada nombre
        var depurado = new List<Producto>();
        var seen = new HashSet<string>();
        foreach (var prod in productos)
        {
            if (!seen.Contains(prod.Nombre))
            {
                depurado.Add(prod);
                seen.Add(prod.Nombre);
            }
        }

        Console.WriteLine();
        Console.WriteLine("Lista depurada (se mantiene la primera ocurrencia por Nombre):");
        foreach (var d in depurado)
            Console.WriteLine($"Id:{d.Id} Nombre:{d.Nombre} Precio:{d.Precio}");
    }
}
