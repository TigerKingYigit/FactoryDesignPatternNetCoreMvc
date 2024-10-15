using FactoryDesignPattern.Models.Abstract;

namespace FactoryDesignPattern.Models.Concrete
{
    public class ProductB : BaseProduct
    {
        public override string Name { get; set; }
        public override int Quantity { get; set; }
        public override decimal Price { get; set; }
    }
}
