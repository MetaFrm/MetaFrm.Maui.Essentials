namespace MetaFrm.Maui.ApplicationModel.Communication
{
    /// <summary>
    /// Contacts
    /// </summary>
    public class Contacts : IContacts
    {
        /// <summary>
        /// GetAllContactAsync
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Contact>> GetAllContactAsync(CancellationToken cancellationToken = default)
        {
            IEnumerable<Microsoft.Maui.ApplicationModel.Communication.Contact> contactsOrg = await Microsoft.Maui.ApplicationModel.Communication.Contacts.Default.GetAllAsync(cancellationToken);

            if (contactsOrg != null)
            {
                IList<Contact> contacts = new List<Contact>();

                foreach (Microsoft.Maui.ApplicationModel.Communication.Contact contact in contactsOrg)
                {
                    IList<ContactPhone> phones = new List<ContactPhone>();
                    foreach (var phone in contact.Phones)
                        phones.Add(new ContactPhone(phone.PhoneNumber));

                    IList<ContactEmail> emails = new List<ContactEmail>();
                    foreach (var email in contact.Emails)
                        emails.Add(new ContactEmail(email.EmailAddress));

                    contacts.Add(new Contact(contact.Id, contact.NamePrefix, contact.GivenName, contact.MiddleName, contact.FamilyName, contact.NameSuffix, phones, emails, contact.DisplayName));
                }

                return contacts;
            }
            else
                return null;
        }

        /// <summary>
        /// PickContactAsync
        /// </summary>
        /// <returns></returns>
        public async Task<Contact> PickContactAsync()
        {
            Microsoft.Maui.ApplicationModel.Communication.Contact contact = await Microsoft.Maui.ApplicationModel.Communication.Contacts.Default.PickContactAsync();

            if (contact != null)
            {
                IList<ContactPhone> phones = new List<ContactPhone>();
                foreach (var phone in contact.Phones)
                    phones.Add(new ContactPhone(phone.PhoneNumber));

                IList<ContactEmail> emails = new List<ContactEmail>();
                foreach (var email in contact.Emails)
                    emails.Add(new ContactEmail(email.EmailAddress));

                return new Contact(contact.Id, contact.NamePrefix, contact.GivenName, contact.MiddleName, contact.FamilyName, contact.NameSuffix, phones, emails, contact.DisplayName);
            }
            else
                return null;
        }
    }
}