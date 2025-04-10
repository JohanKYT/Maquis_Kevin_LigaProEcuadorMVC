namespace Maquis_Kevin_LigaProEcuadorMVC.Models
{
    public class Equipo
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int PartidosJugados { get; set; }
        public int PartidosGanados { get; set; }
        public int PartidosEmpatados { get; set; }
        public int PartidosPerdidos { get; set; }
        public int Puntos { get; set; }

    }
}
