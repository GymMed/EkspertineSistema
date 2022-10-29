using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkspertineSistema
{
    public sealed class TextFixer
    {
        private TextFixer()
        {

        }

        private static TextFixer instance = null;

        public static TextFixer Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new TextFixer();
                }
                return instance;
            }
        }

        static public string Fix_Text(string text)
        {
            int textLength = text.Length;
            int insertsIndex = 1;

            string returnText = text;

            for(int currentChar = 0; currentChar < textLength; currentChar++)
            {
                if(currentChar > 40 * insertsIndex && text[currentChar] == ' ' && textLength > currentChar + 1)
                {
                    returnText = returnText.Insert(currentChar + 1, "\n");
                    insertsIndex++;
                }
            }

            return returnText;
        }
    }
}
