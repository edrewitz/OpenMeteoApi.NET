
using Microsoft.Data.Analysis;

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
