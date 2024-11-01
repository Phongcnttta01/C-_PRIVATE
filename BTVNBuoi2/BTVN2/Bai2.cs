using System;

class Bai2
{
    static void Main()
    {
        // Given values
        double v0 = 20.0; // Initial velocity in m/s
        double theta = 30.0; // Launch angle in degrees
        double g = 9.8; // Gravitational acceleration in m/s^2

        // Convert angle to radians
        double thetaRad = theta * (Math.PI / 180);

        // Part a: Calculate the velocity components
        double v0x = v0 * Math.Cos(thetaRad);
        double v0y = v0 * Math.Sin(thetaRad);
        Console.WriteLine("Câu a : " + v0x + " m/s");
        Console.WriteLine("Câu a : " + v0y + " m/s");

        // Part b: Calculate the time to reach maximum height
        double tMaxHeight = v0y / g;
        Console.WriteLine("Câu b : " + tMaxHeight + " seconds");

        // Part c: Calculate the maximum height reached
        double maxHeight = (v0y * v0y) / (2 * g);
        Console.WriteLine("Câu c : " + maxHeight + " meters");

        // Part d: Calculate the horizontal range
        double totalTime = 2 * tMaxHeight;
        double horizontalRange = v0x * totalTime;
        Console.WriteLine("Câu d : " + horizontalRange + " meters");
    }
}