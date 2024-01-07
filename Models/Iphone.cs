namespace DesafioPOO.Models
{
    // IMPLEMENTADO !!
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, string memoria) : base(numero, modelo, imei, memoria)
        {
        }
    // IMPLEMENTADO !!
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando aplicativo {0} no iPhone", nomeApp);
        }
    }
}
