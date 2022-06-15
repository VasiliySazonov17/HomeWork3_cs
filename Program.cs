//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27.
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Input length row: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] row =new int[10];

for (int i=0; i<length; i++)
{
    row[i] = (i+1)*(i+1)*(i+1);
    Console.Write($"({i+1})^3 = {row[i]}");
    if (i+1 < length)
    {
      Console.Write(", ");  
    }
    else if (i+1 == length)
    {
    Console.Write(". "); 
    }
    
}

