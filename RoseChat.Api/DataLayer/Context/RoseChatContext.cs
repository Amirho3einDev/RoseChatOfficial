using Microsoft.EntityFrameworkCore;
using RoseChat.Api.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoseChat.Api.DataLayer.Context
{
    public class RoseChatContext:DbContext
    {
      
        public RoseChatContext(DbContextOptions<RoseChatContext>options):base(options)
        {
        
        }
        public DbSet<Value> Values { get; set; }
    }
}
