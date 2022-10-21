using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Rezerv_Copy
{
    public class Copy_Path 
    {
        public string source_path { get; set; }
        public string target_path { get; set; }
        
        public Copy_Path()
        {

        }
        public void Copy(string source_path, string target_path)
        {


            foreach (var directory in Directory.GetDirectories(source_path))
            {
                string dirName = Path.GetFileName(directory);
                if (!Directory.Exists(Path.Combine(target_path, dirName)))
                {
                    Directory.CreateDirectory(Path.Combine(target_path, dirName));
                }
                Copy(directory, Path.Combine(target_path, dirName));
            }

            foreach (var file in Directory.GetFiles(source_path))
            {
                File.Copy(file, Path.Combine(target_path, Path.GetFileName(file)));
            }
        }


    }
}