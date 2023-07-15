// s3zktiq0czlhyeng.myfritz.net
// https://freeicons.io/

// https://www.iconfinder.com

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IAppData, AppData>();
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

AddBlazorise(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    // app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");


// app.Urls.Add($"https://*:{61005}");
app.Urls.Add($"http://*:{61006}");
// app.Urls.Add($"https://*:{61007}");
app.Urls.Add($"http://*:{61008}");


AddAppData(app);

app.Run();


void AddBlazorise(IServiceCollection services)
{
    services
        .AddBlazorise();
    services
        .AddBootstrap5Providers()
        .AddFontAwesomeIcons();
}

void AddAppData(IHost host)
{
    using var serviceScope = host.Services.CreateScope();
    var serviceProvider = serviceScope.ServiceProvider;
    try
    {
        var appData = serviceProvider.GetRequiredService<IAppData>();
        appData.Host = host;
    }
    catch { }
}
