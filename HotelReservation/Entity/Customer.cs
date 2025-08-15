namespace HotelReservation.Entity;

public class Customer
{
    public string FullName { get; private set; }
    public string PhoneNumber { get; private set; }
    public string Email { get; private set; }
    public DateTime Date { get; private set; }

    public Customer(string name, string phoneNumber, string email)
    {
        FullName = name;
        PhoneNumber = phoneNumber;
        Email = email;
        Date = DateTime.Now;
    }
}
