using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security
{
    public class HashingHelper
    {
        public static string Hashing(string Data)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(Data));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        //public void CreateID()
        //{
        //    string SifirEkle(string deger)
        //    {
        //        if (deger.Length == 1)
        //            return "0" + deger;
        //        return deger;
        //    }

        //    string UcBasamakYap(string deger)
        //    {
        //        switch (deger.Length)
        //        {
        //            case 1:
        //                return "00" + deger;
        //            case 2:
        //                return "0" + deger;
        //        }
        //        return deger;
        //    }
        //    string Id()
        //    {
        //        var yil = DateTime.Now.Date.Year.ToString();
        //        var ay = SifirEkle(DateTime.Now.Date.Month.ToString());
        //        var gun = SifirEkle(DateTime.Now.Date.Day.ToString());
        //        var saat = SifirEkle(DateTime.Now.Hour.ToString());
        //        var dakika = SifirEkle(DateTime.Now.Minute.ToString());
        //        var sn = SifirEkle(DateTime.Now.Second.ToString());
        //        var ms = UcBasamakYap(DateTime.Now.Millisecond.ToString());
        //        var random = SifirEkle(new Random().Next(0, 99).ToString());

        //        return yil + ay + gun + saat + dakika + sn + ms + random;
        //    }
        //}


        //public static string Key = "adef@@kfxcbc@" + DateTime.Now + "1-2-3-4-5-6-7-8-9-0";
        //public static string Hashing(string Data)
        //{
        //    if (string.IsNullOrEmpty(Data)) return "";
        //    Data += Key;
        //    var passBytes = Encoding.UTF8.GetBytes(Data);
        //    return Convert.ToBase64String(passBytes);
        //}

        //public static string DecryptHashing(string Data)
        //{
        //    if (string.IsNullOrEmpty(Data)) return "";
        //    var base64EncodeBytes = Convert.FromBase64String(Data);
        //    var result = Encoding.UTF8.GetString(base64EncodeBytes);
        //    result = result.Substring(0, result.Length - Key.Length);
        //    return result;
        //}
    }
}
