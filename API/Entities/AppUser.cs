namespace API.Entities
{
    public class AppUser
    {
        public AppUser(string userName)
        {
            UserName = userName;
        }

        public int Id { get; set; }
        public string UserName { get; set; }
    }
}