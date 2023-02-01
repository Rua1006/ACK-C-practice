using MessagePack;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Entities
{
    public abstract class BaseEntity
    {
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime last_update { get; set; } = DateTime.Now;

        
    }
}
