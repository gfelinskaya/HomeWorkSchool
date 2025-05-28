public class School
{
    public Group[] Groups { get; set; }
    public Director Director { get; set; }
    public string Id { get; set; } = string.Empty;


    public School(string id, Group[] groups, Director director)
    {
        Id = id;
        Groups = groups;
        Director = director;
    }
    
    public Group this[string id]
    {
        get
        {
            foreach (Group group in Groups)
            {
                if (group.Id == id)
                    return group;
            }
            throw new KeyNotFoundException($"Group with ID='{id}' not found.");
        }
    }
}
