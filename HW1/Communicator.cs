static class Communicator
{
   public static void Send (Person sender, Person recipient, string message)
    {
        Console.WriteLine($"Sender {sender.FirstName} {sender.LastName} sent message to { recipient.FirstName} {recipient.LastName} text: {message}");
    }
}