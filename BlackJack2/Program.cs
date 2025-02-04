
class Program {
    static Random random = new Random(); 
    static List<string> baraja = new List<string>();
    static Dictionary<string,int>cartasValor = new Dictionary<string, int>();



static void Main ()
{
   InicioBaraja();
    List<string> manoJugador = new List<string>();
    List<string> manoBanca = new List<string>();
    int puntuacionJugador = 0, puntuacionBanca = 0;

    Console.WriteLine("Bienvenido al Blackjack!");




while(true)
{
  string carta = CogerCarta();
  manoJugador.Add(carta);
  puntuacionJugador= CalcularPuntuacion(manoJugador);
Console.WriteLine($"Carta recibida: {carta}");
Console.WriteLine($"Puntuación actual: {puntuacionJugador}");


   if (puntuacionJugador > 21)
            {
                Console.WriteLine("¡Te has pasado de 21! Pierdes.");
                return;
            }


Console.Write("¿Quieres otra carta? (s/n): ");
    if (Console.ReadLine().ToLower() != "s")
        break; // El jugador se planta, termina el turno.
}


// Turno de la banca
        Console.WriteLine("Turno de la banca...");
 puntuacionBanca = CalcularPuntuacion(manoBanca);
while (puntuacionBanca < 17)
        {
string carta = CogerCarta();
 manoBanca.Add(carta);
 puntuacionBanca = CalcularPuntuacion(manoBanca);
Console.WriteLine($"Carta recibida: {carta}");
        }
      
Console.WriteLine($"Puntuación final de la banca: {puntuacionBanca}");




//El ganador es 
if(puntuacionBanca>21|| puntuacionJugador>puntuacionBanca)
{
Console.WriteLine("Has ganado.");
}
else if(puntuacionBanca == puntuacionJugador)
{
  Console.WriteLine("Empate.");
}
else
Console.WriteLine("La banca gana.");

}

  static void InicioBaraja()
  {
    string[] palos = { "Corazones", "Tréboles", "Picas", "Diamantes" };
    string[] figuras = { "J", "Q", "K" };

 foreach (string palo in palos)
        {
            for (int i = 1; i <= 10; i++)
            {
                baraja.Add(i + " de " + palo);
                cartasValor[i + " de " + palo] = i;
            }
foreach (string figura in figuras)
            {
                baraja.Add(figura + " de " + palo);
                cartasValor[figura + " de " + palo] = 10;
            }
  }


}

 static string CogerCarta()
    {
        if (baraja.Count == 0)
            throw new InvalidOperationException("No quedan cartas en la baraja");

        int indice = random.Next(baraja.Count);
        string carta = baraja[indice];
        baraja.RemoveAt(indice);
        return carta;
    }

    static int CalcularPuntuacion(List<string> mano)
    {
        return mano.Sum(carta => cartasValor[carta]);
    }
}

