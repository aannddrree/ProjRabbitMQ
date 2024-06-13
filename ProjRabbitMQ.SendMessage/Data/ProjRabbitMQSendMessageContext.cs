using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjRabbitMQ.Models;

namespace ProjRabbitMQ.SendMessage.Data
{
    public class ProjRabbitMQSendMessageContext : DbContext
    {
        public ProjRabbitMQSendMessageContext (DbContextOptions<ProjRabbitMQSendMessageContext> options)
            : base(options)
        {
        }

        public DbSet<ProjRabbitMQ.Models.Message> Message { get; set; } = default!;
    }
}
