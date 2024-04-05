using examen_unidad2_backend;

var builder = WebApplication.CreateBuilder(args);

//hay que extraer del metodo constructor
var startup = new Startup(builder.Configuration);

startup.ConfigureServices(builder.Services);

var app = builder.Build();

startup.Configure(app, builder.Environment);

app.Run();