using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ArMaGen
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = Directory.EnumerateFiles(Environment.CurrentDirectory, args[0]);
            File.WriteAllText(Path.Combine(Environment.CurrentDirectory, "artifacts.json"), JsonConvert.SerializeObject(new { artifacts = files }));
        }
    }
}
