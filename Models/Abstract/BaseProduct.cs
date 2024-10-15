namespace FactoryDesignPattern.Models.Abstract
{
    public abstract class BaseProduct
    {
        public abstract string Name { get; set; }
        public abstract int Quantity{ get; set; }
        public abstract decimal Price{ get; set; }
    }
}
