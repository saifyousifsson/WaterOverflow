class WaterOverflow
{
	static void Main()
	{
		int row = ReadInput("Rad");
		int glass = ReadInput("Glas");

		double timeToOverflow = CalculateTimeToOverflow(row, glass);
		PrintResult(timeToOverflow);

		Console.ReadLine(); // För att hålla konsolen öppen
	}

	static int ReadInput(string prompt)
	{
		Console.Write($"{prompt} ? ");
		return int.Parse(Console.ReadLine()!);
	}

	static double CalculateTimeToOverflow(int row, int glass)
	{
		// Beräkna det totala antalet glas i pyramidens nedersta rad
		int totalGlasses = (row * (row + 1)) / 2;

		// Beräkna vattenmängden i det angivna glaset när det börjar rinna över
		double waterInGlass = 10.0 * (glass - 1);
		double levelInGlass = waterInGlass + 5.0 * (row - 1); // Totalt vatten i glaset

		// Beräkna tidpunkten när glaset börjar rinna över
		double timeToOverflow = (levelInGlass - 2.6667) / 2.0 * 10.0; // Formel för tid

		return timeToOverflow;
	}

	static void PrintResult(double timeToOverflow)
	{
		Console.WriteLine($"Det tar {timeToOverflow:F3} sekunder.");
	}
}
