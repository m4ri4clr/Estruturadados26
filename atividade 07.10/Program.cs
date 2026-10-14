using System;
using System.Collections.Generic;

Dictionary<string, Automovel> automoveis = new Dictionary<string, Automovel>();
int opcao = 0;

do
{
    Console.WriteLine();
    Console.WriteLine("SISTEMA DE CONTROLE DE AUTOMÓVEIS");
    Console.WriteLine("1 - Cadastrar automóvel");
    Console.WriteLine("2 - Buscar automóvel pela placa");
    Console.WriteLine("3 - Listar todos os automóveis");
    Console.WriteLine("4 - Buscar automóveis por marca");
    Console.WriteLine("5 - Sair");
    Console.Write("Escolha uma opção: ");
    int.TryParse(Console.ReadLine(), out opcao);
    Console.WriteLine();

    if (opcao == 1)
    {
        Console.Write("Placa: ");
        string placa = Console.ReadLine().ToUpper();

        if (automoveis.ContainsKey(placa))
        {
            Console.WriteLine("Essa placa já está cadastrada!");
        }
        else
        {
            Automovel carro = new Automovel();
            carro.Placa = placa;

            Console.Write("Marca: ");
            carro.Marca = Console.ReadLine();
            Console.Write("Modelo: ");
            carro.Modelo = Console.ReadLine();
            Console.Write("Ano: ");
            int.TryParse(Console.ReadLine(), out int ano);
            carro.Ano = ano;
            Console.Write("Cor: ");
            carro.Cor = Console.ReadLine();
            Console.Write("Valor: ");
            double.TryParse(Console.ReadLine(), out double valor);
            carro.Valor = valor;

            automoveis.Add(placa, carro);
            Console.WriteLine("Automóvel cadastrado!");
        }
    }
    else if (opcao == 2)
    {
        Console.Write("Digite a placa: ");
        string placa = Console.ReadLine().ToUpper();

        if (automoveis.TryGetValue(placa, out Automovel carro))
        {
            carro.Mostrar();
        }
        else
        {
            Console.WriteLine("Automóvel não encontrado.");
        }
    }
    else if (opcao == 3)
    {
        if (automoveis.Count == 0)
        {
            Console.WriteLine("Nenhum automóvel cadastrado.");
        }
        else
        {
            foreach (KeyValuePair<string, Automovel> item in automoveis)
            {
                item.Value.Mostrar();
                Console.WriteLine();
            }
        }
    }
    else if (opcao == 4)
    {
        Console.Write("Digite a marca: ");
        string marca = Console.ReadLine().ToUpper();
        int achou = 0;

        foreach (KeyValuePair<string, Automovel> item in automoveis)
        {
            if (item.Value.Marca.ToUpper() == marca)
            {
                item.Value.Mostrar();
                Console.WriteLine();
                achou++;
            }
        }

        if (achou == 0)
        {
            Console.WriteLine("Nenhum automóvel dessa marca.");
        }
    }
    else if (opcao == 5)
    {
        Console.WriteLine("Programa encerrado.");
    }
    else
    {
        Console.WriteLine("Opção inválida!");
    }
}
while (opcao != 5);

public class Automovel
{
    public string Placa { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public string Cor { get; set; }
    public double Valor { get; set; }

    public void Mostrar()
    {
        Console.WriteLine($"Placa: {Placa}");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Cor: {Cor}");
        Console.WriteLine($"Valor: R$ {Valor}");
    }
}