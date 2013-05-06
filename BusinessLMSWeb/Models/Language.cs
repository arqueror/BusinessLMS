using System.ComponentModel.DataAnnotations;


namespace BusinessLMSWeb.Models
{
    public class Language
    {
        [Display(Name = "Language Id")]
        public int languageId { get; set; }

        [Required]
        [Display(Name = "Language", ResourceType = typeof(TextResources.Businesslms))]
        [DataType(DataType.Text)]
        public string language1 { get; set; }
    }
}
