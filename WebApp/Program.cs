using Microsoft.AspNetCore.Mvc.Formatters;
using System.Net.Mime;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", (HttpContext context) => "Hello World!");

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();


//void WriteHtml(HttpContext context,  string html)
//{
//    context.Response.ContentType = MediaTypeNames.Text.Html;
//    context.Response.ContentLength = Encoding.UTF8.GetByteCount(html);
//    context.Response.WriteAsync(html);
//}