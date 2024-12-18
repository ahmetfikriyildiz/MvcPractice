var builder = WebApplication.CreateBuilder(args);

// MVC servislerini ekliyoruz
builder.Services.AddControllersWithViews();

var app = builder.Build();

// wwwroot klasöründeki statik dosyaları kullanabilmek için gerekli middleware
app.UseStaticFiles();

// Routing yapılandırması
app.UseRouting();

// Varsayılan route ayarları
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=CustomerOrders}/{action=Index}/{id?}");

// Uygulamayı çalıştır
app.Run();
