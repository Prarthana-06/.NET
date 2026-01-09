var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.Use(async(httpcxt,next) =>
{
   
    await next();
    Console.WriteLine("Hello from first ");

});
app.Use(async(httpcxt, next) =>
{
    await next();
    Console.WriteLine("Hello from second ");
});
app.Use(async(httpcxt, next) =>
{
    await next();
    Console.WriteLine("Hello from third ");
});
app.MapGet("/", () => "Hello world");
app.Run();