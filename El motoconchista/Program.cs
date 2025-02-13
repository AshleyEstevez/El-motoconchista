using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static Random random = new Random();
    static void Main()
    {
        Dictionary<string, int> motoconchistas = new Dictionary<string, int>();
        Dictionary<string, int> tiempos = new Dictionary<string, int>();
        List<string> cancelados = new List<string>();

        for (int i = 1; i <= 4; i++)
        {
            string nombre = $"Motoconchista {i}";
            motoconchistas[nombre] = 0;
            tiempos[nombre] = 0;
        }

        while (!MotoconchoGanador(motoconchistas))
        {
            foreach (var motoconcho in new List<string>(motoconchistas.Keys))
            {
                if (cancelados.Contains(motoconcho)) continue;

                string accion = ObtenerAccionAleatoria();
                int avance = 0;

                if (random.NextDouble() < 0.1) // 10% de ser cancelado
                {
                    Console.WriteLine($"{motoconcho} ha sido cancelado por robarse el motor o el dinero.");
                    cancelados.Add(motoconcho);
                    continue;
                }

                switch (accion)
                {
                    case "Acelerar":
                        avance = random.Next(15, 41);
                        if (random.NextDouble() < 0.1)
                        {
                            Console.WriteLine($"{motoconcho} cayó en un hoyo y perdió 20 metros.");
                            avance -= 20;
                        }
                        break;
                    case "Hacer Ziczac":
                        avance = random.Next(10, 31);
                        if (random.NextDouble() < 0.05)
                        {
                            Console.WriteLine($"{motoconcho} chocó con otro motoconcho y perdió 20 metros.");
                            avance -= 20;
                        }
                        break;
                    case "Evadir Amet":
                        if (random.NextDouble() >= 0.5)
                        {
                            Console.WriteLine($"{motoconcho} fue retenido por Amet y perdió 2 segundos sin avanzar.");
                            tiempos[motoconcho] += 2;
                        }
                        break;
                    case "Lidiar con el Pasajero":
                        if (random.NextDouble() < 0.3)
                        {
                            Console.WriteLine($"{motoconcho} perdió tiempo porque el pasajero se cayó y perdió 6 segundos de avance.");
                            tiempos[motoconcho] += 6;
                        }
                        else
                        {
                            avance = 20;
                        }
                        break;
                }

                motoconchistas[motoconcho] += Math.Max(0, avance);
                Console.WriteLine($"{motoconcho} realizó {accion} y avanzó {avance} metros. Total: {motoconchistas[motoconcho]} metros");

                Thread.Sleep(500);

                if (motoconchistas[motoconcho] >= 500)
                {
                    Console.WriteLine($"\n{motoconcho} ha ganado la carrera!\n");
                    return;
                }
            }
        }
    }

    static bool MotoconchoGanador(Dictionary<string, int> motoconchistas)
    {
        foreach (var distancia in motoconchistas.Values)
        {
            if (distancia >= 500) return true;
        }
        return false;
    }

    static string ObtenerAccionAleatoria()
    {
        string[] acciones = { "Acelerar", "Hacer Ziczac", "Evadir Amet", "Lidiar con el Pasajero" };
        return acciones[random.Next(acciones.Length)];
    }
}
