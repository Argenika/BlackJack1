using System.Xml.Serialization;

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


while(true){
  string carta = CogerCarta();
  manoJugador.Add(carta);
}









}




}
