using LojaCompreAqui.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojaCompreAqui.Data.Mappings
{
    class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(e => e.Id);            

            builder.Property(e => e.Logradouro)
                .IsRequired()
                .HasColumnType("varchar(200)");


            builder.Property(e => e.Numero)
                .IsRequired()
                .HasColumnType("varchar(50)");


            builder.Property(e => e.Cep)
                .IsRequired()
                .HasColumnType("varchar(8)");


            builder.Property(e => e.Complemento)
                .IsRequired()
                .HasColumnType("varchar(200)");


            builder.Property(e => e.Bairro)
                .IsRequired()
                .HasColumnType("varchar(100)");


            builder.Property(e => e.Cidade)
                .IsRequired()
                .HasColumnType("varchar(100)");


            builder.Property(e => e.Estado)
                .IsRequired()
                .HasColumnType("varchar(25)");

            // 1 : 1 => Endereco : Cliente
            builder.HasOne(e => e.Cliente)
                .WithOne(c => c.Endereco);

            // 1 : 1 => Endereco : Fornecedor
            builder.HasOne(e => e.Fornecedor)
                .WithOne(c => c.Endereco);

            builder.ToTable("Enderecos");
        }
    }
}
