var builder = WebApplication.CreateBuilder(args);



/* req/res pipeline */
var app = builder.Build();


//app.MapGet("/", () => "<html>Hello World!</html>");


app.Run(async context =>
{
    context.Response.ContentType = "text/html; charset=utf-8";
    context.Response.StatusCode = 200;
    await context.Response.WriteAsync("<!DOCTYPE html>");
    await context.Response.WriteAsync("<html>");
    await context.Response.WriteAsync("<head>");
    await context.Response.WriteAsync("<title>HTTP Context</title>");
    await context.Response.WriteAsync("</head>");
    await context.Response.WriteAsync("<body><h1>Kestrel</h1></body>");
    await context.Response.WriteAsync("</html>");

});


/* listening on a port */
app.Run();
