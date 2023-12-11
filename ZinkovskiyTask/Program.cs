namespace ZinkovskiyTask;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("РОБОТА ЗIНКОВСЬКОГО IВАНА, ОНЛАЙН ГРУПА\n");
        try
        {
            Console.WriteLine("Маємо наступний трикутник: { { 0, 2 }, { 2, 0 } }\nРезультат:");
            double[,] triXIncorrect = { { 0, 2 }, { 2, 0 } }; // Координати вершин СЕ
            ShapeTriangle triFeIncorrect = new ShapeTriangle(triXIncorrect);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("\nМаємо наступний трикутник: { { 0, 2 }, { 2, 0 }, { 2, 2 } }\nРезультат:");
        double[,] triX = { { 0, 2 }, { 2, 0 }, { 2, 2 } }; // Координати вершин СЕ
        ShapeTriangle triFe = new ShapeTriangle(triX);
        triFe.Print();

        Console.WriteLine("\nМаємо наступний чотирикутник: { { 0, 0 }, { 2, 0 }, { 2, 2 }, { 0, 2 } } }\nРезультат:");
        double[,] quadX = { { 0, 0 }, { 2, 0 }, { 2, 2 }, { 0, 2 } }; // Координати вершин СЕ
        var quadFe = new ShapeQuadrangle(quadX);
        quadFe.Print();
        try
        {
            Console.WriteLine("\nМаємо наступний тетраедр: { { 0, 0 }, { 2, 0 }, { 2, 2 }, { 0, 2 } }\nРезультат:");
            double[,] tetrXIncorrect = { { 0, 0 }, { 2, 0 }, { 2, 2 }, { 0, 2 } }; // Координати вершин СЕ
            var tetrFeIncorrect = new ShapeTetrahedron(tetrXIncorrect);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("\nМаємо наступний тетраедр: { { 0, 0, 0 }, { 2, 0, 0 }, { 2, 2, 0 }, { 0, 2, 2 } }\nРезультат:");
        double[,] tetrX = { { 0, 0, 0 }, { 2, 0, 0 }, { 2, 2, 0 }, { 0, 2, 2 } }; // Координати вершин СЕ
        var tetrFe = new ShapeTetrahedron(tetrX);
        tetrFe.Print();

        Console.WriteLine("\nМаємо наступний куб: { { 0, 0, 0 }, { 2, 0, 0 }, { 2, 2, 0 }, { 0, 2, 2 }, { 2, 3, 6 }, { 3, 6, 4 }, { 4, 2, 0 }, { 5, 3, 1 } }\nРезультат:");
        double[,] cubX = { { 0, 0, 0 }, { 2, 0, 0 }, { 2, 2, 0 }, { 0, 2, 2 }, { 2, 3, 6 }, { 3, 6, 4 }, { 4, 2, 0 }, { 5, 3, 1 } }; // Координати вершин СЕ
        var cubFe = new ShapeCube(cubX);
        cubFe.Print();
    }
}

