using System.Collections.Generic;

namespace ProductAppWeb.Data
{
    public class User
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public static List<User> st = new List<User>();

        public User(string name, string login, string mail)
        {
            this.Name = name;
            this.Login = login;
            this.Password = mail;
        }

        public User()
        {

        }

        public static void AddClient(string name, string login, string password)
        {
            User std = new User(name, login, password);
            st.Add(std);
        }

        public static List<User> GetClient()
        {
            return st;
        }
    }
}
