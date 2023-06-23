using ConsoleCacheRedisCedex;
using ConsoleCacheRedisCedex.Models;

Console.WriteLine("Productos Favoritos");
ServiceCacheRedis service = new ServiceCacheRedis();
List<Producto> productos = await service.GetProductosFavoritosAsync();
if (productos == null)
{
    Console.WriteLine("No hay favoritos");
}
else
{
    foreach (Producto prod in productos)
    {
        Console.WriteLine(prod.Nombre);
    }
}
Console.WriteLine("Fin de programa");
