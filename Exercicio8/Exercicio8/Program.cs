using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using System.Web.Helpers;

string path = @"C:\Users\victor\Desktop\C# + .NET\KANBAN - 1°SEMANA\DevInHouse---C-.Net---Semana1\Exercicio8\arquivo.json";

using (StreamReader sr = File.OpenText(path))
{
    string s;

    while ((s = sr.ReadLine()) != null)
    {
        Console.WriteLine(s);
        object JsonConvert = null;
        
    }


    List<Example> ex = JsonConvert.DeserializeObject<List<Example>>(sr);

    foreach (Example item in ex)
    {
        Console.WriteLine("Produto id: {0}", item.id);
        Console.WriteLine("Produto nome: {0}", item.nome);
        Console.WriteLine("Produto descrição: {0}", item.descricao);
        Console.WriteLine("Produto Preço: {0}", item.preco);
        Console.WriteLine("Produto Foto: {0}", item.foto);
        //Ler Opções extras
        if (item.opcoesExtras.Count > 0)
        {
            foreach (OpcoesExtra o in item.opcoesExtras)
            {
                Console.WriteLine(" - OpcoesExtra id: {0}", o.id);
                Console.WriteLine(" - OpcoesExtra nome: {0}", o.nome);
                Console.WriteLine(" - OpcoesExtra Maximo Extras: {0}", o.maximoExtras);
                if (o.itens.Count > 0)
                {
                    foreach (Iten i in o.itens)
                    {
                        Console.WriteLine(" - - item id: {0}", i.id);
                        Console.WriteLine(" - - item Valor: {0}", i.valor);
                        Console.WriteLine(" - - item nome: {0}", i.nome);
                    }
                }

            }
        }

        Console.WriteLine("-----------------------------------------------------------------------------");
    }
}
        
        //Classes aqui 
        public class Iten
{
    public int id { get; set; }
    public string nome { get; set; }
    public int valor { get; set; }
}

public class OpcoesExtra
{
    public int id { get; set; }
    public string nome { get; set; }
    public int calculoTipo { get; set; }
    public int maximoExtras { get; set; }
    public IList<Iten> itens { get; set; }
}

public class Categoria
{
    public int id { get; set; }
    public string nome { get; set; }
    public IList<object> produtos { get; set; }
}

public class Example
{
    public int id { get; set; }
    public string nome { get; set; }
    public string descricao { get; set; }
    public bool disponivel { get; set; }
    public double preco { get; set; }
    public string foto { get; set; }
    public IList<OpcoesExtra> opcoesExtras { get; set; }
    public int categoriaId { get; set; }
    public Categoria categoria { get; set; }
}
    
