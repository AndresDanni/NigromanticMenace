using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Juego: NIGROMANTIC MENACE v1.00
            string[] strHitPoint = new string[] { "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█" };
            string[] strJugador = new string[] { "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█" };
            bool blnMenu = true;
            int intOpcion;
            int intNivel = 1;
            string strNivel = "";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine(@" ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
 █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
 █▒┌────────────────────────────────────────────────────────────────────────┐▒█
 █▒│                        NIGROMANTIC MENACE v1.00                        │▒█
 █▒│                                                                        │▒█
 █▒│  Eres Alexander, un invocador de hechizos de magia elemental de Frío.  │▒█
 █▒│                                                                        │▒█
 █▒│  Días atrás estuviste explorando la Cripta de un antiguo Archimago y   │▒█
 █▒│     encontraste un pergamino que revela con detalle la Conjuración     │▒█
 █▒│                              Nigromántica.                             │▒█
 █▒│                                                                        │▒█
 █▒│          Has leído el documento y decidido hacer uso de él.            │▒█
 █▒│                                                                        │▒█
 █▒│ ¡Usa tus habilidades mágicas para acabar con tantos espectros puedas!  │▒█
 █▒│                                                                        │▒█
 █▒│                   <PRESIONA UNA TECLA PARA COMENZAR>                   │▒█
 █▒│                                                                        │▒█
 █▒│ ────────────────────────────────────────────────────────────────────── │▒█
 █▒│ ┌────────────────────────────────────────────────────────────────────┐ │▒█
 █▒│ │                                                                    │ │▒█
 █▒│ └────────────────────────────────────────────────────────────────────┘ │▒█
 █▒└────────────────────────────────────────────────────────────────────────┘▒█
 █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
            Console.ReadKey();
            Cargar();
            while (blnMenu)
            {
                Console.Clear();
                if (strHitPoint[0] == " ")
                {
                    intNivel++;
                    if (intNivel == 7)
                    {
                        Console.WriteLine(" ╔═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╗  ──┬────────────────────────────┬──");
                        Console.WriteLine(" ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║    │  Nigromantic Menace v1.00  │");
                        Console.WriteLine(" ╚═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╝  ──┴────────────────────────────┴──");
                        Console.WriteLine(" ──────────────── Enemigo ────────────────  ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
                        Console.WriteLine(@"                                            █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
                                            █▒┌────────────────────────────┐▒█
                                            █▒│ Combate               Ptos │▒█
                                            █▒│ ├─Ice Bolt.............1-2 │▒█
       ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄        █▒│ ├─Frost Nova...........1-2 │▒█
       █ FELICIDADES, ¡HAS GANADO! █        █▒│ ├─Glacial Spike........0-3 │▒█
       ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀        █▒│ ├─Blizzard.............0-3 │▒█
             ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄               █▒│                            │▒█
             █ FIN DE JUEGO █               █▒│ Defensa               Ptos │▒█
             ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀               █▒│ ├─Frozen Armor...........1 │▒█
                                            █▒│                            │▒█
                                            █▒│ Restauración          Ptos │▒█
 ├─Ice Bolt        <1>├─Healing        <4>  █▒│ ├─Healing................2 │▒█
 ├─Frost Ring      <2>├─Frozen Armor   <5>  █▒│                            │▒█
 ├─Glacial Spike   <3>├─Blizzard       <6>  █▒└────────────────────────────┘▒█
                                            █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█");
                        Console.WriteLine(" ─────────────── Alexander ───────────────  ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
                        Console.WriteLine(" ╔═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╗  ──────────────────────────────────");
                        Console.WriteLine(" ║" + strJugador[0] + "║" + strJugador[1] + "║" + strJugador[2] + "║" + strJugador[3] + "║" + strJugador[4] + "║" + strJugador[5] + "║" + strJugador[6] + "║" + strJugador[7] + "║" + strJugador[8] + "║" + strJugador[9] + "║" + strJugador[10] + "║" + strJugador[11] + "║" + strJugador[12] + "║" + strJugador[13] + "║" + strJugador[14] + "║" + strJugador[15] + "║" + strJugador[16] + "║" + strJugador[17] + "║" + strJugador[18] + "║" + strJugador[19] + "║  Videojuego creado por Andrés Danni");
                        Console.WriteLine(" ╚═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╝  ──────────────────────────────────");
                        Console.ReadKey();
                        Main(null);
                    }
                    Victoria();
                    Console.ReadKey();
                    for (int intX = 0; intX <= 19; intX++)
                    {
                        strHitPoint[intX] = "█";
                        strJugador[intX] = "█";
                    }
                    switch (intNivel)
                    {
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            strNivel = "│          NIVEL 2          │";
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            strNivel = "│          NIVEL 3          │";
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.Red;
                            strNivel = "│          NIVEL 4          │";
                            break;
                        case 5:
                            Console.ForegroundColor = ConsoleColor.White;
                            strNivel = "│          NIVEL 5          │";
                            break;
                        case 6:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            strNivel = "│          NIVEL 6          │";
                            break;
                    }
                    Console.Clear();
                    Console.WriteLine(" ╔═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╗  ──┬────────────────────────────┬──");
                    Console.WriteLine(" ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║    │  Nigromantic Menace v1.00  │");
                    Console.WriteLine(" ╚═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╝  ──┴────────────────────────────┴──");
                    Console.WriteLine(" ──────────────── Enemigo ────────────────  ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
                    Console.WriteLine(@"                                            █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
                                            █▒┌────────────────────────────┐▒█
                                            █▒│ Combate               Ptos │▒█
                                            █▒│ ├─Ice Bolt.............1-2 │▒█
       ┌───────────────────────────┐        █▒│ ├─Frost Nova...........1-2 │▒█
       {0}        █▒│ ├─Glacial Spike........0-3 │▒█
       └───────────────────────────┘        █▒│ ├─Blizzard.............0-3 │▒█
                                            █▒│                            │▒█
                                            █▒│ Defensa               Ptos │▒█
                                            █▒│ ├─Frozen Armor...........1 │▒█
                                            █▒│                            │▒█
                                            █▒│ Restauración          Ptos │▒█
 ├─Ice Bolt        <1>├─Healing        <4>  █▒│ ├─Healing................2 │▒█
 ├─Frost Ring      <2>├─Frozen Armor   <5>  █▒│                            │▒█
 ├─Glacial Spike   <3>├─Blizzard       <6>  █▒└────────────────────────────┘▒█
                                            █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█", strNivel);
                    Console.WriteLine(" ─────────────── Alexander ───────────────  ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
                    Console.WriteLine(" ╔═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╗  ──────────────────────────────────");
                    Console.WriteLine(" ║" + strJugador[0] + "║" + strJugador[1] + "║" + strJugador[2] + "║" + strJugador[3] + "║" + strJugador[4] + "║" + strJugador[5] + "║" + strJugador[6] + "║" + strJugador[7] + "║" + strJugador[8] + "║" + strJugador[9] + "║" + strJugador[10] + "║" + strJugador[11] + "║" + strJugador[12] + "║" + strJugador[13] + "║" + strJugador[14] + "║" + strJugador[15] + "║" + strJugador[16] + "║" + strJugador[17] + "║" + strJugador[18] + "║" + strJugador[19] + "║  Videojuego creado por Andrés Danni");
                    Console.WriteLine(" ╚═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╝  ──────────────────────────────────");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (strJugador[0] == " ")
                {
                    Derrota();
                    Console.ReadKey();
                    for (int intX = 0; intX <= 19; intX++)
                    {
                        strHitPoint[intX] = "█";
                        strJugador[intX] = "█";
                    }
                    intNivel = 1;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Main(null);
                }
                Interfaz();
                void Interfaz()
                {
                    Console.WriteLine(" ╔═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╗  ──┬────────────────────────────┬──");
                    Console.WriteLine(" ║" + strHitPoint[0] + "║" + strHitPoint[1] + "║" + strHitPoint[2] + "║" + strHitPoint[3] + "║" + strHitPoint[4] + "║" + strHitPoint[5] + "║" + strHitPoint[6] + "║" + strHitPoint[7] + "║" + strHitPoint[8] + "║" + strHitPoint[9] + "║" + strHitPoint[10] + "║" + strHitPoint[11] + "║" + strHitPoint[12] + "║" + strHitPoint[13] + "║" + strHitPoint[14] + "║" + strHitPoint[15] + "║" + strHitPoint[16] + "║" + strHitPoint[17] + "║" + strHitPoint[18] + "║" + strHitPoint[19] + "║    │  Nigromantic Menace v1.00  │");
                    Console.WriteLine(" ╚═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╝  ──┴────────────────────────────┴──");
                    Console.WriteLine(" ──────────────── Enemigo ────────────────  ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
                    Console.WriteLine(@"                                            █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
                   ████                     █▒┌────────────────────────────┐▒█
                 ████████                   █▒│ Combate               Ptos │▒█
                ██  ██  ██                  █▒│ ├─Ice Bolt.............1-2 │▒█
               ████████████                 █▒│ ├─Frost Nova...........1-2 │▒█
               ████████████                 █▒│ ├─Glacial Spike........0-3 │▒█
              ███ ▀ ▀ ▀  ███                █▒│ ├─Blizzard.............0-3 │▒█
              ███  ▄ ▄ ▄ ███                █▒│                            │▒█
              ██████████████                █▒│ Defensa               Ptos │▒█
              ██ ███  ███ ██                █▒│ ├─Frozen Armor...........1 │▒█
              █   ██  ██   █                █▒│                            │▒█
                                            █▒│ Restauración          Ptos │▒█
 ├─Ice Bolt        <1>├─Healing        <4>  █▒│ ├─Healing................2 │▒█
 ├─Frost Nova      <2>├─Frozen Armor   <5>  █▒│                            │▒█
 ├─Glacial Spike   <3>├─Blizzard       <6>  █▒└────────────────────────────┘▒█
                                            █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█");
                    Console.WriteLine(" ─────────────── Alexander ───────────────  ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
                    Console.WriteLine(" ╔═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╗  ──────────────────────────────────");
                    Console.WriteLine(" ║" + strJugador[0] + "║" + strJugador[1] + "║" + strJugador[2] + "║" + strJugador[3] + "║" + strJugador[4] + "║" + strJugador[5] + "║" + strJugador[6] + "║" + strJugador[7] + "║" + strJugador[8] + "║" + strJugador[9] + "║" + strJugador[10] + "║" + strJugador[11] + "║" + strJugador[12] + "║" + strJugador[13] + "║" + strJugador[14] + "║" + strJugador[15] + "║" + strJugador[16] + "║" + strJugador[17] + "║" + strJugador[18] + "║" + strJugador[19] + "║  Videojuego creado por Andrés Danni");
                    Console.WriteLine(" ╚═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╝  ──────────────────────────────────");
                }
                try
                {
                    string strInfo = "";
                    int intDamage;
                    int intConversion;
                    bool blnBloquear = false;
                    var varRandom = new Random(Environment.TickCount);
                    Console.Write(" "); intOpcion = Convert.ToInt32(Console.ReadLine());
                    switch (intOpcion)
                    {
                        case -1:
                            for (int intX = 19; intX >= 0; intX--)
                            {
                                strHitPoint[intX] = " ";
                            }
                            strInfo = " ▒│ Has utilizado un Truco. Phantasma pierde 20 puntos de salud.             │▒";
                            break;
                        case 1:
                            var varIceBolt = varRandom.Next(1, 3);
                            intConversion = Convert.ToInt32(varIceBolt);
                            intDamage = intConversion;
                            while (intConversion > 0)
                            {
                                for (int intX = 19; intX >= 0; intX--)
                                {
                                    if (strHitPoint[intX] == "█")
                                    {
                                        strHitPoint[intX] = " ";
                                        intX = -1;
                                    }
                                }
                                intConversion--;
                            }
                            strInfo = " ▒│ Has lanzado el hechizo \"Ice Bolt\". Phantasma pierde " + intDamage + " punto(s) de salud. │▒";
                            break;
                        case 2:
                            var varFrostRing = varRandom.Next(1, 3);
                            intConversion = Convert.ToInt32(varFrostRing);
                            intDamage = intConversion;
                            while (intConversion > 0)
                            {
                                for (int intX = 19; intX >= 0; intX--)
                                {
                                    if (strHitPoint[intX] == "█")
                                    {
                                        strHitPoint[intX] = " ";
                                        intX = -1;
                                    }
                                }
                                intConversion--;
                            }
                            strInfo = " ▒│ Has lanzado el hechizo \"Frost Nova\". Phantasma pierde " + intDamage + " punto(s) de      │▒\n ▒│ salud.                                                                   │▒";
                            break;
                        case 3:
                            var varLightningBolt = varRandom.Next(0, 4);
                            intConversion = Convert.ToInt32(varLightningBolt);
                            intDamage = intConversion;
                            while (intConversion > 0)
                            {
                                for (int intX = 19; intX >= 0; intX--)
                                {
                                    if (strHitPoint[intX] == "█")
                                    {
                                        strHitPoint[intX] = " ";
                                        intX = -1;
                                    }
                                }
                                intConversion--;
                            }
                            strInfo = " ▒│ Has lanzado el hechizo \"Glacial Spike\". Phantasma pierde " + intDamage + " punto(s) de   │▒\n ▒│ salud.                                                                   │▒";
                            break;
                        case 4:
                            int intCuracion = 0;
                            for (int intX = 0; intX <= 19; intX++)
                            {
                                if (strJugador[intX] == " " && intCuracion < 2)
                                {
                                    strJugador[intX] = "█";
                                    intCuracion++;
                                }
                            }
                            strInfo = " ▒│ Has usado el hechizo \"Healing\". Recuperas 2 puntos de salud.             │▒";
                            break;
                        case 5:
                            blnBloquear = true;
                            strInfo = " ▒│ Has usado el hechizo \"Frozen Armor\". Bloqueas 1 punto de daño físico.    │▒";
                            break;
                        case 6:
                            var varGlacialSpike = varRandom.Next(0, 4);
                            intConversion = Convert.ToInt32(varGlacialSpike);
                            intDamage = intConversion;
                            while (intConversion > 0)
                            {
                                for (int intX = 19; intX >= 0; intX--)
                                {
                                    if (strHitPoint[intX] == "█")
                                    {
                                        strHitPoint[intX] = " ";
                                        intX = -1;
                                    }
                                }
                                intConversion--;
                            }
                            strInfo = " ▒│ Has lanzado el hechizo \"Blizzard\". Phantasma pierde " + intDamage + " punto(s) de salud. │▒";
                            break;
                    }
                    var varAccion = varRandom.Next(1, 101);
                    intConversion = Convert.ToInt32(varAccion);
                    if (intConversion < 21)
                    {

                    }
                    else if (intConversion < 41)
                    {
                        var varDamage = varRandom.Next(1, 4);
                        intConversion = Convert.ToInt32(varDamage);
                        if (blnBloquear)
                        {
                            intConversion--;
                        }
                        intDamage = intConversion;
                        while (intConversion > 0)
                        {
                            for (int intX = 19; intX >= 0; intX--)
                            {
                                if (strJugador[intX] == "█")
                                {
                                    strJugador[intX] = " ";
                                    intX = -1;
                                }
                            }
                            intConversion--;
                        }
                        strInfo += "\n ▒│ Phantasma ataca a Alexander. Pierdes " + intDamage + " punto(s) de salud.                │▒";
                    }
                    else if (intConversion < 61)
                    {
                        int intCuracion = 0;
                        for (int intX = 0; intX <= 19; intX++)
                        {
                            if (strHitPoint[intX] == " " && intCuracion < 2)
                            {
                                strHitPoint[intX] = "█";
                                intCuracion++;
                            }
                        }
                        strInfo += "\n ▒│ Phantasma ha usado \"Nigromantic Healing\". Recupera 2 puntos de salud.    │▒";
                    }
                    else if (intConversion < 81)
                    {
                        intConversion = 3;
                        while (intConversion > 0)
                        {
                            for (int intX = 19; intX >= 0; intX--)
                            {
                                if (strJugador[intX] == "█")
                                {
                                    strJugador[intX] = " ";
                                    intX = -1;
                                }
                            }
                            intConversion--;
                        }
                        int intCuracion = 0;
                        for (int intX = 0; intX <= 19; intX++)
                        {
                            if (strHitPoint[intX] == " " && intCuracion < 3)
                            {
                                strHitPoint[intX] = "█";
                                intCuracion++;
                            }
                        }
                        strInfo += "\n ▒│ Phantasma ha usado \"Vampiric Drain\". Roba 3 puntos de salud.             │▒";
                    }
                    else if (intConversion > 80)
                    {
                        string[] strAuxiliar = new string[20];
                        for (int intX = 19; intX >= 0; intX--)
                        {
                            strAuxiliar[intX] = strHitPoint[intX];
                            strHitPoint[intX] = strJugador[intX];
                            strJugador[intX] = strAuxiliar[intX];
                        }
                        strInfo += "\n ▒│ Phantasma ha usado \"Life Swap\". Intercambia los puntos de salud con      │▒";
                        strInfo += "\n ▒│ Alexander.                                                               │▒";
                    }
                    string strMarquesina = "";
                    for (int intX = 0; intX < strInfo.Length; intX++)
                    {
                        Console.Clear();
                        Interfaz();
                        strMarquesina += strInfo[intX];
                        Console.WriteLine("\n ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
                        Console.WriteLine(" ▒┌──────────────────────────────────────────────────────────────────────────┐▒");
                        Console.WriteLine(strMarquesina);
                        Console.WriteLine(" ▒└──────────────────────────────────────────────────────────────────────────┘▒");
                        Console.WriteLine(" ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
                        if (Convert.ToString(strInfo[intX]) != " ")
                        {
                            System.Threading.Thread.Sleep(50);
                        }
                    }
                    Console.ReadKey();
                }
                catch
                {
                }
            }
            void Victoria()
            {
                Console.WriteLine(" ╔═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╗  ──┬────────────────────────────┬──");
                Console.WriteLine(" ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║    │  Nigromantic Menace v1.00  │");
                Console.WriteLine(" ╚═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╝  ──┴────────────────────────────┴──");
                Console.WriteLine(" ──────────────── Enemigo ────────────────  ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
                Console.WriteLine(@"                                            █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
                                            █▒┌────────────────────────────┐▒█
                                            █▒│ Combate               Ptos │▒█
                                            █▒│ ├─Ice Bolt.............1-2 │▒█
       ┌───────────────────────────┐        █▒│ ├─Frost Nova...........1-2 │▒█
       │ HAS DERROTADO AL ESPECTRO │        █▒│ ├─Glacial Spike........0-3 │▒█
       └───────────────────────────┘        █▒│ ├─Blizzard.............0-3 │▒█
                                            █▒│                            │▒█
                                            █▒│ Defensa               Ptos │▒█
                                            █▒│ ├─Frozen Armor...........1 │▒█
                                            █▒│                            │▒█
                                            █▒│ Restauración          Ptos │▒█
 ├─Ice Bolt        <1>├─Healing        <4>  █▒│ ├─Healing................2 │▒█
 ├─Frost Ring      <2>├─Frozen Armor   <5>  █▒│                            │▒█
 ├─Glacial Spike   <3>├─Blizzard       <6>  █▒└────────────────────────────┘▒█
                                            █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█");
                Console.WriteLine(" ─────────────── Alexander ───────────────  ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
                Console.WriteLine(" ╔═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╗  ──────────────────────────────────");
                Console.WriteLine(" ║" + strJugador[0] + "║" + strJugador[1] + "║" + strJugador[2] + "║" + strJugador[3] + "║" + strJugador[4] + "║" + strJugador[5] + "║" + strJugador[6] + "║" + strJugador[7] + "║" + strJugador[8] + "║" + strJugador[9] + "║" + strJugador[10] + "║" + strJugador[11] + "║" + strJugador[12] + "║" + strJugador[13] + "║" + strJugador[14] + "║" + strJugador[15] + "║" + strJugador[16] + "║" + strJugador[17] + "║" + strJugador[18] + "║" + strJugador[19] + "║  Videojuego creado por Andrés Danni");
                Console.WriteLine(" ╚═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╝  ──────────────────────────────────");
            }
            void Derrota()
            {
                Console.WriteLine(" ╔═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╗  ──┬────────────────────────────┬──");
                Console.WriteLine(" ║" + strHitPoint[0] + "║" + strHitPoint[1] + "║" + strHitPoint[2] + "║" + strHitPoint[3] + "║" + strHitPoint[4] + "║" + strHitPoint[5] + "║" + strHitPoint[6] + "║" + strHitPoint[7] + "║" + strHitPoint[8] + "║" + strHitPoint[9] + "║" + strHitPoint[10] + "║" + strHitPoint[11] + "║" + strHitPoint[12] + "║" + strHitPoint[13] + "║" + strHitPoint[14] + "║" + strHitPoint[15] + "║" + strHitPoint[16] + "║" + strHitPoint[17] + "║" + strHitPoint[18] + "║" + strHitPoint[19] + "║    │  Nigromantic Menace v1.00  │");
                Console.WriteLine(" ╚═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╝  ──┴────────────────────────────┴──");
                Console.WriteLine(" ──────────────── Enemigo ────────────────  ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
                Console.WriteLine(@"                                            █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
                   ████                     █▒┌────────────────────────────┐▒█
                 ████████                   █▒│ Combate               Ptos │▒█
                ██  ██  ██                  █▒│ ├─Ice Bolt.............1-2 │▒█
               ████████████                 █▒│ ├─Frost Nova...........1-2 │▒█
               ████████████                 █▒│ ├─Glacial Spike........0-3 │▒█
              ███ ▀ ▀ ▀  ███                █▒│ ├─Blizzard.............0-3 │▒█
              ███  ▄ ▄ ▄ ███                █▒│                            │▒█
              ██████████████                █▒│ Defensa               Ptos │▒█
              ██ ███  ███ ██                █▒│ ├─Frozen Armor...........1 │▒█
              █   ██  ██   █                █▒│                            │▒█
                                            █▒│ Restauración          Ptos │▒█
              ┌─────────────┐               █▒│ ├─Healing................2 │▒█
              │ HAS PERDIDO │               █▒│                            │▒█
              └─────────────┘               █▒└────────────────────────────┘▒█
                                            █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█");
                Console.WriteLine(" ─────────────── Alexander ───────────────  ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
                Console.WriteLine(" ╔═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╦═╗  ──────────────────────────────────");
                Console.WriteLine(" ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║ ║  Videojuego creado por Andrés Danni");
                Console.WriteLine(" ╚═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╩═╝  ──────────────────────────────────");
            }
            void Cargar()
            {
                Console.Clear();
                string[] strCarga = new string[] {
                    "█                                                                   │ │▒█",
                    "██                                                                  │ │▒█",
                    "███                                                                 │ │▒█",
                    "████                                                                │ │▒█",
                    "█████                                                               │ │▒█",
                    "██████                                                              │ │▒█",
                    "███████                                                             │ │▒█",
                    "████████                                                            │ │▒█",
                    "█████████                                                           │ │▒█",
                    "██████████                                                          │ │▒█",
                    "███████████                                                         │ │▒█",
                    "████████████                                                        │ │▒█",
                    "█████████████                                                       │ │▒█",
                    "██████████████                                                      │ │▒█",
                    "███████████████                                                     │ │▒█",
                    "████████████████                                                    │ │▒█",
                    "█████████████████                                                   │ │▒█",
                    "██████████████████                                                  │ │▒█",
                    "███████████████████                                                 │ │▒█",
                    "████████████████████                                                │ │▒█",
                    "█████████████████████                                               │ │▒█",
                    "██████████████████████                                              │ │▒█",
                    "███████████████████████                                             │ │▒█",
                    "████████████████████████                                            │ │▒█",
                    "█████████████████████████                                           │ │▒█",
                    "██████████████████████████                                          │ │▒█",
                    "███████████████████████████                                         │ │▒█",
                    "████████████████████████████                                        │ │▒█",
                    "█████████████████████████████                                       │ │▒█",
                    "██████████████████████████████                                      │ │▒█",
                    "███████████████████████████████                                     │ │▒█",
                    "████████████████████████████████                                    │ │▒█",
                    "█████████████████████████████████                                   │ │▒█",
                    "██████████████████████████████████                                  │ │▒█",
                    "███████████████████████████████████                                 │ │▒█",
                    "████████████████████████████████████                                │ │▒█",
                    "█████████████████████████████████████                               │ │▒█",
                    "██████████████████████████████████████                              │ │▒█",
                    "███████████████████████████████████████                             │ │▒█",
                    "████████████████████████████████████████                            │ │▒█",
                    "█████████████████████████████████████████                           │ │▒█",
                    "██████████████████████████████████████████                          │ │▒█",
                    "███████████████████████████████████████████                         │ │▒█",
                    "████████████████████████████████████████████                        │ │▒█",
                    "█████████████████████████████████████████████                       │ │▒█",
                    "██████████████████████████████████████████████                      │ │▒█",
                    "███████████████████████████████████████████████                     │ │▒█",
                    "████████████████████████████████████████████████                    │ │▒█",
                    "█████████████████████████████████████████████████                   │ │▒█",
                    "██████████████████████████████████████████████████                  │ │▒█",
                    "███████████████████████████████████████████████████                 │ │▒█",
                    "████████████████████████████████████████████████████                │ │▒█",
                    "█████████████████████████████████████████████████████               │ │▒█",
                    "██████████████████████████████████████████████████████              │ │▒█",
                    "███████████████████████████████████████████████████████             │ │▒█",
                    "████████████████████████████████████████████████████████            │ │▒█",
                    "█████████████████████████████████████████████████████████           │ │▒█",
                    "██████████████████████████████████████████████████████████          │ │▒█",
                    "███████████████████████████████████████████████████████████         │ │▒█",
                    "████████████████████████████████████████████████████████████        │ │▒█",
                    "█████████████████████████████████████████████████████████████       │ │▒█",
                    "██████████████████████████████████████████████████████████████      │ │▒█",
                    "███████████████████████████████████████████████████████████████     │ │▒█",
                    "████████████████████████████████████████████████████████████████    │ │▒█",
                    "█████████████████████████████████████████████████████████████████   │ │▒█",
                    "██████████████████████████████████████████████████████████████████  │ │▒█",
                    "███████████████████████████████████████████████████████████████████ │ │▒█"
                };
                for (int intY = 0; intY < strCarga.Length; intY++)
                {
                    Console.WriteLine(@" ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
 █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
 █▒┌────────────────────────────────────────────────────────────────────────┐▒█
 █▒│                        NIGROMANTIC MENACE v1.00                        │▒█
 █▒│                                                                        │▒█
 █▒│  Eres Alexander, un invocador de hechizos de magia elemental de Frío.  │▒█
 █▒│                                                                        │▒█
 █▒│  Días atrás estuviste explorando la Cripta de un antiguo Archimago y   │▒█
 █▒│     encontraste un pergamino que revela con detalle la Conjuración     │▒█
 █▒│                              Nigromántica.                             │▒█
 █▒│                                                                        │▒█
 █▒│          Has leído el documento y decidido hacer uso de él.            │▒█
 █▒│                                                                        │▒█
 █▒│ ¡Usa tus habilidades mágicas para acabar con tantos espectros puedas!  │▒█
 █▒│                                                                        │▒█
 █▒│                   <PRESIONA UNA TECLA PARA COMENZAR>                   │▒█
 █▒│                                                                        │▒█
 █▒│ ────────────────────────────────────────────────────────────────────── │▒█
 █▒│ ┌────────────────────────────────────────────────────────────────────┐ │▒█");
                    Console.Write(" █▒│ │"); Console.WriteLine(strCarga[intY]);
                    Console.WriteLine(@" █▒│ └────────────────────────────────────────────────────────────────────┘ │▒█
 █▒└────────────────────────────────────────────────────────────────────────┘▒█
 █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
                    System.Threading.Thread.Sleep(100);
                    Console.Clear();
                }
                Console.WriteLine(@" ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
 █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
 █▒┌────────────────────────────────────────────────────────────────────────┐▒█
 █▒│                        NIGROMANTIC MENACE v1.00                        │▒█
 █▒│                                                                        │▒█
 █▒│  Eres Alexander, un invocador de hechizos de magia elemental de Frío.  │▒█
 █▒│                                                                        │▒█
 █▒│  Días atrás estuviste explorando la Cripta de un antiguo Archimago y   │▒█
 █▒│     encontraste un pergamino que revela con detalle la Conjuración     │▒█
 █▒│                              Nigromántica.                             │▒█
 █▒│                                                                        │▒█
 █▒│          Has leído el documento y decidido hacer uso de él.            │▒█
 █▒│                                                                        │▒█
 █▒│ ¡Usa tus habilidades mágicas para acabar con tantos espectros puedas!  │▒█
 █▒│                                                                        │▒█
 █▒│                   <PRESIONA UNA TECLA PARA COMENZAR>                   │▒█
 █▒│                                                                        │▒█
 █▒│ ────────────────────────────────────────────────────────────────────── │▒█
 █▒│ ┌────────────────────────────────────────────────────────────────────┐ │▒█
 █▒│ │████████████████████████████████████████████████████████████████████│ │▒█
 █▒│ └────────────────────────────────────────────────────────────────────┘ │▒█
 █▒└────────────────────────────────────────────────────────────────────────┘▒█
 █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
                System.Threading.Thread.Sleep(500);
                Console.Clear();
            }
        }
    }
}
