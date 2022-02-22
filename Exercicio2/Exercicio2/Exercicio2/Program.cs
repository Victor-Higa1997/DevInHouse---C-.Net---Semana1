
Console.WriteLine("Digite a temperatura em celsius: ");

var temp = Console.ReadLine();
double conversao = Convert.ToDouble(temp) * 1.8 + 32;

Console.WriteLine($"Sua temperatura convertida para fahrenheit é: {conversao}");

