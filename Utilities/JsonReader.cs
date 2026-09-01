using Newtonsoft.Json;
using SauceDemo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SauceDemo.Utilities
{
    public class JsonReader
    {

        public static List<LoginModel> ReadLoginData(string filePath)
        {
            string json = File.ReadAllText(filePath);

            return JsonConvert.DeserializeObject<List<LoginModel>>(json)
                   ?? new List<LoginModel>();
        }
    }
    
}

