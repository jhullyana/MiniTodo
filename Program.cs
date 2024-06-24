using MiniTodo.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>();

var app = builder.Build();

app.MapGet("v1/ToDos", (AppDbContext context) => {
    var ToDos = context.ToDos.ToList();
    return Results.Ok(ToDos);
});

app.Run();
