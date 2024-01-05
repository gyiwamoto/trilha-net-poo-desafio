using System;
namespace DesafioPOO.Models
{
    public abstract class Smartphone
    
    {
        public string Numero { get; set; }
       
        private string modelo;
        private string imei;
        private int memoria;

        public Smartphone(string numero, string imei, string modelo, int memoria)
        {
            this.Numero = numero;
            this.imei = imei;
            this.modelo = modelo;
            this.memoria = memoria;
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