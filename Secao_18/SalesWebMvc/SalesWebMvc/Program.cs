using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SalesWebMvc.Data;
using SalesWebMvc.Services;

var builder = WebApplication.CreateBuilder(args);

// 1️ Configura o DbContext
builder.Services.AddDbContext<SalesWebMvcContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("SalesWebMvcContext"),
        new MySqlServerVersion(new Version(8, 0, 44)) // ou a versão do seu MySQL
    )
);

// 2️ Adiciona os serviço de seeding e SellerService ao container
builder.Services.AddScoped<SeedingService>();
builder.Services.AddScoped<SellerService>();

// 3️ Adiciona os serviços MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// 4️ Executa o seeding APENAS em ambiente de desenvolvimento
if (app.Environment.IsDevelopment())
{
    using (var scope = app.Services.CreateScope())
    {
        var services = scope.ServiceProvider;

        try
        {
            var seedingService = services.GetRequiredService<SeedingService>();
            Console.WriteLine(" Executando seeding do banco de dados...");
            seedingService.Seed();
            Console.WriteLine(" Seeding concluído com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($" Erro ao executar o seeding: {ex.Message}");
        }
    }
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// 5️ Configuração padrão do pipeline HTTP
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
