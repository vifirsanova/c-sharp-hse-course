using System;

class Program
{
    static void Main(string[] args)
    {
        string name = "Cube";
        float x = 10.5f, y = 5.2f, z = 0.0f;
        float scale = 1.0f;
        float rotation = 45.0f;
        bool isVisible = true;

        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Position: ({x}, {y}, {z})");
        Console.WriteLine($"Scale: {scale}");
        Console.WriteLine($"Rotation: {rotation}");
        Console.WriteLine($"Visible: {isVisible}");
    }
}
