using MYAcademy_AirbnbProject.Settings.MongoDbSettings;
var builder = WebApplication.CreateBuilder(args);

// MongoDB Ayarları
//using MYAcademy_AirbnbProject.Settings;

//builder.Services.Configure<MongoDbSettings>(
//    builder.Configuration.GetSection("MongoDbSettings"));

//// MongoDB Client
//builder.Services.AddSingleton<IMongoClient>(sp =>
//{
//    var connectionString = builder.Configuration
//        .GetValue<string>("MongoDbSettings:ConnectionString");

//    return new MongoClient(connectionString);
//});

//// MongoDB Database
//builder.Services.AddSingleton<IMongoDatabase>(sp =>
//{
//    var client = sp.GetRequiredService<IMongoClient>();

//    var databaseName = builder.Configuration
//        .GetValue<string>("MongoDbSettings:DatabaseName");

//    return client.GetDatabase(databaseName);
//});


// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
