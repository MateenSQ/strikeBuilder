using MongoDB.Driver;
using MongoDB.Bson;
using System.Diagnostics;
using StrikeBuilderMVC.Repository;

var builder = WebApplication.CreateBuilder(args);


// ======================
// || MongoDB Connection
// ======================

builder.Services.AddSingleton<IMongoClient>(sp =>
{
    const string ConnectionUri = "mongodb+srv://defaultUser:test123@cluster0.gp76y.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0";

    var settings = MongoClientSettings.FromConnectionString(ConnectionUri);

    // Set the ServerApi field of the settings object to set the version of the Stable API on the client
    settings.ServerApi = new ServerApi(ServerApiVersion.V1);

    // Create a new client and connect to the server
    return new MongoClient(settings);
});

builder.Services.AddScoped<IMongoRepository, MongoRepository>();


//const string ConnectionUri = "mongodb+srv://defaultUser:test123@cluster0.gp76y.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0";

//var settings = MongoClientSettings.FromConnectionString(ConnectionUri);

//// Set the ServerApi field of the settings object to set the version of the Stable API on the client
//settings.ServerApi = new ServerApi(ServerApiVersion.V1);

//// Create a new client and connect to the server
//var client = new MongoClient(settings);

//// Send a ping to confirm a successful connection
//try
//{
//    var result = client.GetDatabase("admin").RunCommand<BsonDocument>(new BsonDocument("ping", 1));
//    Debug.WriteLine("Pinged your deployment. You successfully connected to MongoDB!");
//}
//catch (Exception ex)
//{
//    Debug.WriteLine(ex);
//}


// ======================


builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = "DefaultCookie";
})
    .AddCookie("DefaultCookie");

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
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
