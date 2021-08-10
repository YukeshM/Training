//Preparation: Create folder structures of upto 3 level hierarchy,
//create several text files with random content
//a)  some of the files can contain text phrase - ""Gislen software"
//b) Create several image files (jpg, png, svg) 
//Program
//a ) Implement a program to traverse through inner folder structure and access all the text files.
//If the text file contains data like "Gislen software" , copy those files to a new location
//b) Implement a program to traverse through all folders and if the file format is  ,
//jpg  and the size is less than 3 mb, cut and move the files to a new directory.


using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Aug9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"D:\gislen\cSharp\Newfolder\Newfolder1";
            string duplicatePath = @"D:\gislen\cSharp\Newfolder\Newfolder1\duplicate\";

            //creating directory
            if (!(Directory.Exists(rootPath)))
            {
                Directory.CreateDirectory(rootPath);
            }

            if (!(Directory.Exists(duplicatePath)))
            {
                Directory.CreateDirectory(duplicatePath);
            }
            

            string[] files = Directory.GetFiles(rootPath);
            
            foreach (string file in files)
            {
                FileInfo newFile = new FileInfo(file);


                var text = File.ReadAllText(file);
                //Console.WriteLine(text);
                if (Regex.IsMatch(file, @"\.txt$") && text.Contains("gislen software"))
                {
                    var pathString = Path.Combine(duplicatePath, newFile.Name);
                    File.Copy(file, pathString);
                }

                if (Regex.IsMatch(file, @"\.jpg$|\.png$|\.gif$") && newFile.Length <= 2e+6)
                {
                    var pathString = Path.Combine(duplicatePath, newFile.Name);
                    File.Move(file, pathString);
                }
            }













            //string[] directories = Directory.GetDirectories(rootPath, "*", SearchOption.TopDirectoryOnly);

            //foreach (string item in directories)
            //{
            //    Console.WriteLine(item);
            //}

            //var files = Directory.GetFiles(rootPath, "*.*", SearchOption.TopDirectoryOnly);
            //foreach (string file  in files)
            //{
            //    //getting file info
            //    var info = new FileInfo(file);
            //    Console.WriteLine($"{Path.GetFileName(file)} : {info.Length} bytes");



            //get file name only
            //Console.WriteLine(Path.GetFileName(file));

            //get file name without extensions
            //Console.WriteLine(Path.GetFileNameWithoutExtension(file));


            //get directories and file name
            //Console.WriteLine(file);
            //}


        }
    }
}
