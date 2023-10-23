using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Entities.Models
{
	public class User
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[StringLength(20)]
		[NotNull]
		public string? UserName { get; set; }

		[StringLength(20)]
		[NotNull]
		public string? Password { get; set; }

		[StringLength(50)]
		[NotNull]
		public string? FullName { get; set; }

		[EmailAddress]
		[StringLength(50)]
		[NotNull]
		public string? Email { get; set; }

		[Phone]
		[NotNull]
		[StringLength(10)]
		public string? PhoneNumber { get; set; }

		[DataType(DataType.Date)]
		[NotNull]
		[Column(TypeName = "Date")]
		public DateTime Dob { get; set; }

		[StringLength(10)]
		[NotNull]
		public string? Role { get; set; }
	}
}
