/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/


void Distance(int ax, int bx, int ay, int by, int az, int bz)
{
    double distance = Math.Sqrt(Math.Pow(ax-bx, 2) + Math.Pow(ay-by, 2) + Math.Pow(az-bz, 2));
    double correction = (Math.Round(distance, 2) - Math.Round(distance, 0,MidpointRounding.ToZero))*100; 
    Console.WriteLine($"A ({ax},{ay},{az}); B ({bx},{by},{bz}) -> {Math.Round(distance, 0 ,MidpointRounding.ToZero)}.{Math.Round(correction, 0,MidpointRounding.ToEven)}");
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int ax = GetInput("Введите координату X точки A: ");
int ay = GetInput("Введите координату Y точки A: ");
int az = GetInput("Введите координату Z точки A: ");
int bx = GetInput("Введите координату X точки B: ");
int by = GetInput("Введите координату Y точки B: ");
int bz = GetInput("Введите координату Z точки B: ");
Distance(ax,bx,ay,by,az,bz);