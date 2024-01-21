// Add services to the container.
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
var app = builder.Build();


app.UseExceptionHandler("/Error");
//app.UseHsts();
//app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.UseStaticFiles();
app.MapRazorPages();

//Add paths for probes
app.MapGet("/status/liveness", async context =>
{
    context.Response.StatusCode = 200;
    await context.Response.WriteAsync("Liveness OK");
});

app.MapGet("/status/readiness", async context =>
{
    context.Response.StatusCode = 200;
    await context.Response.WriteAsync("Readiness OK");
});

app.MapGet("/status/startup", async context =>
{
    context.Response.StatusCode = 200;
    await context.Response.WriteAsync("Startup OK");
});

app.MapRazorPages();

app.Run();