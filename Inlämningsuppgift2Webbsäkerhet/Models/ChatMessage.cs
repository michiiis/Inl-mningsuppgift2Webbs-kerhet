namespace Inlämningsuppgift2Webbsäkerhet.Models
{
    public class ChatMessage
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Message { get; set; }
        public DateTime Created { get; set; }
    }
}
