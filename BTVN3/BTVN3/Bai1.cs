namespace BTVN3;

public class Bai1
{
    public int width;
    public int height;
    public int sideLength;

    public Bai1(int width, int height, int sideLength)
    {
        this.width = width;
        this.height = height;
        this.sideLength = sideLength;
    }
    
    public  void DrawRectangle(int width, int height)
    {
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (i == 0 || i == height - 1 || j == 0 || j == width - 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }
    }

    // Hàm vẽ hình tam giác cân rỗng
    public  void DrawTriangle(int sideLength)
    {
        for (int i = 0; i < sideLength; i++)
        {
            for (int j = 0; j < 2 * sideLength - 1; j++)
            {
                // Điều kiện vẽ cạnh bên hoặc cạnh đáy của tam giác
                if (j == sideLength - 1 - i || j == sideLength - 1 + i || i == sideLength - 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }
    }
}