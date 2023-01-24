using Microsoft.EntityFrameworkCore;
using PeanutsTracker.Models;

namespace PeanutsTracker.DbContexts
{
    public class PeanutsTrackerDbContext : DbContext
    {
        public PeanutsTrackerDbContext(DbContextOptions<PeanutsTrackerDbContext> options) : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Budget> Budgets { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Expenditure>   Expenditures { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<Reminder> Reminders { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserSession> UserSessions { get; set; }

        
        
        
    }
}
