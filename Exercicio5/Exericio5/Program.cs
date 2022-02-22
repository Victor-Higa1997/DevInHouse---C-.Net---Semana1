
int[] array = new int[10];
int cont = 0;


do
{
    Console.WriteLine("Digite um numero: ");
    array[cont] = Convert.ToInt16(Console.ReadLine());
    cont++;

} while (cont < 10);


int tamanho = array.Length;

for (int i = tamanho - 1; i >= 1; i--)
{
	for (int j = 0; j < i; j++)
	{
		if (array[j] > array[j + 1])
		{
			int aux = array[j];
			array[j] = array[j + 1];
			array[j + 1] = aux;
			
		}
	}
}
Array.Reverse(array);

string ordenacaoInvertida = "";
for (int i = 0; i < array.Length; i++)
{
	ordenacaoInvertida += $"{array[i]} ";
	
}
Console.WriteLine(ordenacaoInvertida);