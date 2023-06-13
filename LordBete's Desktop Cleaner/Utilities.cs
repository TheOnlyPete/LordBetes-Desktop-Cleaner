using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;


namespace LordBete_s_Desktop_Cleaner
{
	public static class Utilities
	{
		public static string[] CleanArrayFromString (string input)
        {
			return String.Join("", input.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries)).Split(',');
		}

		public static void CreateJsonFileFromFilterList(List<FileObject> fileObjects, string jsonPath)//This is ugly as hell but works well
		{
			if (!File.Exists(jsonPath))
				File.Create(jsonPath);

			string json = "[\n";

            for (int i = 0; i < fileObjects.Count; i++)
            {
				string formattedFileTypes = "";
                for (int j = 0; j < fileObjects[i].FileTypes.Length; j++)
                {
					formattedFileTypes += @"""" + fileObjects[i].FileTypes[j] + @"""";
					if(j != fileObjects[i].FileTypes.Length -1)
						formattedFileTypes += "," + " ";

					//"," + " ";
				}


				json += "	{\n" +
				 "	  " +	@"""Name""" + ":" + " " + @"""" + fileObjects[i].Name + @"""" + "," + "\n" +
				 "	  " + @"""DefaultLocation""" + ":" + " " + @"""" + "\\" +  fileObjects[i].DefaultLocation + @"""" + "," + "\n" +
				 "	  " + @"""FileTypes""" + ":" + " " + "[" + String.Join(@"""", formattedFileTypes) + "]" + "\n" +
				 "	" + "}";

                if (i != fileObjects.Count -1)
                {
					json += ",\n";
                }

			}

			json += "\n]";

			File.WriteAllText(jsonPath, json);

		}
		public static void CreateDirectoriesFileFromObject(DirectoryObject directoryObject, string jsonPath)
        {
			if (!File.Exists(jsonPath))
				File.Create(jsonPath);

			string json = "{\n";
			json += "	" + @"""" +  "SourceDirectory" + @"""" + ": " + @"""" +
					directoryObject.sourceDirectory.Replace("\\","\\\\") + @"""" + ",\n" + "	" + @""""  + "TargetDirectory" + @"""" + ": " + @"""" + 
					directoryObject.targetDirectory.Replace("\\", "\\\\") + @"""" + 
					"\n}";
			File.WriteAllText(jsonPath, json);
		}

        #region ErrorHandling
        public static void CleaningError(Exception e)
		{
			string Error = "An error occurred." + 
						   "\nEnsure your directories and filters are correct." + 
						   "\nFor more information, check the log file." + 
							"\n\nA log file has been created at:\n" +
							FileManager._programDataFolder + FileManager._auditDirectory + FileManager._errorFile; 

			ErrorHandler(e, Error);		
		}

		public static void ErrorHandler(Exception e, string errorMessage)
        {
			CreateAuditLog(e.ToString(), FileManager._programDataFolder + FileManager._auditDirectory, FileManager._errorFile);

			MessageBox.Show(errorMessage);
		}

		public static void JsonError(Exception e)
		{
			string error =  "There was a problem trying to load the json file containing your Filters.\nThe offending file has been renamed and settings have been restored to default.\n\nA Log file has been created at\n" + 
							FileManager._programDataFolder + FileManager._auditDirectory + FileManager._errorFile;
			FileManager.CreateDeadJsonFiles();
			FileManager.CreateFiltersFile();
			FileManager.CreateDirectoryFile();
			ErrorHandler(e, error);

		}
		#endregion
		public static void CreateAuditLog(string log, string _directory, string _filename)
		{
			if (!Directory.Exists(_directory))
				Directory.CreateDirectory(_directory);

			if (File.Exists(_directory + _filename))
            {
				string currentContent = File.ReadAllText(_directory + _filename);
				File.WriteAllText(_directory + _filename, AuditLogAppend() + log + currentContent);

			}
			else
				File.WriteAllText(_directory + _filename, AuditLogAppend()  + log);			
		}

		public static string AuditLogAppend()
        {
			string _header = "\n" + 
				"--------------------------------------------------------------------------\n" + 
				"			" + DateTime.Now.ToString() + "		\n" +
				"--------------------------------------------------------------------------\n";

			return _header;
        }
	}
}
