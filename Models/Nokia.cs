using System;

namespace DesafioPOO.Models
{
        // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Nokia(string numero, string imei, string modelo, int memoria) : base(numero, imei, modelo, memoria){}
       
        public override void InstalarAplicativo(string WhatsApp)
        {
            Console.WriteLine($"Instalado Whatsapp no Nokia");
        }
                
    }
}