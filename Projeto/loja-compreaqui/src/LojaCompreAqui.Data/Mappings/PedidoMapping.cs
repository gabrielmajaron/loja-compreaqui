using LojaCompreAqui.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojaCompreAqui.Data.Mappings
{
    class PedidoMapping : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(c => c.Id);

            // 1 : N => Pedido : ItemPedido
            builder.HasMany(p => p.ItensPedido)
                .WithOne(i => i.Pedido)
                .HasForeignKey(i => i.PedidoId);
        }
    }
}
