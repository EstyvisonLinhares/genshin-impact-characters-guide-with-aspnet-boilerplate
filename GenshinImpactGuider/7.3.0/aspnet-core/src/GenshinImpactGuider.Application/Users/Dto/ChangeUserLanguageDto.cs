using System.ComponentModel.DataAnnotations;

namespace GenshinImpactGuider.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}