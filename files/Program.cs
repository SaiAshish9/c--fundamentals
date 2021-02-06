using System;
using System.IO;

namespace files
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.IO
            // File,FileInfo,Directory,DirectoryInfo,Path
            // FileInfo provides instance methods
            // File provides static methods
            // Create() Copy() Delete() Exists() GetAttributes() Move() ReadAllText()
            // DirectoryInfo provides instance methods
            // Directory provides static methods
            // CreateDirectory() Delete() Exists()
            // GetCurrentDirectory() GetFiles() Move()
            // GetLogicalDrives()

            // Path
            // GetDirectoryName() GetFileName() GetExtension() GetTempPath()

            var path = @"/home/saiashish9/Desktop/projects/c#/files.csproj";
            File.Copy(@"files.csproj", path, true);
            var content = File.ReadAllText(path);
            System.Console.WriteLine(content);
            if (File.Exists(path))
                File.Delete(path);

            // var fileInfo = new FileInfo(path);
            // fileInfo.CopyTo(@"");
            // fileInfo.Delete();
            // fileInfo.Exists()
            // fileInfo doesn't include ReadAllText method



            

        }
    }
}
