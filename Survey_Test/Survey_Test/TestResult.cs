using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Survey_Test
{
    internal class TestResult
    {
        public string name;
        public string surname;
        public int age;
        public string group;
        public string answer1;
        public List<string> answer2 = new List<string>() { };
        public string answer3;
        public string answer4;
        public string answer5;

        public void Serialize(string path)
        {
            string createText = name + '/' + surname + '/' + age.ToString() + '/' + group + '/' + answer1 + '/' +
            String.Join(",", answer2) + '/' + answer3 + '/' + answer4 + '/' + answer5;
            File.AppendAllText(path, createText + "\n");
        }
        public void Deserialize(string path, string CREATETEXT)
        {
            string[] createText = CREATETEXT.Split('/');
            name = createText[0];
            surname = createText[1];
            age = int.Parse(createText[2]);
            group = createText[3];
            answer1 = createText[4];
            answer2.AddRange(createText[5].Split(','));
            answer3 = createText[6];
            answer4 = createText[7];
            answer5 = createText[8];
        }
    }
}
