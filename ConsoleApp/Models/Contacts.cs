namespace ConsoleApp.Models
{
    public class Contacts
    {
        public Contacts()
        {
            ContactInformation = new ContactInformation();
            ContactAddress = new ContactAddress();
        }

        // konstruktor skapad så contactaddress och contactinformation är tillgängliga i contacts som sedan kan initieras i andra klasser.
        public string City
        {
            get { return ContactAddress.City; }
            set { ContactAddress.City = value; }
        }

        public string PostalCode
        {
            get { return ContactAddress.PostalCode; }
            set { ContactAddress.City = value; }
        }

        public string StreetName
        {
            get { return ContactAddress.StreetName; }
            set { ContactAddress.StreetName = value; }
        }

        public string PhoneNumber
        {
            get { return ContactInformation.PhoneNumber; }
            set { ContactAddress.StreetName = value; }
        }

        public string Email
        {
            get { return ContactInformation.Email; }
            set { ContactAddress.StreetName = value; }
        }

        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        public ContactInformation ContactInformation { get; set; }
        public ContactAddress ContactAddress { get; set; }
    }
}
