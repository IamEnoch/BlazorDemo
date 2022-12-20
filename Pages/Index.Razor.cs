using BlazorDemo.APP.Models;
using BlazorDemo.APP.Pages.ContactComponents;

namespace BlazorDemo.APP.Pages
{
    public partial class Index
    {

        private ContactList _contactList;
        private bool _isContactsVisible = true;

        private List<Contact> _contacts;
        private readonly Dictionary<string, object> MyTextBoxAttributes = new()
        {
            { "disabled", "disabled" },
            { "placeholder", "Me" },
            { "type", "text" }
        };


        protected override async Task<Task> OnInitializedAsync()
        {
            _contacts = new()
            {
                new Contact
                {
                    FirstName = "Enoch",
                    LastName = "Doe",
                    Email = "enoch@gmail.com"
                },
                new Contact
                {
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "john@gmail.com"
                },
                new Contact
                {
                    FirstName = "Lucas",
                    LastName = "Moura",
                    Email = "lucas@gmail.com"
                },
                new Contact
                {
                    FirstName = "Emily",
                    LastName = "Wahito",
                    Email = "emily@gmail.com"
                }
            };
            return base.OnInitializedAsync();

        }

        private void HideContacts()
        {
            _isContactsVisible = !_isContactsVisible;
            if (_isContactsVisible)
            {
                _contactList.ShowContacts();
            }
            else
            {
                _contactList.HideContacts();
            }

        }
    }
}
