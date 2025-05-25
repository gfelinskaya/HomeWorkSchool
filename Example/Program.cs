namespace ConsoleApp31
{
    internal class Program
    {
        static void Main(string[] args)
        {      
            Emploee firstEmploee = new Emploee("Ben", "Aflek", "Software Engineer", 2000);
            
            firstEmploee.Email = "ban@mail.com";
            firstEmploee.PhoneNumber = "1234567890";

            Emploee secondEmploee = new Emploee("Ann", "Peterson", "QA", 1500)
            {
                Id = "12345",   
                Email = "ann@mail.com",
                PhoneNumber = "0987654321"
            };

            Emploee newEml = firstEmploee;
            newEml.IsDangere = true;

            firstEmploee.Report("I am working on a new project.");

            Emploee[] office = [firstEmploee, secondEmploee, new Emploee("Bob", "Jenkinks", "Software Engeneer", 3000)];

            Emploee.TimeShifts = "10-00 - 19-00";

            for (int i = 0; i < office.Length; i++)
            {
                Console.WriteLine(office[i].GetInfo());
                Console.WriteLine(office[i].CheckTolerance());
                Console.WriteLine($"My worh shifts {Emploee.TimeShifts}");
                Console.WriteLine("===================================");
            }


            Office office1 = new Office();  

            office1.HireEmploee(firstEmploee);
            office1.HireEmploee(secondEmploee);

            if (office1[1] != null && office1["12345"] != null)
            {
                Console.WriteLine(office1[1].FirstName);
                Console.WriteLine(office1["12345"].FirstName);
            }
        }
    }
}
