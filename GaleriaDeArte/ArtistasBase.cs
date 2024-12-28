namespace GaleriaDeArte
{
    internal class ArtistasBase
    {
        private int id;
        private string seudonimo;
        private string autor;
        public int Id { get => id; set => id = value; }

        protected string Seudonimo { get => seudonimo; set => seudonimo = value; }
        protected string Autor { get => autor; set => autor = value; }


    }
}