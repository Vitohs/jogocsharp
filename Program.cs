using System.Runtime;
string controle = "";
Random chave = new Random();
var chance = 10;
var numero = chave.Next(1,100);
var digitado = 0;

Console.WriteLine("Bem vindo ao jogo de adivinhe, quer jogar ? s/n");
controle = Console.ReadLine();
if (controle == "s")
{
    do
    {
        Console.WriteLine($"selecione o numero, voce tem {chance} chances restante");
        digitado = Convert.ToInt32(Console.ReadLine());
        
        if (digitado < numero)
        {
            Console.Clear();
            Console.WriteLine("numero esta em um valor maior");
            chance--;
        }
        if (digitado > numero)
        {
            Console.Clear();
            Console.WriteLine("numero esta em um valor menor");
            chance--;
        }
        if (digitado == numero)
        {
            Console.Clear();
            Console.WriteLine("Parabens voce acertou");
            break;
        }
        if (chance == 0)
        {
            Console.WriteLine($"perdeu pae, o numero era {numero}");
            break;
        }
    }
    while (true);
}
else
{
    Console.WriteLine("tchau");
}
Console.ReadKey();