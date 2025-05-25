namespace ConsoleApp31
{
    abstract class Person
    {
        public string Id { get; set; } = "00000";
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        protected Person(string fistName, string lastName)
        {
            FirstName = fistName;
            LastName = lastName;  
        }

        public abstract string GetInfo();

        public virtual bool CheckTolerance()
        {
            return (FirstName.Length > 2 && LastName.Length > 2);          
        }

        public bool IsDangere { get; set; }
    }
}
