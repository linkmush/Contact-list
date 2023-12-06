namespace ConsoleApp.Models
{
    public class Contacts
    {

        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        public ContactInformation ContactInformation { get; set; } = new ContactInformation(); 
        public ContactAddress ContactAddress { get; set; } = new ContactAddress();

        // konstruktor skapad så contactaddress och contactinformation är tillgängliga i contacts som sedan kan initieras i andra klasser.
        public string City
        {
            get { return ContactAddress.City; }
            set { ContactAddress.City = value; }
        }

        public string PostalCode
        {
            get { return ContactAddress.PostalCode; }
            set { ContactAddress.PostalCode = value; }
        }

        public string StreetName
        {
            get { return ContactAddress.StreetName; }
            set { ContactAddress.StreetName = value; }
        }

        public string PhoneNumber
        {
            get { return ContactInformation.PhoneNumber; }
            set { ContactInformation.PhoneNumber = value; }
        }

        public string Email
        {
            get { return ContactInformation.Email; }
            set { ContactInformation.Email = value; }
        }
    }
}
