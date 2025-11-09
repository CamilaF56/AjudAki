using Core;
using Core.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Service;

namespace AjudAkiAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "AjudAki API",
                    Version = "v1",
                    Description = "API do sistema AjudAki"
                });
            });

            // Registro das dependências
            builder.Services.AddScoped<IAgendaService, AgendaService>();
            builder.Services.AddScoped<IAreaAtuacaoService, AreaAtuacaoService>();
            builder.Services.AddScoped<IAssinaturaService, AssinaturaService>();
            builder.Services.AddScoped<IAvaliarService, AvaliarService>();
            builder.Services.AddScoped<IClienteService, ClienteService>();
            builder.Services.AddScoped<IContratacaoService, ContratacaoService>();
            builder.Services.AddScoped<IPagarAssinaturaService, PagarAssinaturaService>();
            builder.Services.AddScoped<IProfissionalService, ProfissionalService>();
            builder.Services.AddScoped<IServicoService, ServicoService>();
            builder.Services.AddScoped<ISolicitacaoServicoService, SolicitacaoServicoService>();
            builder.Services.AddScoped<ITipoServicoService, TipoServicoService>();

            // Configuração do AutoMapper
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            // Configuração do banco
            builder.Services.AddDbContext<AjudakiContext>(options =>
                options.UseMySQL(builder.Configuration.GetConnectionString("AjudakiDatabase")));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}
