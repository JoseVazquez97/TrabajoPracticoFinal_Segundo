using WebApi_SingalR_Com.Hubs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

//AGREGAMOS SIGNAL R
builder.Services.AddSignalR();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

//Luego tenemos que agregar la ruta a la que van a venir los clientes a consultar los datos.
//app.MapHub<HomeHub>("/Hubs/HomeHub.cs");
app.MapHub<EjemploHub>("/Hubs/EjemploHub.cs");
app.MapHub<HomeHub>("/Hubs/HomeHub.cs");

app.Run();
