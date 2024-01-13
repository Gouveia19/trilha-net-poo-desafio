namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo {get; set; }
        public string  Imei {get; set; }
        public int Memoria {get; set;  }
        // Implementado!

        public Smartphone(string numero)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria; 
            // Implementado!!!!
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