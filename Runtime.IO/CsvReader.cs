using System;
using System.Collections.Generic;

namespace Runtime.IO
{
    /// <summary>
    /// Provides a comma seperated data reader.
    /// </summary>
    public sealed class CsvReader
    {
        #region === member variables ===
        /// <summary></summary>
        private readonly string[] lines;
        /// <summary></summary>
        private int lineNum;
        /// <summary></summary>
        private CsvReadSettings settings; 
        #endregion

        #region === constructor ===
        /// <summary>
        /// Returns a new instance of the reader using the provided filename using default settings.
        /// </summary>
        /// <param name="fileName">Filename of the csv file.</param>
        public CsvReader(string fileName) : this(fileName, new CsvReadSettings())
        {
            Assert.Required(fileName, "A filename must be provided");
        }

        /// <summary>
        /// Returns a new instance of the reader using the provided filename using specific settings.
        /// </summary>
        /// <param name="fileName">Filename of the csv file.</param>
        /// <param name="readSettings">Settings to open the reader.</param>
        public CsvReader(string fileName, CsvReadSettings readSettings)
        {
            lines = System.IO.File.ReadAllLines(fileName, readSettings.Encoding);
            settings = readSettings;
            lineNum = 0;
            if (!readSettings.SkipFirstLine)
                lineNum = -1;
        }
        #endregion

        #region === public properties ===
        /// <summary>
        /// Returns true whist reading if possible.
        /// </summary>
        /// <returns></returns>
        public bool Read()
        {
            if (lineNum > (lines.Length - 2))
                return false;

            lineNum += 1;
            return true;
        }
        /// <summary>
        /// Returns the line of the current position.
        /// </summary>
        public string Line
        {
            get
            {
                return lines[lineNum];
            }
        }
        #endregion

        #region === public methods ===
        /// <summary>
        /// Reads a value from the field number.
        /// </summary>
        /// <param name="fieldNum"></param>
        /// <returns></returns>
        public string GetValue(int fieldNum)
        {
            string newLine = "";
            bool insideText = false;
            foreach (var c in Line)
            {
                if (c == settings.TextQualifier)
                    insideText = !insideText;
                if (c == settings.FieldSplitter && !insideText)
                {
                    newLine += "\t";
                    continue;
                }
                newLine += c;
            }
            string[] values = newLine.Split('\t');
            return values[fieldNum];
        } 
        #endregion
    }
}
