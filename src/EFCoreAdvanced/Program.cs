using System;
using System.Threading.Tasks;
using EFCoreAdvanced.Data;

namespace EFCoreAdvanced
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            await EnsureCreated();
            Console.ReadKey();
        }

        private static async Task EnsureCreated()
        {
            await using var db = new ApplicationContext();
            await db.Database.EnsureCreatedAsync();
        }

        private static async Task EnsureDeleted()
        {
            await using var db = new ApplicationContext();
            await db.Database.EnsureDeletedAsync();
        }
    }
}
