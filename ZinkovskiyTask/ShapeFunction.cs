namespace ZinkovskiyTask
{
    internal abstract class ShapeFunction
    {
        protected int Size; // Кількість коефіцієнтів функції форми
        protected int Dim; // Розмірність
        protected double[,] C; // Матриця коефіцієнтів
        protected double[,] X; // Координати вершин СЕ
        protected ShapeFunction()
        {
            Size = Dim = 0;
        }

        protected void CheckUserData(double [,] massive)
        {
            if (massive.GetUpperBound(0) + 1 != Size)
            {
                throw new IncorretDotsNumberException($"Невірне число точок! Має бути {Size} точок!");
            }
            if (massive.GetUpperBound(1) + 1 != Dim)
            {
                throw new IncorretDimensionsNumberException($"Невірна вимірність! Фігура знаходиться у {Dim}-вимірному просторі!");
            }
        }
        protected void SetCoord(int psize, double[,] px)
        {
            Size = psize;
            X = new double[Size, Dim];
            for (int i = 0; i < Size; i++)
                for (int j = 0; j < Dim; j++)
                {
                    X[i, j] = px[i, j];
                }
            Create();
        }
        protected abstract double ShapeCoeff(int i, int j);
        private bool Solve(double[,] matr, double[] result, double eps = 1.0E-10)
        {
            double coeff;
            for (var i = 0; i < Size - 1; i++)
            {
                if (matr[i, i] < eps)
                    continue;
                for (var j = i + 1; j < Size; j++)
                {
                    if (Math.Abs(coeff = matr[j, i]) < eps)
                        continue;
                    for (var k = i; k < Size + 1; k++)
                    {
                        matr[j, k] -= (coeff * matr[i, k] / matr[i, i]);
                    }
                }
            }
            if (Math.Abs(matr[Size - 1, Size - 1]) < eps)
                return false;
            result[Size - 1] = matr[Size - 1, Size] / matr[Size - 1, Size - 1];
            for (int k = 0; k < Size - 1; k++)
            {
                int i = Size - k - 2;
                var sum = matr[i, Size];

                for (int j = i + 1; j < Size; j++)
                    sum -= result[j] * matr[i, j];
                if (Math.Abs(matr[i, i]) < eps)
                    return false;
                result[i] = sum / matr[i, i];
            }
            return true;
        }
        public void Create()
        {
            double[,] A = new double[Size, Size + 1];
            double[] res = new double[Size];
            C = new double[Size, Size];
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    for (int k = 0; k < Size; k++)
                    {
                        A[j, k] = ShapeCoeff(j, k);
                    }
                    A[j, Size] = (i == j) ? 1.0 : 0.0;
                }
                if (!Solve(A, res))
                {
                    Console.WriteLine("Bad FE!");
                }
                for (int j = 0; j < Size; j++)
                {
                    C[i, j] = res[j];
                }
            }
        }
        public void Print()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Console.Write("{0} ", C[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
