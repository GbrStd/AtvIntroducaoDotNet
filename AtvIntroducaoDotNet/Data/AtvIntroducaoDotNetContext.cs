using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AtvIntroducaoDotNet.Models;

namespace AtvIntroducaoDotNet.Data
{
    public class AtvIntroducaoDotNetContext : DbContext
    {
        public AtvIntroducaoDotNetContext (DbContextOptions<AtvIntroducaoDotNetContext> options)
            : base(options)
        {
        }

        public DbSet<AtvIntroducaoDotNet.Models.Equacao> Equacao { get; set; } = default!;
    }
}
