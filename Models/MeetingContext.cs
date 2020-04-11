using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreUIAppn.Models
{
    public class MeetingContext:DbContext
    {
        public MeetingContext(DbContextOptions<MeetingContext> options):base(options)
        {

        }
        public DbSet<Meeting> Meeting { get; set; }
    }

}
