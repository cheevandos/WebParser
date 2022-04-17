using System;
using System.IO;

namespace MainLogic
{
    public static class FileHelper
    {
        public static void SaveFileFromString(string content, string path)
        {
            try
            {
                if (!File.Exists(path))
                {
                    File.WriteAllText(path, content);     
                }
            }
            catch(IOException ex)
            {
                throw new Exception($"IO Exception: {ex.Message}");
            }
            catch(Exception ex)
            {
                throw new Exception($"Exception: {ex.Message}");
            }
        }
    }
}
