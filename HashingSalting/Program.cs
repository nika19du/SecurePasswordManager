using HashingSalting;
using System.Security.Cryptography;
using System.Text;

namespace HashingSalting
{
    public static class Program
    {
        public static void Main()
        { }

        public static string Login(string name, string password)
        {
            using AppDataContext context = new AppDataContext();
            var userfound = context.Users.Any(u => u.Name == name);

            if (userfound)
            {
                var loginuser = context.Users.FirstOrDefault(u => u.Name == name);


                if (HashPassword($"{password}{loginuser.Salt}") == loginuser.Password)
                {
                    return "Login Successful";
                }
                else
                {
                    return "Login Failed";
                }
            }
            return "User Not Found";
        }

        public static void Register(string name, string password)
        {
            using AppDataContext context = new AppDataContext();

            var salt = DateTime.Now.ToString();

            var HashedPW = HashPassword($"{password}{salt}");

            context.Users.Add(new User() { Name = name, Password = HashedPW, Salt = salt });
            context.SaveChanges();
        }


        public static string HashPassword(string password)
        {
            SHA256 hash = SHA256.Create();

            var passwordBytes = Encoding.Default.GetBytes(password);

            var hashedpassword = hash.ComputeHash(passwordBytes);

            return Convert.ToHexString(hashedpassword);
        }

    }
}

