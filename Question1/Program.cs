using System;

class Program
{
    static void Main()
    {
        // Get registration number from user
        Console.Write("Enter your registration number (e.g., BCS-023): ");
        string regNo = Console.ReadLine();

        // Extract last two digits
        string lastTwoDigits = regNo.Substring(regNo.Length - 2);

        // Take x and y inputs
        Console.Write("Enter value for x: ");
        string userX = Console.ReadLine();

        Console.Write("Enter value for y: ");
        string userY = Console.ReadLine();

        // Fixed value for z
        string userZ = "4";

        // Build the input string
        string input = $"x:{userX}; y:{userY}; z:{userZ}; result: x * y + z;";

        // Extract values from string
        int xWithID = ExtractValue(input, "x"); // This simulates x23, x45 etc. based on ID
        int y = ExtractValue(input, "y");
        int z = ExtractValue(input, "z");

        // Perform calculation: x * y + z
        int result = xWithID * y + z;

        // Display values
        Console.WriteLine($"\nx{lastTwoDigits} = {xWithID}");
        Console.WriteLine($"y = {y}");
        Console.WriteLine($"z = {z}");
        Console.WriteLine($"Result = {result}");
    }

    static int ExtractValue(string input, string variable)
    {
        string[] parts = input.Split(';');
        foreach (string part in parts)
        {
            string trimmed = part.Trim();
            if (trimmed.StartsWith(variable + ":"))
            {
                string valuePart = trimmed.Substring(variable.Length + 1).Trim();
                if (int.TryParse(valuePart, out int value))
                {
                    return value;
                }
            }
        }
        return 0;
    }
}
