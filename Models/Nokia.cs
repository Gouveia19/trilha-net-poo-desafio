namespace DesafioPOO.Models
{
    // Implementado!!!
    public class Nokia : Smartphone
    {
        // Implementado!!!!!
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)

        

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalanddo o aplicativo '{nomeApp}' no Nokia.");
        }
    }
}