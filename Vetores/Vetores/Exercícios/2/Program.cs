

Console.Write("Digite uma palavra: ");
string palavra = Console.ReadLine();

int qtdeletras = palavra.Length;
int[] Array = new int[qtdeletras];
int[] invertida = new int[qtdeletras];
int palindromo = 1;

for (int i = 0; i < qtdeletras; i++)
{
    Array[i] = (int)palavra[i];
}

for (int i = 0; i < qtdeletras; i++)
{
    invertida[i] = Array[qtdeletras - 1 - i];
}

for (int i = 0; i < qtdeletras; i++)
{
    if (Array[i] != invertida[i])
    {
        palindromo = 0;
    }
}

if (palindromo == 1)
{
    Console.WriteLine("É um palíndromo");
}
else
{
    Console.WriteLine("Não é um palíndromo");
}