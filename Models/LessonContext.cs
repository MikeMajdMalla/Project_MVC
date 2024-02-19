using Microsoft.EntityFrameworkCore;

namespace My_assigment.Models
{
    public class LessonContext : DbContext  
    {
        public DbSet<LessonBooking> lessonBooking { get; set; }
        public LessonContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("DataSource = schlessonDB.db"); //Databasfilens namn
        }
    }

}
