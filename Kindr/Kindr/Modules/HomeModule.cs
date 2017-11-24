using Nancy;
namespace Kindr.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule() : base("/")
        {
            Get["/"] = x => GetHome();
        }

        public dynamic GetHome()
        {
            return this.View["Home"];
        }
    }
}