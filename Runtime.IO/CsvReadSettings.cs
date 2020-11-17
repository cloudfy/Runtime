using System.Text;

namespace Runtime.IO
{
    /// <summary>
    /// 
    /// </summary>
    public class CsvReadSettings
    {
        public bool SkipFirstLine = false;
        public char FieldSplitter = ',';
        public char TextQualifier = '"';

        /// <summary>
        /// 
        /// </summary>
        public CsvReadSettings()
        {

        }

        /// <summary></summary>
        public Encoding Encoding = System.Text.Encoding.UTF8;
    }
}
