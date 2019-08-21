using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyHabits.Models
{
    public class HabitContext :DbContext
    {
        public HabitContext(DbContextOptions<HabitContext> options):base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Activity> Activities { get; set; }

    }
}
