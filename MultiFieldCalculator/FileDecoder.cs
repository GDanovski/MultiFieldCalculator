using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MultiFieldCalculator
{
    class FileDecoder
    {
        #region find all files in dir and subdirs
        public static List<string> TakeFileNames(string path)
        {
            List<string> dirList = new List<string>();

            if (File.Exists(path))
            {
                // This path is a file
                if (path.Substring(path.Length - 4, 4) == ".txt")
                    dirList.Add(path);
            }
            else if (Directory.Exists(path))
            {
                // This path is a directory
                ProcessDirectory(path,dirList);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Directory is not valid!\n" + path);
            }

            return dirList;
        }
        // Process all files in the directory passed in, recurse on any directories 
        // that are found, and process the files they contain.
        private static void ProcessDirectory(string targetDirectory, List<string> dirList)
        {
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory);

            foreach (string fileName in fileEntries)
                if (fileName.Substring(fileName.Length - 4, 4) == ".txt") 
                    dirList.Add(fileName);

            // Recurse into subdirectories of this directory.
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                ProcessDirectory(subdirectory, dirList);
        }
        #endregion find all files in dir and subdirs

        #region read All Corner Files
        public static string[] readCorners(List<string> dirs)
        {
            if(dirs.Count != 4)
            {
                System.Windows.Forms.MessageBox.Show("Incorrect number of corner files!");
                return null;
            }

            string[] corners = new string[dirs.Count];

            int counter = 0;
            for(int i = 0; i<dirs.Count; i++)
            {
                string dir = dirs[i];

                using (StreamReader reader = new StreamReader(dir))
                {
                    string line;
                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    while ((line = reader.ReadLine()) != null)
                    {
                        //line;
                        //if(line.IndexOf("Fields") > -1)
                        if (line.Length > 6 && line.Substring(0, 6) == "Fields")
                        {
                            corners[i] = line;
                            counter++;
                            break;
                        }
                    }
                }
            }

            if(counter != 4)
            {
                System.Windows.Forms.MessageBox.Show("Incorrect corner files!");
                return null;
            }

            return corners;
        }
        public static string[] readFields(List<string> dirs)
        {
            string[] corners = new string[dirs.Count];

            int counter = 0;
            for (int i = 0; i < dirs.Count; i++)
            {
                string dir = dirs[i];

                using (StreamReader reader = new StreamReader(dir))
                {
                    string line;
                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    while ((line = reader.ReadLine()) != null)
                    {
                        //line;
                        if (line.Length > 6 && line.Substring(0,6) == "Fields")
                        {
                            corners[i] = line;
                            counter++;
                            break;
                        }
                    }
                }
            }
            
            return corners;
        }
        #endregion read All Corner Files
    }
}
