using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamWork
{
    //Methods for reading/writting and parsing CSV files. Mainly for the purpose of rating data.
    //http://www.dotnetperls.com/textfieldparser

    public static class RWFiles
    {
        public static string DEFAULT_PATH = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\TeamWork\Resource Files";

        //Method returns string with file name path
        public static string OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = DEFAULT_PATH;
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
                return openFileDialog.FileName;

            return String.Empty;
        }

        //Method parses text line into a string array
        public static string[] ParseLine(string csvLine)
        {
            char[] delimiter = new char[] { ',', ';' };
            string[] result = csvLine.Split(delimiter);

            return result;
        }

        //The method reads file, parse its data and returns the full content
        public static List<String[]> LoadFile(string fileName = "")
        {
            if (String.IsNullOrWhiteSpace(fileName))
                fileName = OpenFile();

            List<string[]> fileData = new List<string[]>();
            StreamReader reader = null;

            try
            {
                reader = new StreamReader(fileName, Encoding.UTF8);
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    if (String.IsNullOrWhiteSpace(line))
                        continue;

                    //If it is comment line
                    if (line[1] == '#')
                        continue;

                    fileData.Add(ParseLine(line));
                }
            }

            catch (System.IO.IOException ex)
            {
                throw new Exception("Error: Could not read file from disk. Original error: " + ex.Message);
            }

            finally
            {
                if (reader != null)
                    reader.Close();
            }

            return fileData;
        }

        //public static void WriteFile(string fileName, StringBuilder data)
        //{
        //    //TODO:
        //    //Write new or overwrites existing file with data
        //}

        //public static string WriteLine(IEnumerable plainData)
        //{
        //    string result = string.Empty;
        //    //TODO: Implementation
        //    //The method return CSV string.
        //    //The string needs to be appended to StreamBuiled and written in filter

        //    return result;
        //}
    }
}
