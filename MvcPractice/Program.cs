var builder = WebApplication.CreateBuilder(args);

// MVC servislerini ekliyoruz
builder.Services.AddControllersWithViews();

var app = builder.Build();

// wwwroot klas�r�ndeki statik dosyalar� kullanabilmek i�in gerekli middleware
app.UseStaticFiles();

// Routing yap�land�rmas�
app.UseRouting();

// Varsay�lan route ayarlar�
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=CustomerOrders}/{action=Index}/{id?}");

// Uygulamay� �al��t�r
app.Run();
