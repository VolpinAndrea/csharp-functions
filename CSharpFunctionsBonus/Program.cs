// See https://aka.ms/new-console-template for more information
/*BONUS:
Convertire le funzioni appena dichiarate in funzioni generiche, ossia funzioni che possono lavorare con array di numeri interi di lunghezza variabile, ossia debbono poter funzionare sia che gli passi array di 5 elementi, sia di 6, di 7, di ... e così via. A questo punto modificare il programma in modo che chieda all’utente quanti numeri voglia inserire, e dopo di che questi vengono inseriti a mano dall’utente esternamente. Rieseguire il programma con l’input preso esternamente dall’utente.*/

Console.WriteLine("Di che dimensione vuoi fare l'array?");
int dimensione = int.Parse(Console.ReadLine());
int[] numeri = new int[dimensione];

for (int i = 0;i < numeri.Length; i++)
{
    Console.WriteLine("inserisci il "+ (i+1) + " elemento dell'array");
    int elemento = int.Parse(Console.ReadLine());
    numeri[i] = elemento;   
}
Console.WriteLine("ARRAY INIZIALE:");
StampaArrayInteri(numeri);
Console.WriteLine("ARRAY AL QUADRATO:");
StampaArrayInteri(ElevaArrayAlQuadrato(numeri));
Console.WriteLine("ARRAY INIZIALE INVARIATO:");
StampaArrayInteri(numeri);
Console.WriteLine("SOMMA ELEMENTI ARRAY INIZIALE:");
Console.WriteLine(sommaElementiArray(numeri));
Console.WriteLine("SOMMA ELEMENTI ARRAY AL QUADRATO:");
Console.WriteLine(sommaElementiArray(ElevaArrayAlQuadrato(numeri)));

//-------FUNZIONI------------------------------------------------

void StampaArrayInteri(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write(array[i]);
        }
        else
        {
            Console.Write(array[i] + ",");
        }
    }

    Console.WriteLine("]");
}
int Quadrato(int numero)
{
    return numero * numero;
}
int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] copia = (int[])array.Clone();

    for (int i = 0; i < copia.Length; i++)
    {
        copia[i] = Quadrato(copia[i]);
    }
    return copia;

}
int sommaElementiArray(int[] array)
{
    int somma = 0;

    foreach (int elemento in array)
    {
        somma += elemento;
    }

    return somma;
}

