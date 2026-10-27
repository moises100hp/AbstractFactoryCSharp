namespace AbstractFactory.Product
{
    internal class WindowsCheckbox : ICheckbox
    {
        public void Paint()
        {
            Console.WriteLine("Drawing checkbox in Windowss O.S");
        }
    }
}
