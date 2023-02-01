namespace SampleJwt.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public User(string username, string password)
        {
            UserName = username;
            Password = password;
        }
    }
}
