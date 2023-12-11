namespace ZinkovskiyTask
{
    internal class IncorretDotsNumberException : Exception
    {
        public IncorretDotsNumberException(string message)
            : base(message) { }
    }
    internal class IncorretDimensionsNumberException : Exception
    {
        public IncorretDimensionsNumberException(string message)
            : base(message) { }
    }
}