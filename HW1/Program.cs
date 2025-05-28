internal class Program
{
    static void Main(string[] args)
    {
        Teacher firstTeacher = new Teacher("Lana", "DelRay", "0986543265", 1, 15, 20000);
        Teacher secondTeacher = new Teacher("Vasia", "Pupkin", "0986544265", 2, 5, 20000);
        Pupal pupal1 = new Pupal("Anton", "Kozlow", "0764532654", 4, firstTeacher);
        Pupal pupal2 = new Pupal("Halyna", "Kozlowska", "0764532354", 1, secondTeacher);
        Pupal pupal3 = new Pupal("Ihor", "Kozlowenko", "0767882654", 2, secondTeacher);
        Pupal pupal4 = new Pupal("Maria", "Kozlobandowa", "0764532654", 3, firstTeacher);
        Teacher[] teachers = [firstTeacher, secondTeacher];
        Director director1 = new Director("Maryna", "Vonuchka", "0936754312", 10, 100, 200000, "math", teachers);
        Pupal[] pupals1 = [pupal2, pupal3];
        Pupal[] pupals2 = [pupal1, pupal4];
        Group botany = new Group("9A", pupals1);
        Group blotni = new Group("10B", pupals2);
        Group[] groups = [botany, blotni];


        //Pupal pupalToFing = botany["Anton", "Kozlow"];
        //Console.WriteLine($"Found: {pupalToFing.FirstName} {pupalToFing.LastName}, Teacher: {pupalToFing.PinnedTeacher.LastName}");

        Pupal pupalToFing2 = botany["Halyna", "Kozlowska"];
        Console.WriteLine($"Found: {pupalToFing2.FirstName} {pupalToFing2.LastName}, Teacher: {pupalToFing2.PinnedTeacher.LastName}");

        School school1 = new School("Gamnasia", groups, director1);

        Group grounToFind = school1["10B"];
        Console.WriteLine($"Found: {grounToFind.Id} Pupals count {grounToFind.Pupals.Count()}");

    }
    }
   
    
