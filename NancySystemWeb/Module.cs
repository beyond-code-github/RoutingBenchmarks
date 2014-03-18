namespace NancySystemWeb
{
    using Nancy;

    public class Module : NancyModule
    {
        public Module()
        {
            this.Get["/"] = _ => "Hello World";

            this.Get["Hello/{name}/{age}"] = o => string.Format("Hello {0}, Age {1}", o.Name, o.Age);
        }
    }
}
