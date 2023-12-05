using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        Nokia nokia = new Nokia("224432445", "Nokia Modelo", "123452789012345", "64GB");
        Iphone iphone = new Iphone("184664321", "iPhone Modelo", "927654321098765", "128GB");

        // Testando métodos
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}