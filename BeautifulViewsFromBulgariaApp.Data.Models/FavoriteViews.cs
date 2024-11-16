using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace BeautifulViewsFromBulgariaApp.Data.Models
{
    [PrimaryKey(nameof(UserId), nameof(LocationId))]
    public class FavoriteViews
    {
        [Required]
        public Guid UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;

        [Required]
        public Guid LocationId { get; set; }
        [ForeignKey(nameof(LocationId))]
        public LocationPost Location { get; set; } = null!;
    }
}