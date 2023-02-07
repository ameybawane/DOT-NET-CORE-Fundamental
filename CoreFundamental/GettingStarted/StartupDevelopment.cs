namespace GettingStarted
{
    public class StartupDevelopment
    {
        public void ConfigureServices(IServiceCollection services)
        {

        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //app.UseRouting();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!");
            //    });
            //});

            //app.Use(async (httpcontext1, httpcontext2) =>
            //{
            //    await httpcontext1.Response.WriteAsync("from use-middleware");
            //});

            app.UseStatusCodePages();

            // app.UseRouting();

            // app.Map()
            // run before App.Use
            // to rune change the path from http://localhost:5111 to http://localhost:5111/user
            app.Map("/user", (IApplicationBuilder app) =>
            {
                app.Run((HttpContext) => HttpContext.Response.WriteAsync("from Map-Middleware."));
            });

            //app.Use(async (httpcontext1, httpcontext2) =>
            //{
            //    await httpcontext1.Response.WriteAsync("from Use-MiddleWare." + Environment.NewLine);
            //    await httpcontext2.Invoke();
            //});

            app.Use(async (httpcontext, next) =>
            {
                await httpcontext.Response.WriteAsync("from Use-MiddleWare 1." 
                    + Environment.NewLine);
                await next();
                await httpcontext.Response.WriteAsync("from Use-MiddleWare 1 after next()." 
                    + Environment.NewLine);
            });
            app.Use(async (httpcontext, next) =>
            {
                await httpcontext.Response.WriteAsync("from Use-MiddleWare 2." 
                    + Environment.NewLine);
                await next();
                await httpcontext.Response.WriteAsync("from Use-MiddleWare 2 after next()." 
                    + Environment.NewLine);
            });
            app.Use(async (httpcontext, httpcontextInv) =>
            {
                await httpcontext.Response.WriteAsync("from Use-MiddleWare 3." 
                    + Environment.NewLine);
                await httpcontextInv.Invoke();
            });

            app.Run((HttpContext) => HttpContext.Response.WriteAsync("from Run-Middleware 1." 
                + Environment.NewLine));
            app.Run((HttpContext) => HttpContext.Response.WriteAsync("from Run-Middleware 2." 
                + Environment.NewLine));
            
        }
    }
}
