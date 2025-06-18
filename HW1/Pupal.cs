public class Pupal: Person
{
    public Teacher PinnedTeacher { get; set; }
    public Pupal(string firstName, string lastName, string phoneNumber, int rating, Teacher pinnedTeacher) :
    base(firstName, lastName, phoneNumber, rating)
    {
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        Rating = rating;
        PinnedTeacher = pinnedTeacher;
    }
}