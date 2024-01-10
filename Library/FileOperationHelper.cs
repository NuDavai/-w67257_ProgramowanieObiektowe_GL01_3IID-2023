using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Library
{
    public class FileOperationHelper
    {
        public static T ReadFile<T>(string fileName)
        {
            if (File.Exists(fileName))
            {
                var content = File.ReadAllText(fileName);

                return JsonSerializer.Deserialize<T>(content);
            }
            return default(T);
        }

        public static void WriteFile<T>(T data, string fileName)
        {
            var content = JsonSerializer.Serialize(data);

            File.WriteAllText(fileName, content);
        }
    }
}
