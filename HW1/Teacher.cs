public class Teacher: Person
{
    public uint Experience { get; set; }
    public uint Salary { get; set; }

    public Teacher(string firstName, string lastName, string phoneNumber, int rating, uint experience, uint salary) 
    :base(firstName, lastName, phoneNumber, rating)
    {
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        Rating = rating;
        Experience = experience;
        Salary = salary;
    }
}