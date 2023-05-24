using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ser_Deser
{
    public class Ser_and_deser
    {
        public static void Serialize_All<T>(T data, string filePath)
        {
            string json = JsonConvert.SerializeObject(data);
            File.WriteAllText(filePath, json);
        }
        public static void Serialize_App<T>(T data, string filePath)
        {
            string json = JsonConvert.SerializeObject(data);
            File.AppendAllText(filePath, json);
        }

        public static T Deserialize<T>(string filePath)
        {
            string json = File.ReadAllText(filePath);
            T data = JsonConvert.DeserializeObject<T>(json);
            return data;
        }
    }
}
