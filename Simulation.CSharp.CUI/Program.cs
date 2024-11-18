Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Hello and welcome to the Simulation!\n");

(int w, int h) = GetWorldDimentions();
Console.WriteLine($"Width = {w}; Height = {h}");

Simulation.CSharp.Domain.Simulation.Simulation simulation = new();

(int, int) GetWorldDimentions()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Enter the field parameters:");

    while (true)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;

        try
        {
            Console.Write("Height => ");
            int height = int.Parse(Console.ReadLine());

            Console.Write("Width => ");
            int width = int.Parse(Console.ReadLine());

            return (width, height);
        }
        catch (ArgumentNullException e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(e.Message);
            Console.WriteLine("Try again, nothing was entered");
        }
        catch (FormatException e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(e.Message);
            Console.WriteLine("Try again, not int was entered");
        }
        catch (Exception e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(e.Message);
        }
    }
}
