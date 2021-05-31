using ExcelDataReader;
using System.IO;

namespace InterviewExerciseProject.Utilities
{
    public class ExternalData
    {
        public static string GetCellValueFromExcel(string filePath, string sheet, int rowNumber, int columnNumber)
        {
            using (var stream = File.Open(filePath,FileMode.Open,FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet().Tables[sheet];
                    var value = (string)result.Rows[rowNumber].ItemArray[columnNumber];
                    return value;
                }
            }
        }

    }
}
