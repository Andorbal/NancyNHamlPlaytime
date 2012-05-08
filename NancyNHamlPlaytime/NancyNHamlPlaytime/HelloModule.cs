using Nancy;

namespace NancyNHamlPlaytime
{
    public class HelloModule : NancyModule
    {
        public HelloModule()
        {
            Get["/"] = parameters => "Hello World";
            Get["/nhaml"] = p => View["sample"];
        }
    }
}