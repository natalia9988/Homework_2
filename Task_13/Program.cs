// Задача 13: 
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число ");
int N = int.Parse(Console.ReadLine()!);
int ThirdDigit;

if (N<100)
{
Console.Write ("Нет третьей цифры");
}
    
if (N>=100 && N<=999)
{ 
ThirdDigit = N%10;
Console.Write($"Третье число {ThirdDigit}");
}
       
while (N>999)
 {
    { 
     N=N/10;
 }
 
 {ThirdDigit = N%10;

 Console.Write($"Третье число {ThirdDigit}");
 }
 }
  


        
    



    

    




