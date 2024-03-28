namespace WebApplication_Authentication_Cookies
{
    public class Person
    {
        public int Id { get; set; } 
        public string Email { get; set; } = "";
        public string Password { get; set; } = "";

        public Person() { } 

        public Person(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}
