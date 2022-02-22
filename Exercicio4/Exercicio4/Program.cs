int[] valores = new int[7];
int cont = 0;
int menorValor = 0;
do
{
    Console.WriteLine("Digite um valor: ");
    valores[cont] = Convert.ToInt32(Console.ReadLine());
    cont++;
} while (cont < 7);

menorValor = valores[0];

for (int i = 0; i < valores.Length; i++)
{ 
    if (valores[i] < menorValor)
    {
        menorValor = valores[i];
    }
    
}

Console.WriteLine($"O menor valor é: {menorValor}");