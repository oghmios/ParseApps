﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseApps
{
    class FinalText
    {
        private List<String> finalText = new List<String>();

        public FinalText()
        {

        }


        public String GetTextFromFinal(int position)
        {
            return finalText[position];
        }
        public void SetFinalText(String text)
        {
            finalText.Add(text);
        }

        public void saveAndClose()
        {
            String filename = "parsedFile.csv";
            System.IO.File.WriteAllLines(filename, finalText);
            /*FileStream csvFile = new FileStream(filename, FileMode.Append);
            StreamWriter csvWriter = new StreamWriter(csvFile);
            
            for (int i = 0; i < finalText.Count; i++)
            {

                csvWriter.WriteLine(finalText[i]);
            }*/

        }
       
    }
}
