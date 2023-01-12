namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public int Numero { get; set; }
        private string Modelo { get; set; }
        private int Imei { get; set; }
        private int Memoria { get; set; }
     
        protected Smartphone(int numero, string modelo, int imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

      
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}