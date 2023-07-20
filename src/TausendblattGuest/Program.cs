

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IAppDataSingleton, AppDataSingleton>();
builder.Services.AddTransient<IAppDataTransient, AppDataTransient>();
builder.Services.AddScoped<IAppDataScoped, AppDataScoped>();
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


// app.Urls.Add($"https://*:{56744}");
app.Urls.Add($"http://*:{56745}");


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
        var appData = serviceProvider.GetRequiredService<IAppDataSingleton>();
        appData.Host = host;
    }
    catch { }
}
