using System;
using System.ComponentModel.DataAnnotations;

namespace BusinessLMSWeb.Models
{
	public class Book
	{

     [Display(Name = "Book Id", ResourceType = typeof(TextResources.Businesslms))]
        public int BookId { get; set; }

        [Required]
        [Display(Name = "IBONum", ResourceType = typeof(TextResources.Businesslms))]
        public string IBONum { get; set; }

        [Required]
        [Display(Name = "BookTitle", ResourceType = typeof(TextResources.Businesslms))]
        public string Title { get; set; }

        [Display(Name = "BookAutor", ResourceType = typeof(TextResources.Businesslms))]
        public string Autor { get; set; }

        [Display(Name = "BookBuyLink", ResourceType = typeof(TextResources.Businesslms))]
        public string Link1 { get; set; }

     [Display(Name = "BookBuyLink", ResourceType = typeof(TextResources.Businesslms))]
        public string Link2 { get; set; }

        [Display(Name = "BookBuyLink", ResourceType = typeof(TextResources.Businesslms))]
        public string Link3 { get; set; }

        [Display(Name = "BookPriority", ResourceType = typeof(TextResources.Businesslms))]
        public int priority { get; set; }

        [Display(Name = "BookCount", ResourceType = typeof(TextResources.Businesslms))]
        public int Count { get; set; }
	}
}
