using AbstractFactory.Product;

namespace AbstractFactory.Factory
{
    internal class MacFactory : IGUIFactory
    {
        public IButton createButton()
        {
            return new MacButton();
        }

        public ICheckbox createCheckbox()
        {
            return new MacCheckbox();
        }
    }
}
