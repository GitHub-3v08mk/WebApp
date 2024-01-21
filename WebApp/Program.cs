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
app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/status/liveness", async context =>
    {
        context.Response.StatusCode = 200;
        await context.Response.WriteAsync("Liveness OK");
    });

    endpoints.MapGet("/status/readiness", async context =>
    {
        context.Response.StatusCode = 200;
        await context.Response.WriteAsync("Readiness OK");
    });

    endpoints.MapGet("/status/startup", async context =>
    {
        context.Response.StatusCode = 200;
        await context.Response.WriteAsync("Startup OK");
    });

});

app.Run();