using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Entities.Models
{
	public class Area
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[NotNull]
		[StringLength(50)]
		public string Name { get; set; } = string.Empty;

		public virtual ICollection<Cage> Cages { get; set; } = new List<Cage>();
	}
}
