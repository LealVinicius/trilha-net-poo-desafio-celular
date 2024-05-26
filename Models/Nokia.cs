namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero) : base(numero)
        {
            
        }

        public Nokia (string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo '{nomeApp}' no NOKIA...");
            System.Threading.Thread.Sleep(5000);//Simula o tempo de instalação, nokia é demorado
            Console.WriteLine($"O Aplicativo '{nomeApp}' foi instalado com sucesso no NOKIA");
        } 
        

        
    }
}