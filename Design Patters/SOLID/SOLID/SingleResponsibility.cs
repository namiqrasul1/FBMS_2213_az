//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography;
//using System.Text;
//using System.Threading.Tasks;
//using static System.Console;

//namespace SOLID
//{
//    public static class Mail
//    {
//        public static void SendMail(string email, string content)
//        {
//            if (IsValidMail(email))
//            {
//                // send mail
//                return;
//            }
//            throw new Exception("Email is not valid");
//        }

//        public static bool IsValidMail(string email)
//        {
//            // some amazing code 
//            return !string.IsNullOrWhiteSpace(email);
//        }
//    }

//    public static class Hasher
//    {
//        public static string GetHash(string source)
//        {
//            using SHA256 sha256Hash = SHA256.Create();

//            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(source));


//            StringBuilder builder = new StringBuilder();
//            for (int i = 0; i < bytes.Length; i++)
//            {
//                builder.Append(bytes[i].ToString("x2"));
//            }
//            return builder.ToString();
//        }
//    }
//    public class MainViewModel
//    {
//        public void SendMail(string email, string content) => Mail.SendMail(email, content);

//        public bool LoginCommand(string username, string password)
//        {
//            var hashPass = Hasher.GetHash(password); //hashing
//            // checking;
//            return true;
//        }

//    }

//    public class Program
//    {
//        static void Main(string[] args)
//        {
            
//        }
//    }
//}
