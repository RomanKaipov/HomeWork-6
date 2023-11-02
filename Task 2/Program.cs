// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double ReadInt(string msg)
{
    Console.WriteLine(msg);
    string a = Console.ReadLine();
    double number;
    number = double.Parse(a);
    return number;
}

double[] Line(int numberLine)
{
    double[] line = new double[2];
    line[0] = ReadInt($"Введите значение k{numberLine}");
    line[1] = ReadInt($"Введите значение b{numberLine}");
    return line;
}

double[] FindCoord(double[] lineOne, double[] lineTwo)
{
    double[] coord = new double[2];
    coord[0] = (lineOne[1] - lineTwo[1]) / (lineTwo[0] - lineOne[0]);
    coord[1] = lineOne[0]*coord[0]+lineOne[1];
    return coord;
}

bool CheckLine(double[] lineOne, double[] lineTwo)
{
    if (lineTwo[0] == lineOne[0])
    {
        if (lineTwo[1] == lineOne[1])
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;
}



double[] lineOne = Line(1);
double[] lineTwo = Line(2);

if (CheckLine(lineOne,lineTwo))
{
double[] coord = FindCoord(lineOne,lineTwo);
Console.WriteLine($"Координата пересечения равна ({coord[0]},{coord[1]})");
}