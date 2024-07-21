using Randomizer.Services;
namespace Randomizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IHomeServices homeServices = new HomeServices();
            homeServices.LoadExistedMenus();
        }
    }
}
