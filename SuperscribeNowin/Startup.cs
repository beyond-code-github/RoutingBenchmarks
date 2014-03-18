namespace SuperscribeNowin
{
    using Owin;

    using Superscribe;
    using Superscribe.Models;
    using Superscribe.Owin;
    using Superscribe.Owin.Extensions;

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new SuperscribeOwinConfig();

            config.MediaTypeHandlers.Add(
                "text/html",
                new MediaTypeHandler { Write = (env, o) => env.WriteResponse(o.ToString()) });

            app.UseSuperscribeRouter(config).UseSuperscribeHandler(config);

            Define.Route(
                "Hello" / (String)"Name" / (Int)"Age",
                o => string.Format("Hello {0}, Age {1}", o.Parameters.Name, o.Parameters.Age));
            
            Define.Route("/", o => "Hello World");
        }
    }

}
