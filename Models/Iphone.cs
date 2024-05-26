namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero) : base(numero)
        {

        }

        public Iphone (string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo '{nomeApp}' no iPhone...");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine($"O aplicativo '{nomeApp}' foi instalado no iPhone com sucesso.");
        }
    }
}