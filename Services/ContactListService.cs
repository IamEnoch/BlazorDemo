using BlazorDemo.APP.Models;

namespace BlazorDemo.APP.Services;

public class ContactListService
{
    public List<Contact> Contacts = new List<Contact>();

    public void AddContact(Contact contact)
    {
        Contacts.Add(contact);
    }

}