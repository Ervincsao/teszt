using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BakelitShopApi.Models;

namespace BakelitShopApi.Data
{
    public class BakelitShopApiContext : DbContext
    {
        public BakelitShopApiContext (DbContextOptions<BakelitShopApiContext> options)
            : base(options)
        {
        }

        public DbSet<BakelitShopApi.Models.Bakelit> Bakelits { get; set; } = default!;
        public DbSet<BakelitShopApi.Models.Order> Order { get; set; } = default!;
        public DbSet<BakelitShopApi.Models.User> User { get; set; } = default!;
    }
}
