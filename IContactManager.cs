namespace ContactList;

public interface IContactManager
{    
    void AddContact();

    void SearchContactById();

    void SearchContactByPhoneNumber();

    void ListAllContacts();

    void UpdateContact();

    void DeleteContact();
}
