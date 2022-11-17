var builder = WebApplication.CreateBuilder(args);
var x = 0; //The first commit that works 
//Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();
//test 12
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    //test1234
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Rn();
