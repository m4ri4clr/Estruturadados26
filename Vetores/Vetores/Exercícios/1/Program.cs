int [] Array = new int[10];
int [] par = new int[10];
int [] impar = new int [10];
int numpares = 0;
int numimpares = 0;


for (int i = 0; i < Array.Length; i++)
{
    Console.Write($"Digite o valor para [{i}]: ");
    Array[i] = Convert.ToInt32(Console.ReadLine());

    if (Array[i] % 2 == 0)
    {
        par[numpares] = Array[i];
        numpares++;
    }
    else
    {
        impar[numimpares] = Array[i];
        numimpares++;
    }
}

Console.WriteLine("Os números pares são:");
for (int i = 0; i < numpares; i++)
    Console.Write(par[i] + " ");

Console.WriteLine("\nOs números impares são:");
for (int i = 0; i < numimpares; i++)
    Console.Write(impar[i] + " ");
