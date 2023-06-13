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
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Reflection;
namespace LordBete_s_Desktop_Cleaner
{
    public class DirectoryManager
    {
        private static DirectoryManager _instance;
        private DirectoryManager()
        {
            InitialiseFileObjects();
            InitialiseDirectoryObject();
        }
        public static DirectoryManager GetInstance()
        {
            if (_instance != null) return _instance;
            return _instance = new DirectoryManager();
        }

        public int max; // Progress bar maximum value
        public int value; //Progress bar current value
        public List<FileObject> Filters = new List<FileObject>();
        public DirectoryObject _directoryObject = new DirectoryObject();
        public Form directoryCleaner;
        public Form cleanerSettings;
        public LordBetesDirectoryCleaner cleaner;
        public LordBetesDirectoryCleanerSettings settings;
        public int filterNumber;
        public bool Finished = false;
        public void CleanDirectory()
        {
            if (_directoryObject.sourceDirectory != null && _directoryObject.targetDirectory != null)
            {
                InitialiseFileObjects();
                InitialiseDirectoryObject();
                MoveFileObjects();
                FileManager.MoveFolders(_directoryObject);
                MoveAll();
                Finished = true;
            }
            else            
                MessageBox.Show("You haven't chosen the directory to clean or directory to move files into.");
            
        }
        public void InitialiseFileObjects()
        {
            try
            {
                string jsonText = File.ReadAllText(FileManager._programDataFolder + FileManager._ConfigFolder + FileManager._filtersJsonFile);
                List<FileObject> fileObjects = JsonConvert.DeserializeObject<List<FileObject>>(jsonText);
                foreach (FileObject fo in fileObjects) { Filters.Add(fo); }
            }
            catch (Exception e)
            {
                Utilities.JsonError(e);                
                InitialiseFileObjects();
            }
  

        }

        public void InitialiseDirectoryObject()
        {
            try
            {
                string jsonText = File.ReadAllText(FileManager._programDataFolder + FileManager._ConfigFolder + FileManager._directoriesFile);
                jsonText.Replace("\\\\", "\\");
                _directoryObject = JsonConvert.DeserializeObject<DirectoryObject>(jsonText);
            }
            catch (Exception e)
            {

                Utilities.JsonError(e);
                InitialiseDirectoryObject();
            }
        }
        public void UpdateJsonObjects()
        {
            Utilities.CreateJsonFileFromFilterList(Filters, FileManager._programDataFolder + FileManager._ConfigFolder + FileManager._filtersJsonFile);
            Utilities.CreateDirectoriesFileFromObject(_directoryObject, FileManager._programDataFolder + FileManager._ConfigFolder + FileManager._directoriesFile);
        }

        public void MoveFileObjects()
        {
            foreach (FileObject fo in Filters)
            {
                FileManager.MoveFiles(fo, _directoryObject);
                filterNumber++;
            }
        }
        public void MoveAll()
        {
            FileObject FO = new FileObject()
            {
                Name = "Misc",
                DefaultLocation = "\\Misc",
                FileTypes = new string[] { "*" }

            };

            FileManager.MoveFiles(FO, _directoryObject);
        }
       
        
    }
}
