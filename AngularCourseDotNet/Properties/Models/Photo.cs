namespace AngularCourseDotNet.Controllers.Models
{
    public class Photo
    {

        public int  Id { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public System.DateTime Creazione { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}