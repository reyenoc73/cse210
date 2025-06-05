public class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public bool LivesInUSA() => address.IsInUSA();

    public string GetName() => name;
    public string GetAddress() => address.GetFullAddress();
}