
using Microsoft.Data.Analysis;
using System;
using System.IO;

namespace OpenMeteoApiNet.Utils.BuildDirectory
{
    public static class DirectoryBuilder
    {
        public static void BuildDirectory(string directoryPath)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
        }

    }
    public static class DirectoryHelper
    {
        public static string GetCurrentDirectory()
        {
            return Directory.GetCurrentDirectory();
        }

    }
}

namespace OpenMeteoApiNet.Utils.DataArchive
{
    public static class ArchiveData
    {
        public static void SaveDataToCsv(string filePath, string fileName, DataFrame data)
        {
            DataFrame.SaveCsv(data, $"{filePath}/{fileName}", separator: ',');

        }
    }
}



