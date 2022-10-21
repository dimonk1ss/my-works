using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
namespace Rezerv_Copy
{
    public class Program
    {
        public static void Main(string[] args) {
            var configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile($"rcconfig1.json");
            var config = configurationBuilder.Build();
            var copyConfig = config
                .GetSection("Copy_Path");
            var c1 = new Copy_Path()
            {
                source_path = copyConfig.GetSection("source_path").Value,
                target_path = copyConfig.GetSection("target_path").Value
            };
            c1.Copy(c1.source_path, c1.target_path);

            
            
        }
    }
}
