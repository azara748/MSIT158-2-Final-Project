var builder = WebApplication.CreateBuilder(args);

/*
Scaffold-DbContext   "Data Source=.;Initial Catalog=SelectShop;Integrated Security=True;Encrypt=True;Trust Server Certificate=True" Microsoft.EntityFrameworkCore.SqlServer      -OutputDir       Models -force
*///更新模型(複製上面整行)

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSession();
//新增Session
var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseSession();
//啟用Session
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
