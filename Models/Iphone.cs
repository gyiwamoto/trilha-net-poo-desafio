using System;

namespace DesafioPOO.Models
{
    
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Iphone(string numero, string imei, string modelo, int memoria) : base(numero, imei, modelo, memoria) {}

        public override void InstalarAplicativo(string Telegram)
        {
            Console.WriteLine($"Instalado Telegram no Iphone");
        }
        
    }
}