using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace Model.Mappings
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Email)
                .HasMaxLength(256);

            builder.OwnsOne(u => u.Endereco, endereco =>
            {
                endereco.Property(e => e.CEP)
                    .HasColumnName("CEP")
                    .HasMaxLength(10);
                endereco.Property(e => e.Logradouro)
                    .HasColumnName("Logradouro")
                    .HasMaxLength(100);
                endereco.Property(e => e.Numero)
                    .HasColumnName("Numero");
                endereco.Property(e => e.Bairro)
                    .HasColumnName("Bairro")
                    .HasMaxLength(50);
                endereco.Property(e => e.Municipio)
                    .HasColumnName("Municipio")
                    .HasMaxLength(50);
                endereco.Property(e => e.UF)
                    .HasColumnName("UF")
                    .HasMaxLength(2);
                endereco.Property(e => e.Complemento)
                    .HasColumnName("Complemento")
                    .HasMaxLength(100);
                endereco.Property(e => e.Pais)
                    .HasColumnName("Pais")
                    .HasMaxLength(50);
            });
        }
    }
}
