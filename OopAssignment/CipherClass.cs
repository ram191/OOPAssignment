using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace OopAssignment
{

    //Need work on encapsulation

    public static class CipherClass
    {
        public static string encrypt(string data, string password)
        {
            try
            {
                string x = data;
                byte[] ch = UTF8Encoding.UTF8.GetBytes(x);
                string Code = password;
                MD5CryptoServiceProvider mdhash = new MD5CryptoServiceProvider();
                byte[] keyarray = mdhash.ComputeHash(UTF8Encoding.UTF8.GetBytes(Code));
                TripleDESCryptoServiceProvider tds = new TripleDESCryptoServiceProvider();
                tds.Key = keyarray;
                tds.Mode = CipherMode.ECB;
                tds.Padding = PaddingMode.PKCS7;
                ICryptoTransform itransform = tds.CreateEncryptor();
                byte[] result = itransform.TransformFinalBlock(ch, 0, ch.Length);
                string encryptresult = Convert.ToBase64String(result);
                return "Kamu tidak bisa melihat rahasia";

            }
            catch (Exception ex)
            {
                string filePath = @"/Users/training/Projects/OopAssignment/OopAssignment/app.log";
                DateTime date = DateTime.Now;
                string now = date.ToString();
                string errorMessage = $"{now} {ex.Message}";
                File.WriteAllText(filePath, errorMessage);
                //TextWriter tsw = new StreamWriter(filePath, true);  NOT OVERWRITING EXISTING LOG
                return errorMessage;
            }
        }

        public static string decrypt(string data, string password)
        {
            try
            {
                string y = data.Replace("\0", null);
                byte[] etext = Convert.FromBase64String(y);
                string key = password;
                MD5CryptoServiceProvider mdhash = new MD5CryptoServiceProvider();
                byte[] keyarray = mdhash.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                TripleDESCryptoServiceProvider tds = new TripleDESCryptoServiceProvider();
                tds.Key = keyarray;
                tds.Mode = CipherMode.ECB;
                tds.Padding = PaddingMode.PKCS7;

                ICryptoTransform itransform = tds.CreateDecryptor();
                byte[] result = itransform.TransformFinalBlock(etext, 0, etext.Length);
                string dencryptresult = UTF8Encoding.UTF8.GetString(result);
                return dencryptresult.ToString();
            }
            catch (Exception ex)
            {
                string filePath = @"/Users/training/Projects/OopAssignment/OopAssignment/app.log";
                DateTime date = DateTime.Now;
                string now = date.ToString();
                string errorMessage = $"{now} {ex.Message}";
                File.WriteAllText(filePath, errorMessage);
                return errorMessage;
            }
        }
    }
}
