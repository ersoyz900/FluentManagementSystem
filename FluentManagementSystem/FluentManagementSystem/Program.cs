using FluentManagementSystem.Client.Pages;
using FluentManagementSystem.Components;
using Microsoft.FluentUI.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using FluentManagementSystem.Models; // AppDbContext burada olduðu için burayý Models yaptýk

var builder = WebApplication.CreateBuilder(args);

// 1. JSON dosyasýndaki (appsettings.json) baðlantýyý oku
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// 2. Veritabaný Baðlantýsý (Ýsim hatasýný burada düzelttik: AppDbContext yaptýk)
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString));

// 3. Blazor Bileþen Servisleri
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

// 4. Fluent UI Servisleri
builder.Services.AddFluentUIComponents();

var app = builder.Build();

// 5. Pipeline Yapýlandýrmasý
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

// 6. Render Mode ve Assembly Tanýmlamalarý
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(FluentManagementSystem.Client._Imports).Assembly);

app.Run();