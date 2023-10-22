using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Entities.Models
{
	public class Cage
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[NotNull]
		[StringLength(50)]
		public string CageName { get; set; } = string.Empty;

		[NotNull]
		public int AreaId { get; set; }

		public virtual Area? Area { get; set; }
	}
}
