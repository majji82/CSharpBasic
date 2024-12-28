namespace WorkingWithFiles
{
    class Program
    {

        static void FileOps()
        {

            var path = @"c:\somefile.jpg";
            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            File.Delete(path);

            if (File.Exists(path))
            {
                //
            }

            var content = File.ReadAllText(path);

            var fi = new FileInfo(path);
            fi.CopyTo("..");
            fi.Delete();

            if (fi.Exists)
            {
                //
            }
        }

        static void DirectoryOps()
        {
            Directory.CreateDirectory(@"c:\temp\folder1");
            var files = Directory.GetFiles(@"c:\Users\Lenovo\Desktop\CSharpBasic", "*.sln", SearchOption.AllDirectories);

            foreach (var file in files)
            {
                //Console.WriteLine(file);
            }

            var directories = Directory.GetDirectories(@"c:\Users\Lenovo\Desktop\CSharpBasic", "*", SearchOption.AllDirectories);
            foreach(var directory in directories)
            {
                Console.WriteLine(directory);
            }
        }

        static void pathOps()
        {
            var path = @"c:\Users\Lenovo\Desktop\CSharpBasic\WorkinggWithFiles\WorkingWithFiles.sln";

            Console.WriteLine(Path.GetExtension(path));
            Console.WriteLine(Path.GetFileName(path));
            Console.WriteLine(Path.GetFileNameWithoutExtension(path));
            Console.WriteLine(Path.GetDirectoryName(path));
        }
        static void Main(string[] args)
        {
            //FileOps();
            //DirectoryOps();
            pathOps();
        }
    }
}