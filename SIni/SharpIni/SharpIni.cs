using System;
using System.Collections.Generic;
using System.Text;
using SharpFile;
using System.IO;

namespace SharpIni
{
    class SharpIni
    {
        private String fName = "";
        SF sf = null;
        public SharpIni(String fileName)
        {
            this.fName = fileName;
            if (!File.Exists(fName))
                File.Create(fName);
                
            sf = new SF(fName);
        }

        public void CreateSection(String section)
        {
            if(sf.OccurencesOf(section) == 0)
                sf.Append(section);
        }

        public void CreateKey(String section, String key, String value)
        {
            
        }

        public void SetKey(String section, String key, String value)
        {
        }
    }
}
