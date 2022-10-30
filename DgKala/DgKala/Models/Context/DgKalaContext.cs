using System.Data.Common;
using System.Linq;
using DgKala.Models.Entities.Category;
using DgKala.Models.Entities.Order;
using DgKala.Models.Entities.Permissions;
using DgKala.Models.Entities.Quesion;
using DgKala.Models.Entities.User;
using DgKala.Models.Entities.Wallet;
using Microsoft.EntityFrameworkCore;

namespace DgKala.Models.Context
{
    public class DgkalaContext:DbContext
    {
        public DgkalaContext(DbContextOptions<DgkalaContext>options):base(options)
        {
            
        }

        #region User

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }


        #endregion

        #region Wallet

        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<WalletType> WalletTypes { get; set; }

        #endregion

        #region Permission

        public DbSet<Permission> Permission { get; set; }
        public DbSet<RolePermission> RolePermission { get; set; }

        #endregion

        #region Category

        public DbSet<CategoryGroups> CategoryGroups { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryStatues> CategoryStatuesEnumerable { get; set; }
        public DbSet<CategoryComment> CategoryComments { get; set; }



        #endregion


        #region Order

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        #endregion

        #region Question

        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;




            modelBuilder.Entity<User>()
                .HasQueryFilter(u => !u.IsDelete);
            modelBuilder.Entity<Role>()
                .HasQueryFilter(r => !r.IsDelete);
            modelBuilder.Entity<CategoryGroups>()
                .HasQueryFilter(c => !c.IsDelete);
            base.OnModelCreating(modelBuilder);
        }
    }
}
