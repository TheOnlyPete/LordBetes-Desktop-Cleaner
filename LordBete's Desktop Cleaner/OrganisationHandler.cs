using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LordBete_s_Desktop_Cleaner
{
    //Currently I don't think this class is being used. Not sure why possibly was in the middle of migrating to it but never finished.
    class OrganisationHandler
    {
        private static OrganisationHandler _instance;
        private OrganisationHandler()
        {

        }
        public static OrganisationHandler GetInstance()
        {
            if (_instance != null) return _instance;
            return _instance = new OrganisationHandler();
        }
        public string RenameDuplicateFile(string file, int occurances)
        {

            string originalName = Path.GetFileName(file);
            string renamedFile = string.Format("{0}.{1}{2}", Path.GetFileNameWithoutExtension(file), "(" + occurances + ")", Path.GetExtension(file));
            return renamedFile;       
        }
        public void MoveFile(string source, string destination,string file)
        {
            if (!File.Exists(destination + "\\" + file))
            {
                File.Copy(file, destination + "\\" + file);
                File.Delete(file);
            }
            //else
            //    RenameFile(tmpFolder, tmpFileName, tmpFile);
        }
        public void MoveFilesByType(string source, string destination, string[] fileTypes)
        {

            foreach (string type in fileTypes)
            {
                string[] Files = System.IO.Directory.GetFiles(source, "*." + type, System.IO.SearchOption.TopDirectoryOnly);

                foreach (string file in Files)
                {
                    string fileName = Path.GetFileName(file);
                    if (!File.Exists(destination  + "\\" + fileName))//If file doesn't exist in target dir then move this file
                    {
                        File.Copy(file, destination  + "\\" + fileName);
                        File.Delete(file);
                    }
                    //else ////If file already exists in target dir, rename the file
                    //  RenameFile(destinationFolderName, fileName, file);

                }
            }
        }
        private static void CopyFilesRecursively(string sourcePath, string targetPath)
        {
            //Now Create all of the directories
            foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
            }

            //Copy all the files & Replaces any files with the same name
            foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
            {
                File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
            }
        }

        public void MoveFolders(string destination, string source)
        {

            if (!Directory.Exists(destination))            
                Directory.CreateDirectory(destination);
            
            //CopyFilesRecursively(source, destination);

        }

        public void CreateDirectory(string targetDirectory)
        {
            if (!Directory.Exists(targetDirectory))
                Directory.CreateDirectory(targetDirectory);
        }

        public void CreateSavedDirectoriesFile(string targetDirectory, string dirA, string dirB)
        {
            string file = targetDirectory + "\\" + "SavedDirectories.ini";
                using (StreamWriter sw = File.CreateText(targetDirectory + file))
                {
                    sw.WriteLine(dirA);
                    sw.WriteLine(dirB);
                    sw.Close();
                }

            
        }
    }


}
