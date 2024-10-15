using FactoryDesignPattern.Models.Abstract;
using FactoryDesignPattern.Models.Concrete;
using FactoryDesignPattern.Services.Abstract;

namespace FactoryDesignPattern.Services.Concrete
{
    public class ProductFactoryB : IProductFactory
    {
        public BaseProduct CreateOptionalProduct()
        {
            return new ProductB();
        }

     
    }
}
