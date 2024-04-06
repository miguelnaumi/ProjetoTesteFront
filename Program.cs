using System.Configuration;
using TesteProjetoFront.Models;
using TesteProjetoFront.Repositories;
using TesteProjetoFront.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddHttpClient();

// Injeção de dependência

builder.Services.Configure<ApiSettings>(builder.Configuration.GetSection("ApiSettings"));

builder.Services.AddScoped<IAlunoRepository, AlunoRepository>();
builder.Services.AddScoped<IAlunoService, AlunoService>();
builder.Services.AddScoped<ICursoRepository, CursoRepository>();
builder.Services.AddScoped<ICursoService, CursoService>();
builder.Services.AddScoped<ITurmaRepository, TurmaRepository>();
builder.Services.AddScoped<ITurmaService, TurmaService>();
builder.Services.AddScoped<IAlunoTurmaRepository, AlunoTurmaRepository>();
builder.Services.AddScoped<IAlunoTurmaService, AlunoTurmaService>();


//builder.Services.AddScoped<IRelacionarRepository, RelacionarRepository>();
//builder.Services.AddScoped<IRelacionarService, RelacionarService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "aluno",
        pattern: "Aluno/{action=Index}/{id?}",
        defaults: new { controller = "Aluno" });

    endpoints.MapControllerRoute(
        name: "turma",
        pattern: "Turma/{action=Index}/{id?}",
        defaults: new { controller = "Turma" });

    endpoints.MapControllerRoute(
        name: "curso",
        pattern: "Curso/{action=Index}/{id?}",
        defaults: new { controller = "Curso" });

    endpoints.MapControllerRoute(
        name: "relacionar",
        pattern: "Relacionar/{action=Index}/{id?}",
        defaults: new { controller = "Relacionar" });

    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

    endpoints.MapRazorPages();
});

app.Run();
