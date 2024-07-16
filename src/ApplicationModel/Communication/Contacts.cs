namespace MetaFrm.Maui.Essentials.ApplicationModel.Communication
{
    /// <summary>
    /// Contacts
    /// </summary>
    public class Contacts : Maui.ApplicationModel.Communication.IContacts
    {
        /// <summary>
        /// GetAllContactAsync
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Maui.ApplicationModel.Communication.Contact>> GetAllContactAsync(CancellationToken cancellationToken = default)
        {
            List<Maui.ApplicationModel.Communication.Contact> contacts = new();

            IEnumerable<Contact> contactsOrg = await Microsoft.Maui.ApplicationModel.Communication.Contacts.Default.GetAllAsync(cancellationToken);

            if (contactsOrg != null)
            {

                foreach (Contact contact in contactsOrg)
                {
                    List<Maui.ApplicationModel.Communication.ContactPhone> phones = new();
                    foreach (var phone in contact.Phones)
                        phones.Add(new Maui.ApplicationModel.Communication.ContactPhone(phone.PhoneNumber));

                    List<Maui.ApplicationModel.Communication.ContactEmail> emails = new();
                    foreach (var email in contact.Emails)
                        emails.Add(new Maui.ApplicationModel.Communication.ContactEmail(email.EmailAddress));

                    contacts.Add(new Maui.ApplicationModel.Communication.Contact(contact.Id, contact.NamePrefix, contact.GivenName, contact.MiddleName, contact.FamilyName, contact.NameSuffix, phones, emails, contact.DisplayName));
                }

                return contacts;
            }
            else
                return contacts;
        }

        /// <summary>
        /// PickContactAsync
        /// </summary>
        /// <returns></returns>
        public async Task<Maui.ApplicationModel.Communication.Contact?> PickContactAsync()
        {
            Contact? contact = await Microsoft.Maui.ApplicationModel.Communication.Contacts.Default.PickContactAsync();

            if (contact != null)
            {
                List<Maui.ApplicationModel.Communication.ContactPhone> phones = new();
                foreach (var phone in contact.Phones)
                    phones.Add(new Maui.ApplicationModel.Communication.ContactPhone(phone.PhoneNumber));

                List<Maui.ApplicationModel.Communication.ContactEmail> emails = new();
                foreach (var email in contact.Emails)
                    emails.Add(new Maui.ApplicationModel.Communication.ContactEmail(email.EmailAddress));

                return new Maui.ApplicationModel.Communication.Contact(contact.Id, contact.NamePrefix, contact.GivenName, contact.MiddleName, contact.FamilyName, contact.NameSuffix, phones, emails, contact.DisplayName);
            }
            else
                return null;
        }
    }
}