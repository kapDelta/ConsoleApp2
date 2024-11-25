// See https://aka.ms/new-console-template for more information

Console.WriteLine("Выберите действие (введите  число): 1. Площадь круга; 2. Площадь прямоугольника; 3. Площадь треугольника");
double choice = Convert.ToDouble(Console.ReadLine());
if (choice == 1)
{
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("Введите радиус круга: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        double areacircle = Math.PI * (radius * 2);
        Console.WriteLine($"Площадь круга равна: {areacircle}");
        
}
else if(choice == 2)
{
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Введите длину: ");
        double length = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите ширину: ");
        double width = Convert.ToDouble(Console.ReadLine());
        double arearectangle = length * width;
        Console.WriteLine($"Площадь прямоугольника: {arearectangle}");
}
else if (choice == 3)
{
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Введите  основание: ");
        double osnov = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите  высоту: ");
        double height = Convert.ToDouble(Console.ReadLine());
        double areatriangle = (osnov * height) / 2;
        Console.WriteLine($"Площадь треугольника равна: {areatriangle}");
}

await Task.Delay(10000);


    