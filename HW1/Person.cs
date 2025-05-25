public abstract class Person
{
    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string PhoneNumber { get; set; } = string.Empty;

    public int Rating { get; set; } = 0;

    public Person(string fistName, string lastName, string phoneNumber, int rating)
    {
        FirstName = fistName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        Rating = rating; 
    }
}