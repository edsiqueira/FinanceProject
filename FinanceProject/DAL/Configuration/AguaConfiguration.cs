using DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Configuration
{
    public class AguaConfiguration : IEntityTypeConfiguration<Agua>
    {
        public void Configure(EntityTypeBuilder<Agua> builder)
        {
            //builder.HasKey(x => x.ID);
            //builder.HasOne(x => x.MesID).WithOne(a => a.AguaID);
            
        }
    }
}
