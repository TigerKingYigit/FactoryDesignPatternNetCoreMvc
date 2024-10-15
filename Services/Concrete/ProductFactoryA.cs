using FactoryDesignPattern.Models.Abstract;
using FactoryDesignPattern.Models.Concrete;
using FactoryDesignPattern.Services.Abstract;

namespace FactoryDesignPattern.Services.Concrete
{
    public class ProductFactoryA : IProductFactory
    {
        public BaseProduct CreateOptionalProduct()
        {
            return new ProductA();
        }
    }
}
