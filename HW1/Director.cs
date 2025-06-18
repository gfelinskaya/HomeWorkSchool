public class Director:Teacher
{
    public string KmowladgeField { get; set; } = string.Empty;
    public Teacher [] SubordinateTeachers { get; set; }
    public Director(string firstName, string lastName, string phoneNumber, int rating, uint experience, uint salary, string knowladgeField, Teacher[] subordinateTeachers) :
    base(firstName, lastName, phoneNumber, rating, experience, salary)
    {
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        Rating = rating;
        Experience = experience;
        Salary = salary;
        KmowladgeField = knowladgeField;
        SubordinateTeachers = subordinateTeachers;
        
    }
}