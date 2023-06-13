using System;
using System.IO;
using System.Collections.Generic;

namespace LordBete_s_Desktop_Cleaner
{

    public static class FileManager
    {
        public const string _programDataFolder = @"C:\ProgramData\LordBetes Desktop Organiser"; //ProgramData Folder Location
        public const string _directoriesFile = @"\Directories.json"; //Json file for saved directories.
        public const string _filtersJsonFile = @"\Filters.json";//Json file containing saved filters.
        public const string _auditDirectory = @"\Audit";
        public const string _ConfigFolder = @"\Config";
        public const string _fileHistoryAudit = @"\Audit_FileHistory.txt";
        public const string _errorFile = @"\Audit_Errors.txt";

        public static string UniqueFilename()
        {
            return DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() + DateTime.Now.ToString("ddMMyyyy");
        }

        public static int TotalFileCount(DirectoryObject _directoryObject)
        {
            int fCount = 0;
            try 
            { 
                if(Directory.Exists((_directoryObject.sourceDirectory)))
                    fCount = Directory.GetFiles(_directoryObject.sourceDirectory, "*", SearchOption.AllDirectories).Length;
            }
            catch(Exception e)
            {
                Utilities.ErrorHandler(e, "Source Directory Does Not Exist.");
                fCount = 0;
            }

            return fCount;
        }

        #region Move Files
        public static void MoveFiles(FileObject _FileObject, DirectoryObject _directoryObject)
        {
            try
            {
                foreach (string type in _FileObject.FileTypes)
                {
                    string[] Files = new string[0];
                    if(Directory.Exists(_directoryObject.sourceDirectory)) //Does the directory exist?
                    if (Directory.GetFiles(_directoryObject.sourceDirectory + "\\", "*." + type, SearchOption.TopDirectoryOnly).Length != 0)//Are there any files in the directories?               
                       Files = Directory.GetFiles(_directoryObject.sourceDirectory + "\\", "*." + type, SearchOption.TopDirectoryOnly); //If so set "Files" to the files in the directory

                    

                    foreach (string file in Files)
                    {

                        string fileName = Path.GetFileName(file);

                        if (!Directory.Exists(_directoryObject.targetDirectory + _FileObject.DefaultLocation))
                            Directory.CreateDirectory(_directoryObject.targetDirectory + _FileObject.DefaultLocation);

                        if (!File.Exists(_directoryObject.targetDirectory + _FileObject.DefaultLocation + "\\" + fileName))//If file doesn't exist in target dir then move this file
                        {
                            File.Copy(file, _directoryObject.targetDirectory + _FileObject.DefaultLocation + "\\" + fileName);
                            File.Delete(file);
                            Utilities.CreateAuditLog("Moved File: " + fileName + " From: " + _directoryObject.sourceDirectory + " To: " + _directoryObject.targetDirectory + _FileObject.DefaultLocation, _programDataFolder + _auditDirectory, _fileHistoryAudit);
                        }
                        else //If file already exists in target dir, rename the file using the number of duplicate files for example file.png becomes file.(1).png
                        {
                            int occurances = 1;
                            string renamedFile = FileManager.RenameFile(fileName, occurances);
                            while (File.Exists(_directoryObject.targetDirectory + _FileObject.DefaultLocation + "\\" + renamedFile))
                            {
                                occurances++;
                                renamedFile = FileManager.RenameFile(fileName, occurances);
                            }

                            Utilities.CreateAuditLog("Renamed File: " + fileName + " To: " + renamedFile, _programDataFolder + _auditDirectory, _fileHistoryAudit);

                            if (!File.Exists(_directoryObject.targetDirectory + _FileObject.DefaultLocation + "\\" + renamedFile))
                                FileManager.PlaceSingleFile(file, _directoryObject.targetDirectory + _FileObject.DefaultLocation + "\\" + renamedFile, _directoryObject);
                        }
                        DirectoryManager.GetInstance().value++;//This is a bit dirty but it works

                    }
                }
            }
            catch (Exception e)
            {
                Utilities.CleaningError(e);
                return;

            }


        }
        #endregion

        public static void CreateFolders(DirectoryObject _directoryObject)
        {
            string[] Folders = GetAllFolders(_directoryObject);

            foreach (string folder in Folders)
            {
                Directory.CreateDirectory(_directoryObject.targetDirectory + "\\Folders" + folder); // Create those same folders in our target directory
            }
        }



        public static void CopyFilesRecursively(DirectoryObject _directoryObject)//This is when copying FOLDERS containing files
        {
            try
            {
                var t = Directory.GetDirectories(_directoryObject.sourceDirectory, "*", SearchOption.AllDirectories); // Get all the directories inside the source path
                string targetPathFolder = "";
                if (t.Length == 0)//If there are none
                    Console.WriteLine("No directories found");//When finished change this to return;
                else //If there are folders inside the source directory
                {
                    //Create all of the new directories using the source directory 
                    string[] Folders = GetAllFolders(_directoryObject);

                    foreach (string folder in Folders)
                    {
                        targetPathFolder = new DirectoryInfo(folder).Name;
                        foreach (string newFile in Directory.GetFiles(_directoryObject.sourceDirectory + folder, "*.*", SearchOption.TopDirectoryOnly))
                        {


                            string filePath = newFile;
                            string file = Path.GetFileName(newFile);

                            if (!File.Exists(_directoryObject.targetDirectory + "\\Folders" + folder + "\\" + file))
                            {
                                File.Copy(filePath, _directoryObject.targetDirectory + "\\Folders" + folder + "\\" + file);
                                File.Delete(filePath);
                                Utilities.CreateAuditLog("Moved File: " + file + " From: " + _directoryObject.sourceDirectory + " To: " + _directoryObject.targetDirectory + "\\Folders" + folder, _programDataFolder + _auditDirectory, _fileHistoryAudit);
                            }
                            else
                            {
                                int occurances = 1;
                                string renamedFile = FileManager.RenameFile(file, occurances);
                                if (File.Exists(filePath))
                                {
                                    while (File.Exists(_directoryObject.targetDirectory + "\\Folders" + folder + "\\" + renamedFile))
                                    {
                                        occurances++;
                                        renamedFile = RenameFile(file, occurances);
                                        Utilities.CreateAuditLog("Renamed File: " + file + " To: " + renamedFile, _programDataFolder + _auditDirectory, _fileHistoryAudit);
                                    }

                                    if (!File.Exists(_directoryObject.targetDirectory + "\\Folders" + folder + "\\" + renamedFile))
                                        PlaceSingleFile(
                                            _directoryObject.sourceDirectory + folder + "\\" + Path.GetFileName(filePath),
                                            _directoryObject.targetDirectory + "\\Folders\\" + folder + "\\" + renamedFile,
                                            _directoryObject
                                            );

                                }


                                DirectoryManager.GetInstance().value++;//This is a bit dirty but it works


                            }


                        }


                    }
                    
                    
                }


                RecursivelyDeleteSourceFolders(_directoryObject);

            }
            catch (Exception e)
            {
                Utilities.CleaningError(e);
                return;
            }

        }
        public static void PlaceSingleFile(string originPath, string destinationPath, DirectoryObject _directoryObject)
        {
            if (!File.Exists(destinationPath))
            {
                File.Copy(originPath, destinationPath, false);
                File.Delete(originPath);
                Utilities.CreateAuditLog("Moved File: " + Path.GetFileName(destinationPath) + " From: " + _directoryObject.sourceDirectory + " To: " + Path.GetDirectoryName(destinationPath), _programDataFolder + _auditDirectory, _fileHistoryAudit);
            }
        }
        public static void RecursivelyDeleteSourceFolders(DirectoryObject _directoryObject)
        {
            foreach (var subDir in new DirectoryInfo(_directoryObject.sourceDirectory).GetDirectories())
            {
                subDir.Delete(true);
            }

            
        }
        public static string RenameFile(string file, int occurances)
        {

            // string originalName = fileName;
            string renamedFile = string.Format("{0}.{1}{2}", Path.GetFileNameWithoutExtension(file), "(" + occurances + ")", Path.GetExtension(file)); // Breakdown the filename into FILENAME (Number of occurances) .FILETYPE
            return renamedFile;
        }

        public static void CreateDeadJsonFiles()
        {
            if (!Directory.Exists(_programDataFolder + _ConfigFolder + "\\Dead Files\\"))
                Directory.CreateDirectory(_programDataFolder + _ConfigFolder + "\\Dead Files\\");

            if (File.Exists(_programDataFolder + _ConfigFolder + "\\Dead Files" + _filtersJsonFile))
                File.WriteAllText(_programDataFolder + _ConfigFolder + "\\Dead Files\\" + _filtersJsonFile + ".Dead" + UniqueFilename(), File.ReadAllText(_programDataFolder + _ConfigFolder + _filtersJsonFile));

            if (File.Exists(_programDataFolder + _ConfigFolder + "\\Dead Files" + _directoriesFile))
                File.WriteAllText(_programDataFolder + _ConfigFolder + "\\Dead Files\\" + _directoriesFile + ".Dead" + UniqueFilename(), File.ReadAllText(_programDataFolder + _ConfigFolder + _directoriesFile));
        }

        public static void CreateFiltersFile()
        {
            if (!Directory.Exists(_programDataFolder + _ConfigFolder))
                Directory.CreateDirectory(_programDataFolder + _ConfigFolder);

            using (StreamWriter sw = File.CreateText(_programDataFolder + _ConfigFolder + _filtersJsonFile))
            {
                sw.WriteLine(new FileObjectJsonDefaults().json);
                sw.Close();
            }
        }

        public static void CreateDirectoryFile()
        {
            if (!Directory.Exists(_programDataFolder + _ConfigFolder))
                Directory.CreateDirectory(_programDataFolder + _ConfigFolder);

            using (StreamWriter sw = File.CreateText(_programDataFolder + _ConfigFolder + _directoriesFile))
            {
                sw.WriteLine(new DirectoryObjectDefaults().json);
                sw.Close();
            }

        }
        public static void MoveFolders(DirectoryObject _directoryObject)
        {
            try
            {
                CreateFolders(_directoryObject);

                CopyFilesRecursively(_directoryObject);

            }
            catch (Exception e)
            {
                Utilities.CleaningError(e);
                return;
            }

        }
        public static void DeleteFile(string _directory, string _filename)
        {
            if (File.Exists(_directory + _filename))
                File.Delete(_directory + _filename);
        }

        public static string[] GetAllFolders(DirectoryObject _directoryObject)
        {
            List<string> folders = new List<string>();
            GetAllSubfolders(_directoryObject.sourceDirectory, folders, _directoryObject);
            return folders.ToArray();
        }

        private static void GetAllSubfolders(string directoryPath, List<string> folders, DirectoryObject _directoryObject)
        {
            try
            {
                // Recursively call the function for each subdirectory
                foreach (string subfolder in Directory.GetDirectories(directoryPath))
                {
                    string tempSubFolder = subfolder;
                    int i = tempSubFolder.IndexOf(directoryPath);
                    if (i >= 0) tempSubFolder = tempSubFolder.Substring(i + _directoryObject.sourceDirectory.Length);
                    folders.Add(tempSubFolder);
                    GetAllSubfolders(subfolder, folders, _directoryObject);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
