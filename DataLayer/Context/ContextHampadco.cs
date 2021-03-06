using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.AdminEntities.Address;
using DataLayer.AdminEntities.Admin;
using DataLayer.AdminEntities.Agency;
using DataLayer.AdminEntities.Baner;
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
using DataLayer.AdminEntities.Richat;
using DataLayer.AdminEntities.Slider;
using DataLayer.AdminEntities.SocialNetwork;
using DataLayer.AdminEntities.Teaser;
using DataLayer.AdminEntities.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;


namespace DataLayer.Context {
  public class ContextHampadco : DbContext {
    public ContextHampadco (DbContextOptions<ContextHampadco> options) : base (options) {

    }
    public DbSet<Tb_Address> Tbl_Adress { get; set; }
    public DbSet<Tb_Agency> Tbl_Agencie { get; set; }
    public DbSet<Tb_Blog> Tbl_Blog { get; set; }
    public DbSet<Tb_Comment> Tbl_Comments { get; set; }
    public DbSet<Tb_Category> tbl_category { get; set; }
    public DbSet<Tb_Experts> Tbl_Experts { get; set; }
    public DbSet<Tb_Financial> Tbl_Financial { get; set; }
    public DbSet<Tb_Gallery> Tbl_Gallery { get; set; }
    public DbSet<Tb_ImageGallery> tb_ImageGalleries { get; set; }
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

    public DbSet<Tb_GalleryProduct> tb_GalleryProducts { get; set; }

<<<<<<< HEAD
    public DbSet<Tbl_info> Tbl_infos { get; set; }
  
=======
    public DbSet<Tbl_Contact> Tbl_Contacts { get; set; }
    public DbSet<Tbl_info_account> Tbl_info_accounts { get; set; }
    public DbSet<Tbl_info_persenal> Tbl_info_persenals { get; set; }
    public DbSet<Tbl_info_records> Tbl_info_records { get; set; }
    public DbSet<Tbl_Level> Tbl_Levels { get; set; }
     public DbSet<Tbl_info_documents> Tbl_info_documents { get; set; }
>>>>>>> 36b925a59fbf885088c5e30b68ba137c4623dbc1

  }

  public class ToDoContextFactory : IDesignTimeDbContextFactory<ContextHampadco> {
    public ContextHampadco CreateDbContext (string[] args) {
      var builder = new DbContextOptionsBuilder<ContextHampadco> ();
      builder.UseSqlServer ("Data Source=.;initial Catalog=nikatek_db;integrated Security=SSPI;MultipleActiveResultSets=true");
      //  builder.UseSqlServer("Data Source=193.141.64.76,2019;initial Catalog=hampadco;USER ID=hampadco;PASSWORD=12345@iran;MultipleActiveResultSets=true");

      return new ContextHampadco (builder.Options);
    }
  }

}