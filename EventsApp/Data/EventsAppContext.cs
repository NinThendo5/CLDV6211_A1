using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EventsApp.Models;

namespace EventsApp.Data
{
    public class EventsAppContext : DbContext
    {
        public EventsAppContext (DbContextOptions<EventsAppContext> options)
            : base(options)
        {
        }

        public DbSet<EventsApp.Models.Venue> Venue { get; set; } = default!;
    }
}
