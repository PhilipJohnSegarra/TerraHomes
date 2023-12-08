﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TerraHomes
{
    public class DataSecure
    {
        public static string Encrypt(string data)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] passwordHash = Encoding.UTF8.GetBytes(data);

            return Encoding.UTF8.GetString(md5.ComputeHash(passwordHash));
        }
    }
}
