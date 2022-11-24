// See https://aka.ms/new-console-template for more information
int[] numeri = { 12, 23, 34, 56, 12 };
StampaArrayInteri(numeri);

//-------FUNZIONI
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