namespace DesafioPOO.Models
{
    // IMPLEMENTADO !!
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, string memoria) : base(numero, modelo, imei, memoria)
        {
        }
    // IMPLEMENTADO !!
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando aplicativo {0} no Nokia", nomeApp);
        }
    }
}
