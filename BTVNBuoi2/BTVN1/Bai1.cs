using System;

class Bai1
{
    static void Main()
    {
        // Part a
        double tA = 2.125;
        double xA_initial = 9 * Math.Cos((5 * Math.PI * 0) + Math.PI / 2); 
        double xA_final = 9 * Math.Cos((5 * Math.PI * tA) + Math.PI / 2);   


        double distanceA = Math.Abs(xA_final - xA_initial);
        Console.WriteLine("Khoảng cách câu a là : " + distanceA + " cm");

        
        double a = 5; 
        double b = 3; 
        double tB = 2.0; 

        double xB_initial = a * Math.Cos((b * 0) + Math.PI / 2);
        double xB_final = a * Math.Cos((b * tB) + Math.PI / 2);
        
        double distanceB = Math.Abs(xB_final - xB_initial);
        Console.WriteLine("Khoảng cách câu b là : " + tB + " seconds: " + distanceB + " cm");
    }
}