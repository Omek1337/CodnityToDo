using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configurations
{
    public class ToDoItemConfiguration : IEntityTypeConfiguration<ToDoItem>
    {
        public void Configure(EntityTypeBuilder<ToDoItem> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.Created).IsRequired();
            builder.Property(x => x.Updated).IsRequired();
            builder.Property(x => x.DeadlineDate).IsRequired(false);
            builder.Property(x => x.UserName).IsRequired();

            builder.HasKey(x => x.Id);
        }
    }
}
