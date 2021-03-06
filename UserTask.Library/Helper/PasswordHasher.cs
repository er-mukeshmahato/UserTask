﻿using System;

using System.Security.Cryptography;


namespace UserTask.Library.Helper
{
    public sealed class PasswordHasher 
    {
        /// <summary>
        /// Size of salt
        /// </summary>
        private const int SaltSize = 16;
        /// <summary>
        /// Size of hash
        /// </summary>
        private const int HashSize = 20;
        /// <summary>
        /// Creates a hash from a password
        /// </summary>
        /// <param name="password">the password</param>
        /// <param name="iterations">number of iterations</param>
        /// <returns>the hash</returns>
        public string Hash(string password, int iterations)
        {
            //create salt
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[SaltSize]);
            //create hash
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
            var hash = pbkdf2.GetBytes(HashSize);
            //combine salt and hash
            var hashBytes = new byte[SaltSize + HashSize];
            Array.Copy(salt, 0, hashBytes, 0, SaltSize);
            Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);
            //convert to base64
            var base64Hash = Convert.ToBase64String(hashBytes);
            //format hash with extra information
            return string.Format("$UGCPSWHASH$V1${0}${1}", iterations, base64Hash);
        }
        /// <summary>
        /// Creates a hash from a password with 10000 iterations
        /// </summary>
        /// <param name="password">the password</param>
        /// <returns>the hash</returns>
        public string Hash(string password)
        {
            return Hash(password, 10000);
        }
        /// <summary>
        /// Check if hash is supported
        /// </summary>
        /// <param name="hashString">the hash</param>
        /// <returns>is supported?</returns>
        public bool IsHashSupported(string hashString)
        {
            return hashString.Contains("$UGCPSWHASH$V1$");
        }
        /// <summary>
        /// verify a password against a hash
        /// </summary>
        /// <param name="password">the password</param>
        /// <param name="hashedPassword">the hash</param>
        /// <returns>could be verified?</returns>
        public bool Verify(string password, string hashedPassword)
        {
            //check hash
            if (!IsHashSupported(hashedPassword))
            {
                throw new NotSupportedException("The hashtype is not supported");
            }
            //extract iteration and Base64 string
            var splittedHashString = hashedPassword.Replace("$UGCPSWHASH$V1$", "").Split('$');
            var iterations = int.Parse(splittedHashString[0]);
            var base64Hash = splittedHashString[1];
            //get hashbytes
            var hashBytes = Convert.FromBase64String(base64Hash);
            //get salt
            var salt = new byte[SaltSize];
            Array.Copy(hashBytes, 0, salt, 0, SaltSize);
            //create hash with given salt
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
            byte[] hash = pbkdf2.GetBytes(HashSize);
            //get result
            for (var i = 0; i < HashSize; i++)
            {
                if (hashBytes[i + SaltSize] != hash[i])
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// validate password 
        ///  At least one lower case letter,
        /// At least one upper case letter,
        ///At least special character,
        ///At least one number
        ///At least 8 characters length
        /// </summary>
        /// <param name="passWord validate"></param>
        /// <returns></returns>
        public bool ValidatePassword(string passWord)

        {

            int validConditions = 0;

            foreach (char c in passWord)

            {

                if (c >= 'a' && c <= 'z')

                {

                    validConditions++;

                    break;

                }

            }

            foreach (char c in passWord)

            {

                if (c >= 'A' && c <= 'Z')

                {

                    validConditions++;

                    break;

                }

            }

            if (validConditions == 0) return false;

            foreach (char c in passWord)

            {

                if (c >= '0' && c <= '9')

                {

                    validConditions++;

                    break;

                }

            }

            if (validConditions == 1) return false;

            if (validConditions == 2)

            {

                char[] special = { '@', '#', '$', '%', '^', '&', '+', '=' }; // or whatever

                if (passWord.IndexOfAny(special) == -1) return false;

            }

            return true;

        }

    }
}
