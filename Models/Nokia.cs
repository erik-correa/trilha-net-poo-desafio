namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(int numero, string modelo, int imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando o App " + nomeApp + " no Nokia.");
        }
    }
}