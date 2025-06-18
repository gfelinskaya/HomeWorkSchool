public class Group
{
    public string Id { get; set; } = string.Empty;
    public Pupal[] Pupals { get; set; }
    public Group(string id, Pupal[] pupals)
    {
        Id = id;
        Pupals = pupals;
    }
    
    public Pupal this[string firstName, string lastName]
    {
        get
        {
            foreach (Pupal pupal in Pupals)
            {
                if (pupal.LastName == lastName && pupal.FirstName == firstName)
                    return pupal;
            }
            throw new KeyNotFoundException($"Pupal with LastName='{lastName}' and FirstName='{firstName}' not found.");
        }
    }
}
