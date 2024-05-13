using System;
using WaterOverflow;

class Program
{
	static void Main()
	{
		int row = ReadInput("Rad");
		int glass = ReadInput("Glas");

		Pyramid pyramid = new Pyramid(row);
		double timeToOverflow = pyramid.CalculateTimeToOverflow(glass);
		PrintResult(timeToOverflow);

		Console.ReadLine(); // För att hålla konsolen öppen
	}

	static int ReadInput(string prompt)
	{
		Console.Write($"{prompt} ? ");
		return int.Parse(Console.ReadLine()!);
	}

	static void PrintResult(double timeToOverflow)
	{
		Console.WriteLine($"Det tar {timeToOverflow:F3} sekunder.");
	}
}
