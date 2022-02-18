public class AccountEditTextUI
{
    private IAccount account;
    // public AccountEditTextUI(Account inAccount)
    // {
    //     this.account = inAccount;
    // }
    public void EditName()
    {
        string newName;
        Console.WriteLine("Name Edit");
        while (true)
        {
            Console.Write("Enter new name : ");
            newName = Console.ReadLine();
            string reply;
            reply = this.account.ValidateName(newName);
            if (reply.Length == 0)
            {
                break;
            }
            Console.WriteLine("Invalid name : " + reply);
        }
        this.account.SetName(newName);
    }
}

public interface IAccount
{
    string GetName();
    string SetName(string inName);
    string ValidateName(string name);
}
public class CustomerAccount
{
    private string name;
    public string GetName()
    {
        return this.name;
    }
    public static string ValidateName(string name)
    {
        if (name == null)
        {
            return "Name parameter null";
        }
        string trimmedName = name.Trim();
        if (trimmedName.Length == 0)
        {
            return "No text in the name";
        }
        return "";
    }
    public bool SetName(string inName)
    {
        string reply;
        reply = ValidateName(inName);
        if (reply.Length > 0)
        {
            return false;
        }
        this.name = inName.Trim();
        return true;
    }
}