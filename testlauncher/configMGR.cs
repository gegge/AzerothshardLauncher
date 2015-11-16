using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace testlauncher
{
    class configMGR
    {
        string pathFileConfig = "";
        string filecontentstring = "";
        string[] filecontent;
        public configMGR()
        {
            pathFileConfig = "launcher.conf";
            filecontent = File.ReadAllLines(pathFileConfig);
            filecontentstring = File.ReadAllText(pathFileConfig);
        }

        public string getValue(string indexer)
        {
            string result = "";
            bool found = false;
            foreach (string line in filecontent)
            {
                if (!found)
                {
                    if (!line.Contains("#"))
                    {
                        if (line.Contains(indexer))
                        {
                            result = BetweenOfFixed(line, indexer + " = ", ";");
                            found = true;
                        }
                        else
                            result = "La chiave " + indexer + " non è stata trovata.";
                        //result = result + " - " + line;
                    }
                }
            }
            return result;
        }

        public void setValue(string oldValue, string newValue)
        {
            filecontentstring = filecontentstring.Replace(oldValue, newValue);
            File.WriteAllText(pathFileConfig, filecontentstring);
        }

        private static string BetweenOfFixed(string ActualStr, string StrFirst, string StrLast)
        {
            int startIndex = ActualStr.IndexOf(StrFirst) + StrFirst.Length;
            int endIndex = ActualStr.IndexOf(StrLast, startIndex);
            return ActualStr.Substring(startIndex, endIndex - startIndex);
        }

    }
}
