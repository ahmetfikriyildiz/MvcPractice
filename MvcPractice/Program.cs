var builder = WebApplication.CreateBuilder(args);

// MVC servislerini ekliyoruz
builder.Services.AddControllersWithViews();

var app = builder.Build();

// wwwroot klasöründeki statik dosyalarý kullanabilmek için gerekli middleware
app.UseStaticFiles();

// Routing yapýlandýrmasý
app.UseRouting();

// Varsayýlan route ayarlarý
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=CustomerOrders}/{action=Index}/{id?}");

// Uygulamayý çalýþtýr
app.Run();
