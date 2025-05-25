namespace ConsoleApp31
{
    class Emploee : Person
    {
        public static string TimeShifts { get; set; } = "9-00 - 18-00";

        public string Title { get; set; } = string.Empty;   
        public string Department { get; set; } = string.Empty;
        public double Salary { get; set; }

        public Emploee(string fistName, string lastName, string title, double sallary)
            : base(fistName, lastName)
        {
            Title = title;
            Salary = sallary;   
        }

        public void Report(string text)
        {
            Console.WriteLine($"I am {FirstName} {LastName}, I work as a {Title} in the {Department} department. {text}");
        }

        public override string GetInfo()
        {
            string info = @$"Hello, I`m emploee
                          First Name: {FirstName}
                          Last Name: {LastName}
                          Email: {Email}
                          Phone Number: {PhoneNumber}
                          Address: {Address}
                          Is Dengere: {IsDangere}"; 

            return info;
        }
    }
}
