using FactoryDesignPattern.Models.Abstract;

namespace FactoryDesignPattern.Services.Abstract
{
    public interface IProductFactory
    {
        BaseProduct CreateOptionalProduct();
    }
}
