using System.Text;
using System.Text.RegularExpressions;

namespace CamelCaser
{
    public static class StringExt
    {
        //https://stackoverflow.com/questions/13870725/how-to-search-and-replace-exact-matching-strings-only => sa_ddam213
        public static string SafeReplace(this string input, string find, string replace, bool matchWholeWord)
        {
            string textToFind = matchWholeWord ? string.Format(@"\b{0}\b", find) : find;
            return Regex.Replace(input, textToFind, replace);
        }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        readonly static char[] s_Delimiters = new char[] { ' ', '\r', '\n' };

        static List<string> s_Ignores = new List<string>()
        {
            "public", "private", "internal", "protected",
            "const", "union", "for", "foreach", "while", "do",
            "char", "string",
            "int", "uint",
            "short", "ushort",
            "byte", "sbyte",
            "namespace", "class", "struct",
            "void", "bool",
        };

        private void Convert_Click(object sender, EventArgs e)
        {
            string text = rawText.Text;

            if (!string.IsNullOrEmpty(ignoreItems.Text))
            {
                s_Ignores = ignoreItems.Text.Split(s_Delimiters).ToList();
            }

            string[] words = text.Split(s_Delimiters, StringSplitOptions.RemoveEmptyEntries);

            string word;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {
                word = words[i].Trim(s_Delimiters);

                if (word.StartsWith('"') || s_Ignores.Contains(word))
                    continue;

                char c;
                bool lastUnder = false;
                for (int j = 0; j < word.Length; j++)
                {
                    c = word[j];

                    if (c == '_')
                    {
                        lastUnder = true;
                        continue;
                    }

                    if (j== 0)
                    {
                        sb.Append(char.ToUpper(c));
                    }
                    else
                    {
                        if (lastUnder)
                        {
                            sb.Append(char.ToUpper(c));
                            lastUnder = false;
                        }
                        else
                        {
                            sb.Append(char.ToLower(c));
                        }
                    }
                }
                text = text.SafeReplace(word, sb.ToString(), true);
                sb.Clear();
            }

            resultText.Text = text;
        }


    }
}