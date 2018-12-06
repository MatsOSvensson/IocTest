using Interfaces;

namespace IocFactory
{
    public interface IQuotFactory
    {
        IQuotService GetQuotService();
    }
}