using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Hashing
{
    //bizim için bir araç old. için çıplak kalabilir
    //hashing : karma 
    public class HashingHelper
    {
        //girdiimiz parolanın hash'ini oluşturucak metod
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key; //algoritmanın key değerini kullanıyoruz
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password)); //girilen pass'i byte çeviriyoruz
            }
        }

        //sisteme girilen parolanın doğrulunu karşılaştıran op.
        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            //şuan ki password kullanıcinin sonradan sisteme girdiği parola
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
