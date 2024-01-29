namespace DesafioPOO.Models
{
    
  public class Nokia : Smartphone
  {
    private const int MaxMemoriaGB = 64;

    public Nokia(string numero, string modelo, string imei, string memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

    public override void InstalarAplicativo(string nomeApp, string memoria)
    {
      if (string.IsNullOrEmpty(nomeApp))
         {
          Console.WriteLine("Nome do aplicativo inválido. A instalação foi cancelada.");
            return;
         }

      if (!ValidarTamanhoMemoria(memoria))
        {
          Console.WriteLine($"Não é possível instalar {nomeApp}. Tamanho da memória maior que {MaxMemoriaGB}GB.");
          return;
        }

          Console.WriteLine($"Instalando {nomeApp} no Nokia...");
    }

    private bool ValidarTamanhoMemoria(string memoria)
    {
        string digitos = new string(memoria.Where(char.IsDigit).ToArray());

        if (int.TryParse(digitos, out int memoriaGB))
        {
            return memoriaGB >= 0 && memoriaGB <= MaxMemoriaGB;
        }
        else
        {
            Console.WriteLine($"Formato inválido para o tamanho da memória: {memoria}. Certifique-se de fornecer um número inteiro.");
            return false;
        }
    }
  }
}