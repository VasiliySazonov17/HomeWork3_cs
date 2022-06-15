//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//23432 -> да
//12821 -> да

Console.Write("Input number: ");

string number = Console.ReadLine();
int length = number.Length;
int count = 0;

for (int i = 0; i < length/2; i++)
    {
        if(number[i] == number[length-1-i])
        {   
            
            count++;
            Console.WriteLine("+");
            continue;
        }
        else
        {
            Console.WriteLine("This number is not a palindrome");
            break;
        }
        
    }
if (count == length/2)
{
    Console.WriteLine("This is a palindrome number");
}

