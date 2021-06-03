using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model.Models;

namespace TeduShop.Data
{
    public class TeduShopDbContext:DbContext
    {
        public TeduShopDbContext():base("TeduShopConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Footer> Footers { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<MenuGroup> MenuGroups { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Page> Page { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<PostTag> PostTag { get; set; }
        public DbSet<PostCategory> PostCategory { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<ProductTag> ProductTag { get; set; }
        public DbSet<Slide> Slide { get; set; }
        public DbSet<SupportOnline> SupportOnline { get; set; }
        public DbSet<SystemConfig> SystemConfig { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<VisitorStatistic> VisitorStatistic { get; set; }
        protected override void OnModelCreating(DbModelBuilder builder)
        {
        }
    }
}
