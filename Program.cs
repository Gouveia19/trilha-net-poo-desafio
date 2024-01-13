using DesafioPOO.Models;

class Program
{
    // Implementado!!!!
    
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "190608", modelo: "Modelo 123", imei: "170291981", memoria: 32gb);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");
        
Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "250832", modelo: "Iphone 14", imei: "939236483", memoria: 256gb);
iphone.ReceberLigacao();
iphone.InstalarAplicativo(Facebook);
    
}