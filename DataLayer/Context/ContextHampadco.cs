using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Design;
using DataLayer.AdminEntities.Address;
using DataLayer.AdminEntities.Agency;
using DataLayer.AdminEntities.Blog;
using DataLayer.AdminEntities.Category;
using DataLayer.AdminEntities.Comment;
using DataLayer.AdminEntities.Experts;
using DataLayer.AdminEntities.Financial;
using DataLayer.AdminEntities.Gallery;
using DataLayer.AdminEntities.Logo;
using DataLayer.AdminEntities.Message;
using DataLayer.AdminEntities.Order;
using DataLayer.AdminEntities.Originality;
using DataLayer.AdminEntities.Product;
using DataLayer.AdminEntities.Slider;
using DataLayer.AdminEntities.SocialNetwork;
using DataLayer.AdminEntities.Teaser;
using DataLayer.AdminEntities.User;
using DataLayer.AdminEntities.Baner;
using DataLayer.AdminEntities.Richat;




namespace DataLayer.Context
{
    public class ContextHampadco:DbContext
    {
          public ContextHampadco(DbContextOptions<ContextHampadco> options) : base(options)
        {

        }
        public DbSet<Tb_Address> Tbl_Adress { get; set; }
        public DbSet<Tb_Agency> Tbl_Agencie { get; set; }
        public DbSet<Tb_Blog> Tbl_Blog { get; set; }
        public DbSet<Tb_Comment> Tbl_Comments { get; set; }
        public DbSet<Tb_Category> tbl_category { get; set; }
        public DbSet<Tb_Experts> Tbl_Experts { get; set; }
        public DbSet<Tb_Financial> Tbl_Financial { get; set; }
        public DbSet<Tb_Gallery> Tbl_Gallery { get; set; }
        public DbSet<Tb_ImageGallery> tb_ImageGalleries {get; set;}
        public DbSet<Tb_Logo> Tbl_Logo { get; set; }
        public DbSet<Tb_Message> Tbl_Message { get; set; }
        public DbSet<Tb_Order> Tbl_Order { get; set; }
         public DbSet<Tb_Factor> Tbl_Factors { get; set; }
        public DbSet<Tb_Originality> Tbl_Originality { get; set; }
        public DbSet<Tb_Product> Tbl_Product { get; set; }
        public DbSet<Tb_Slider> Tbl_Slider { get; set; }
        public DbSet<Tb_Baner> Tbl_Baner { get; set; }
          public DbSet<Tbl_Richat> Tbl_Richats { get; set; }

        public DbSet<Tb_SocialNetwork> Tbl_SocialNetwork { get; set; }
        public DbSet<Tb_Teaser> Tbl_Teaser { get; set; }
        public DbSet<Tb_User> Tbl_User { get; set; }
        


         public DbSet<Tb_GalleryProduct> tb_GalleryProducts  { get; set; }








    }

    public class ToDoContextFactory : IDesignTimeDbContextFactory<ContextHampadco>
    {
        public ContextHampadco CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ContextHampadco>();
               builder.UseSqlServer("Data Source=.;initial Catalog=nikatek_db;integrated Security=SSPI;MultipleActiveResultSets=true");
                //  builder.UseSqlServer("Data Source=193.141.64.76,2019;initial Catalog=hampadco;USER ID=hampadco;PASSWORD=12345@iran;MultipleActiveResultSets=true");
               

            return new ContextHampadco(builder.Options);
        }
    }



    
    }
