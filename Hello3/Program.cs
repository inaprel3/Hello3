using Hello3.Calc;
using Hello3.Time;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<ICalcService, CalcService>();
builder.Services.AddTransient<ITimeService, TimeService>();
var app = builder.Build();

app.Use(async (context, next) => {
    context.Response.ContentType = "text/plain; charset=utf-8";
    await next();
});

app.MapGet("/", async context => {
    var calcService = app.Services.GetService<ICalcService>();
    var timeService = app.Services.GetService<ITimeService>();
    DateTime dateTime = DateTime.Now;
    await context.Response.WriteAsync($"\nПоточний час доби: {timeService?.GetTimeDay(dateTime)}\n");
    await context.Response.WriteAsync($"\nРезультат додавання: {calcService?.Addition(1, 2, 3, 4, 5)}\n" +
$"\nРезультат віднімання: {calcService?.Subtraction(1, 2, 3, 4, 5)}\n" +
$"\nРезультат множення: {calcService?.Multiplication(1f, 2f, 3f, 4f, 5f)}\n" +
$"\nРезультат ділення: {calcService?.Division(1.0, 2.0, 3.0, 4.0, 5.0)}\n");
});

app.Run();
