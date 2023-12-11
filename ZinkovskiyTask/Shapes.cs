namespace ZinkovskiyTask
{
    // Функції форми трикутного елемента
    class ShapeTriangle : ShapeFunction
    {
        public ShapeTriangle(double[,] px)
        {
            Size = 3;
            Dim = 2;
            CheckUserData(px);
            SetCoord(Size, px);
        }
        protected override double ShapeCoeff(int i, int j)
        {
            double[] s = { 1.0, X[i, 0], X[i, 1] };
            return s[j];
        }
    }
    // Функції форми чотирикутного елемента
    class ShapeQuadrangle : ShapeFunction
    {
        public ShapeQuadrangle(double[,] px)
        {
            Size = 4;
            Dim = 2;
            CheckUserData(px);
            SetCoord(Size, px);
        }
        protected override double ShapeCoeff(int i, int j)
        {
            double[] s = { 1.0, X[i, 0], X[i, 1], X[i, 0] * X[i, 1] };
            return s[j];
        }
    }
    // Функції форми тетраедра
    class ShapeTetrahedron : ShapeFunction
    {
        public ShapeTetrahedron(double[,] px)
        {
            Size = 4;
            Dim = 3;
            CheckUserData(px);
            SetCoord(Size, px);
        }
        protected override double ShapeCoeff(int i, int j)
        {
            double[] s = { 1.0, X[i, 0], X[i, 1], X[i, 2] };
            return s[j];
        }
    }
    // Функції форми куба
    class ShapeCube : ShapeFunction
    {
        public ShapeCube(double[,] px)
        {
            Size = 8;
            Dim = 3;
            CheckUserData(px);
            SetCoord(Size, px);
        }
        protected override double ShapeCoeff(int i, int j)
        {
            double[] s = { 1.0, X[i, 0], X[i, 1], X[i, 2], X[i, 0] * X[i, 1], X[i, 1] * X[i, 2], X[i, 2] * X[i, 0], X[i, 0] * X[i, 1] * X[i, 2] };
            return s[j];
        }
    }
}
