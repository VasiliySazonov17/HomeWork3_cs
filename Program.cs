//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Point A - Input the x coordinate: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Point A - Input the y coordinate: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Point A - Input the z coordinate: ");
int zA = Convert.ToInt32(Console.ReadLine());
Console.Write("Point B - Input the x coordinate: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Point B - Input the y coordinate: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Point B - Input the z coordinate: ");
int zB = Convert.ToInt32(Console.ReadLine());


double result = Math.Sqrt((zA-zB)*(zA-zB)+((xA-xB)*(xA-xB)+(yA-yB)*(yA-yB)));

Console.Write($"Length AB = {result} mm");

