using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjRabbitMQ.Models;

namespace ProjRabbitMQ.Producer.Data
{
    public class ProjRabbitMQProducerContext : DbContext
    {
        public ProjRabbitMQProducerContext (DbContextOptions<ProjRabbitMQProducerContext> options)
            : base(options)
        {
        }

        public DbSet<ProjRabbitMQ.Models.Message> Message { get; set; } = default!;
    }
}
