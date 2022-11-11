using PuppeteerSharp;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapPost("/generatepdf", async (string url) =>
{
    await new BrowserFetcher().DownloadAsync(BrowserFetcher.DefaultChromiumRevision.ToString()); 
    var browser = await Puppeteer.LaunchAsync(new LaunchOptions
    {
        Headless = true
    });
    var page = await browser.NewPageAsync();
    await page.GoToAsync(url); // your url may not be the same as this!    
    await page.WaitForSelectorAsync("#myChart"); // wait until the chart is rendered
    await page.PdfAsync($"{Guid.NewGuid()}.pdf");
})
.WithName("GeneratePdf");

app.Run();