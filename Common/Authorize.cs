using System;
using System.Security.Cryptography;

namespace fms.Common
{
    public class Authorize
    {
        public Authorize()
        {
        }

        public string generateHashPassword(string password)
        {
            string result = "";

            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36];

            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            result = Convert.ToBase64String(hashBytes);

            return result;
        }

        public bool validateLoginPassword(string password, string savedPasswordHash)
        {
            bool result = true;
            byte[] hashBytes = Convert.FromBase64String(savedPasswordHash);
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            int check = 0;

            for (int i = 0; i < 20; i++)
                if (hashBytes[i + 16] != hash[i])
                    check += 1;

            if (check > 0)
                result = false;

            return result;
        }
    }
}
