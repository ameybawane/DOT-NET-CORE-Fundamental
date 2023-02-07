var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

app.UseRouting();

//app.UseEndpoints((x) =>
//{
//    x.MapDefaultControllerRoute();
//});

app.UseEndpoints((x) =>
{
    x.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=AboutUs}/{id?}");
    //controller=Home no need to provide sufix its by default given by compiler
});

// app.MapGet("/", () => "Hello World!");

app.Run();
