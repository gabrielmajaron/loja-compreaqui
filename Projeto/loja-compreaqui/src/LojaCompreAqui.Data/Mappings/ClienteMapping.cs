using LojaCompreAqui.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojaCompreAqui.Data.Mappings
{
    class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnType("varchar(30)");

            builder.Property(c => c.Sobrenome)
               .IsRequired()
               .HasColumnType("varchar(50)");

            builder.Property(c => c.Email)
               .IsRequired()
               .HasColumnType("varchar(50)");

            builder.Property(c => c.Documento)
               .IsRequired()
               .HasColumnType("varchar(14)");


            // 1 : 1 => Cliente : Endereco
            // Cliente tem 1 endereço (hasone)
            // o endereco tem 1 cliente (withone)
            builder.HasOne(c => c.Endereco)
                .WithOne(e => e.Cliente);

            
            // 1 : N => Cliente : Pedido
            builder.HasMany(c => c.Pedidos)
                .WithOne(p => p.Cliente)
                .HasForeignKey(p => p.ClienteId);
        }
    }
}
