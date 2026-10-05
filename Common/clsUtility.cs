using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Common
{
    public class clsUtility
    {
        private static string EncryptionKey = "0123456789123456";

        public static string ComputeHash(string Text, string Salt)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(Text + Salt));

                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
        public static string ComputeHash(string Text)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(Text));

                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        public static string Encrypt(string plainText, string key)
        {
            using (Aes aesAlg = Aes.Create())
            {
                // Set the key and IV for AES encryption
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = new byte[aesAlg.BlockSize / 8];


                // Create an encryptor
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);


                // Encrypt the data
                using (var msEncrypt = new System.IO.MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    using (var swEncrypt = new System.IO.StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }


                    // Return the encrypted data as a Base64-encoded string
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }
        public static string Decrypt(string cipherText, string key)
        {
            using (Aes aesAlg = Aes.Create())
            {
                // Set the key and IV for AES decryption
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = new byte[aesAlg.BlockSize / 8];


                // Create a decryptor
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);


                // Decrypt the data
                using (var msDecrypt = new System.IO.MemoryStream(Convert.FromBase64String(cipherText)))
                using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                using (var srDecrypt = new System.IO.StreamReader(csDecrypt))
                {
                    // Read the decrypted data from the StreamReader
                    return srDecrypt.ReadToEnd();
                }
            }
        }

        public static byte[] ReadBytesFromFile(string filePath)
        {
            return System.IO.File.ReadAllBytes(filePath);
        }
        public static Bitmap ConvertBytesToImage(byte[] imageBytes)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    using (Image image = Image.FromStream(ms))
                    {
                        return new Bitmap(image);
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static bool IsEmail(string Email)
        {
            return Regex.IsMatch(Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
        public static bool IsPhoneNumber(string Phone)
        {
            return Regex.IsMatch(Phone, @"^\+?\d{10,15}$");
        }

        public static string DateTimeFormat(DateTime? date)
        {
            return date?.ToString("dd/MM/yyyy - h:mm:ss tt");
        }
        public static string DateFormat(DateTime? date)
        {
            return date?.ToString("dd/MM/yyyy");
        }
        public static string TimeFormat(DateTime? date)
        {
            return date?.ToString("h:mm tt");
        }

        public static void SetCredentials(string username, string password)
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\HMS"))
                {
                    key.SetValue("Username", clsUtility.Encrypt(username, EncryptionKey), RegistryValueKind.String);
                    key.SetValue("Password", clsUtility.Encrypt(password, EncryptionKey), RegistryValueKind.String);
                }
            }
            catch
            {
            }
        }
        public static bool GetCredentials(ref string username, ref string password)
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\HMS"))
                {
                    username = clsUtility.Decrypt((key?.GetValue("Username", null) as string), EncryptionKey);
                    password = clsUtility.Decrypt((key?.GetValue("Password", null) as string), EncryptionKey);
                }
            }
            catch
            {
                username = password = null;
            }

            return (username != null && password != null);
        }

        public static bool DeleteCredentials()
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\HMS"))
                {
                    key?.DeleteValue("Username", false);
                    key?.DeleteValue("Password", false);

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
