
using System.Security.Cryptography;
using System.Text;

namespace Coffee_Shop_App.src.Utilities;

public class PasswordUtils
{
    public static void HashPasswrod(string plainPassword, out string hashedPassword, byte[] pepper)
    {

        var algo = new HMACSHA256(pepper);
        var  passToByte = Encoding.UTF8.GetBytes(plainPassword);

        hashedPassword = BitConverter.ToString(algo.ComputeHash(passToByte));
    }


    public static bool VerifyPassword(string plainPassword, string hashedPassword, byte[] pepper)
    {
        HashPasswrod(plainPassword, out string hashToCompare, pepper);
        return hashToCompare == hashedPassword; //time-attack

    }
}
