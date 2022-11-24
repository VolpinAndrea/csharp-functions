/*In questo esercizio vi chiedo di definire qualche funzione di utilità che poi potete usare per poter fare operazioni complesse nei vostri programmi principali.
Scrivete nel vostro programma principale Program.cs le seguenti funzioni di base:
Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione! Vi ricordate perchè? Pensateci (vedi slide)
Una volta completate queste funzioni di utilità di base, e dato il seguente array di numeri [2, 6, 7, 5, 3, 9] già dichiarato nel vostro codice, si vogliono utilizzare le funzioni per:
Stampare l’array di numeri fornito a video
Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato (Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente l’array originale e verificare che sia rimasto [2, 6, 7, 5, 3, 9])
Stampare la somma di tutti i numeri
Stampare la somma di tutti i numeri elevati al quadrati*/

int[] numeri = { 2, 6, 7, 5, 3, 9};
StampaArrayInteri(numeri);
StampaArrayInteri(ElevaArrayAlQuadrato(numeri));
StampaArrayInteri(numeri);
Console.WriteLine(sommaElementiArray(numeri));
Console.WriteLine(sommaElementiArray(ElevaArrayAlQuadrato(numeri)));

//-------FUNZIONI------------------------------------------------

/*void StampaArrayInteri(int[] array): che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]”. Potete prendere quella fatta in classe questa mattina*/
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
//int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.
int Quadrato(int numero)
{
    return numero * numero;
}
/*int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato.*/
int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] copia = (int[])array.Clone(); 

    for (int i = 0; i < copia.Length; i++)
    {
        copia[i] = Quadrato(copia[i]);
    }
    return copia;

}
/*int sommaElementiArray(int[] array): che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.*/
int sommaElementiArray(int[] array)
{
    int somma = 0;

    /*for (int i = 0; i <= array.Length; i++)
    {
        somma += array[i];
    }*/

    foreach(int elemento in array)
    {
        somma += elemento;
    }

    return somma;
}
