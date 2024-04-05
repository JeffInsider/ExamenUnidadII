using examen_unidad2_backend.Database;
using examen_unidad2_backend.Services;
using examen_unidad2_backend.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace examen_unidad2_backend
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {

            Configuration = configuration;

        }

        //para muchas colecciones
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            //Add DbContext
            //para que sepa que base de datos va a usar
            services.AddDbContext<PacientesDbContext>(options =>
                //es variable lo que hace es acceder a la configuracion de la base de datos appsettings.json
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            //add custom services
            services.AddTransient<IPacientesService, PacientesService>();

            //add automapper service
            services.AddAutoMapper(typeof(Startup));

            //darle permisos a la api para que pueda ser consumida por el frontend
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                {
                    builder.WithOrigins(Configuration["FrontendURL"])
                    .AllowAnyHeader()
                    .AllowAnyMethod();
                });
            });

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // esto es como una tuberia de middleware
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            //para rutas mas rapidas
            app.UseRouting();

            //para que sepa que va a usar cors
            app.UseCors();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
