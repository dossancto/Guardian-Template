using Arq.DependencyInjection;
using Arq.UI.Controllers.Middlewares.ErrorHandlers;

var builder = WebApplication.CreateBuilder(args);

builder.Services
       .AddDefaultApplicationConfiguration(builder.Environment.IsDevelopment());

builder.Services.AddControllers();

builder.Services
    .AddEndpointsApiExplorer()
    .AddSwaggerGen(c =>
    {
        c.CustomSchemaIds(type => type.ToString());

        var assemblies = new List<string>() { "Arq.UI", "Arq.Application" };

        var baseDir = System.AppContext.BaseDirectory;

        foreach (var ass in assemblies)
        {
            var path = Path.Combine(System.AppContext.BaseDirectory, $"{ass}.xml");

            c.IncludeXmlComments(path);
        }
    });

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    app.UseReDoc(options =>
    {
        options.DocumentTitle = "Endpoints documentation";
        options.SpecUrl = "/swagger/v1/swagger.json";
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.AddErrorHandlers(app.Environment);

app.Run();
