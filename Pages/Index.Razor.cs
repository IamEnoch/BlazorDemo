using BlazorDemo.APP.Models;

namespace BlazorDemo.APP.Pages
{
    public partial class Index
    {
        private List<Contact> _contacts;
        private readonly Dictionary<string, object> MyTextBoxAttributes = new()
        {
            { "disabled", "disabled" },
            { "placeholder", "Me" },
            { "type", "text" }
        };


        protected override async Task<Task> OnInitializedAsync()
        {
            await Task.Delay(5000);
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
    }
}
