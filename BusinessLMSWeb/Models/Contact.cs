using System.ComponentModel.DataAnnotations;

namespace BusinessLMSWeb.Models
{
	public class Contact
	{

        [Display(Name = "ContactId", ResourceType = typeof(TextResources.Businesslms))]
		public int contactId { get; set; }

		[Required]
		[Display(Name = "ContactIBONum", ResourceType = typeof(TextResources.Businesslms))]
		[DataType(DataType.Text)]
		public string IBONum { get; set; }

		[Required]
		[Display(Name = "ContactTypeId", ResourceType = typeof(TextResources.Businesslms))]
		public int contactTypeId { get; set; }

		[Required]
		[Display(Name = "ContactLanguageId", ResourceType = typeof(TextResources.Businesslms))]
		[DataType(DataType.Text)]
		public int languageId { get; set; }

		[Required]
		[Display(Name = "ContactFirstName", ResourceType = typeof(TextResources.Businesslms))]
		[DataType(DataType.Text)]
		public string firstName { get; set; }

		[Required]
		[Display(Name = "ContactLastName", ResourceType = typeof(TextResources.Businesslms))]
		[DataType(DataType.Text)]
		public string lastName { get; set; }

		[Required]
		[Display(Name = "ContactEmail", ResourceType = typeof(TextResources.Businesslms))]
		[DataType(DataType.EmailAddress)]
		public string email { get; set; }

		[Display(Name = "ContactPhoneNumber", ResourceType = typeof(TextResources.Businesslms))]
		[DataType(DataType.PhoneNumber)]
		public string phone { get; set; }

		[Display(Name = "ContactCellNumber", ResourceType = typeof(TextResources.Businesslms))]
		[DataType(DataType.PhoneNumber)]
		public string cell { get; set; }

		[Display(Name = "ContactAddress", ResourceType = typeof(TextResources.Businesslms))]
		[DataType(DataType.MultilineText)]
		public string address { get; set; }

		[Display(Name = "ContactState", ResourceType = typeof(TextResources.Businesslms))]
		[DataType(DataType.Text)]
		public string state { get; set; }

		[Display(Name = "ContactCity", ResourceType = typeof(TextResources.Businesslms))]
		[DataType(DataType.Text)]
		public string city { get; set; }

		[Display(Name = "ContactZipCode", ResourceType = typeof(TextResources.Businesslms))]
		[DataType(DataType.PostalCode)]
		public string zipcode { get; set; }

		[Required]
		[Display(Name = "ContactPreferred", ResourceType = typeof(TextResources.Businesslms))]
		[DataType(DataType.Text)]
		public string preferred { get; set; }

		[Required]
		[Display(Name = "ContactLevel", ResourceType = typeof(TextResources.Businesslms))]
		[DataType(DataType.Text)]
		public string contactLevel { get; set; }

		[Required]
		[Display(Name = "ContactDate", ResourceType = typeof(TextResources.Businesslms))]
		[DataType(DataType.DateTime)]
		public System.DateTime datetime { get; set; }

		[Required]
		public bool isPublic { get; set; }

		[Display(Name = "ContactBirthDate", ResourceType = typeof(TextResources.Businesslms))]
		[DataType(DataType.DateTime)]
		public System.DateTime birthday { get; set; }

        [Display(Name = "ContactPreferredTime", ResourceType = typeof(TextResources.Businesslms))]
		[DataType(DataType.Text)]
		public string preferedTime { get; set; }

		[Required]
        [Display(Name = "ContactNewsLetter", ResourceType = typeof(TextResources.Businesslms))]
		public bool newsletteroptin { get; set; }

		public string GetFullName()
		{
			return string.Concat(this.firstName, " ", this.lastName);
		}

	}
}
