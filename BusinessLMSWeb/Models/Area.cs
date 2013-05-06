using System.ComponentModel.DataAnnotations;

namespace BusinessLMSWeb.Models
{
    public class Area
    {
        public int areaId { get; set; }

        [Required]
        [Display(Name = "AreaTitle", ResourceType = typeof(TextResources.Businesslms))]
        [DataType(DataType.Text)]
        public string title { get; set; }
    }
}
