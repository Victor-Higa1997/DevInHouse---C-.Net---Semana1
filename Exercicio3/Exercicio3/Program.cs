

int[] valores = new int[5];
int cont = 0;
int maiorValor = 0;
do
{
    Console.WriteLine("Digite um valor: ");
    valores[cont] = Convert.ToInt32(Console.ReadLine());
    cont++;
} while (cont < 5);

for (int i = 0; i < valores.Length; i++)
{
    if (valores[i] > maiorValor)
    {
        maiorValor = valores[i];
    }
}

Console.WriteLine($"O maior valor é: {maiorValor}");