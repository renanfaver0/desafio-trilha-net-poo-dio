namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    // Feito
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        // Feito
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando aplicativo Tinder no Smartphone Nokia...Aguarde!");
        }
    }
}