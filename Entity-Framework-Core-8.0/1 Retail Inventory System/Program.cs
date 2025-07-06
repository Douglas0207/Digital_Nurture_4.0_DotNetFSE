using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Retail_Inventory_System.Data;
using Retail_Inventory_System.Models;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        services.AddDbContext<AppDbContext>();
        services.AddScoped<IProductRepository, ProductRepository>();
    })
    .Build();

using (var scope = host.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var repo = services.GetRequiredService<IProductRepository>();

    var category = new Category { CategoryName = "Electronics" };
    var context = services.GetRequiredService<AppDbContext>();
    context.Categories.Add(category);
    context.SaveChanges();

    var product = new Product
    {
        Name = "Headphones",
        Quantity = 50,
        CategoryId = category.CategoryId
    };
    repo.AddProduct(product);

    foreach (var p in repo.GetAllProducts())
    {
        Console.WriteLine($"{p.Name} ({p.Category.CategoryName}) - Quantity: {p.Quantity}");
    }
}
