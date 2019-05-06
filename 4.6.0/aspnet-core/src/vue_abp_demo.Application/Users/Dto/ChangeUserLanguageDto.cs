using System.ComponentModel.DataAnnotations;

namespace vue_abp_demo.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}