using static BeautifulViewsFromBulgariaApp.Common.EntityConstants;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BeautifulViewsFromBulgariaApp.Data.Models
{
    using static BeautifulViewsFromBulgariaApp.Common.EntityConstants.LocationPost;
    public class LocationPost
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        [MinLength(TitleMinLength)]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        [MinLength(DescriptionMinLength)]
        public string Description { get; set; } = null!;

        [Required]
        public string PhotoURL { get; set; } = null!;


        [Required]
        public Guid UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public ICollection<FavoriteViews> Favorites { get; set; } = new List<FavoriteViews>();
        public ICollection<Tag> Tags { get; set; } = new List<Tag>();
    }
}