

Console.WriteLine("Digite o primeiro valor: ");
var valor1 = Console.ReadLine();

Console.WriteLine("Digite o segundo valor: ");
var valor2 = Console.ReadLine();

Console.WriteLine("Digite o terceiro valor: ");
var valor3 = Console.ReadLine();

if (Convert.ToInt32(valor1) + Convert.ToInt32(valor2) > Convert.ToInt32(valor3))
{
    if ((Convert.ToInt32(valor1) == Convert.ToInt32(valor2)) && (Convert.ToInt32(valor1) == Convert.ToInt32(valor3)))
    {
        Console.WriteLine("O valor passado representa uma Triângulo Equilátero");
    }
    if ((Convert.ToInt32(valor1) == Convert.ToInt32(valor2)) || (Convert.ToInt32(valor2) == Convert.ToInt32(valor3)) ||
        (Convert.ToInt32(valor1) == Convert.ToInt32(valor3)))
    {
        Console.WriteLine("O valor passado representa uma Triângulo Isósceles");
    }
    if ((Convert.ToInt32(valor1) != Convert.ToInt32(valor2)) && (Convert.ToInt32(valor2) != Convert.ToInt32(valor3)) &&
        (Convert.ToInt32(valor1) != Convert.ToInt32(valor3)))
    {
        Console.WriteLine("O valor passado representa uma Triângulo Escaleno");
    }
}
