using System;

class Program
{
    static void Main()
    {
        // Get registration number from user
        Console.Write("Enter your registration number (e.g., BCS-023): ");
        string regNo = Console.ReadLine();

        if (regNo.Length < 2 || !char.IsDigit(regNo[regNo.Length - 1]) || !char.IsDigit(regNo[regNo.Length - 2]))
        {
            Console.WriteLine("Invalid registration number format. Last two characters must be digits.");
            return;
        }

        // Extract second last and last digits
        char secondLastChar = regNo[regNo.Length - 2];
        char lastChar = regNo[regNo.Length - 1];

        int x = int.Parse(secondLastChar.ToString());
        int y = int.Parse(lastChar.ToString());

        // Take z from user
        Console.Write("Enter value for z: ");
        string userZ = Console.ReadLine();

        if (!int.TryParse(userZ, out int z))
        {
            Console.WriteLine("Invalid input for z. Must be a number.");
            return;
        }

        // Build the input string (for demonstration)
        string input = $"x:{x}; y:{y}; z:{z}; result: x * y + z;";

        // Perform calculation: x * y + z
        int result = x * y + z;

        // Display values
        Console.WriteLine($"\nx = {x} (from second last digit: {secondLastChar})");
        Console.WriteLine($"y = {y} (from last digit: {lastChar})");
        Console.WriteLine($"z = {z}");
        Console.WriteLine($"Result = {result}");
    }
}
