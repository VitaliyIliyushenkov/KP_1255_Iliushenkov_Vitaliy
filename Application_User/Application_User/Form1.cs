using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Application_User
{
    public partial class Form1 : Form
    {
        static string path = $@"{Environment.CurrentDirectory}\\Password_Generator.exe";
        static string arg;
        readonly List<Account> results = new List<Account>();
        readonly Dictionary<string, string> dictionary = new Dictionary<string, string>()
        {
            {"_","_"},
            {"а","a"},
            {"б","b"},
            {"в","v"},
            {"г","g"},
            {"д","d"},
            {"е","e"},
            {"ё","io"},
            {"ж","zh"},
            {"з","z"},
            {"и","i"},
            {"й","j"},
            {"к","k"},
            {"л","l"},
            {"м","m"},
            {"н","n"},
            {"о","o"},
            {"п","p"},
            {"р","r"},
            {"с","c"},
            {"т","t"},
            {"у","u"},
            {"ф","f"},
            {"х","h"},
            {"ц","ts"},
            {"ч","ch"},
            {"ш","sh"},
            {"щ","sch"},
            {"ъ",""},
            {"ы","y"},
            {"ь",""},
            {"э","e"},
            {"ю","ju"},
            {"я","ya" }
        };
        public Form1()
        {
            InitializeComponent();
            if (name_Box.Text != null) { LoginGenerator(); }
        }

        private void generation_btn_Click(object sender, EventArgs e)
        {
            arg = "";
            PasswordGenerator password_generator = new PasswordGenerator();

            if(lenght_numericUpDown.Value > 0 ) { arg += "--length=" + lenght_numericUpDown.Value.ToString() + " "; }
            if(special_checkBox.Checked ) { arg += "--special "; }
            if(upper_checkBox.Checked ) { arg += "--uppercase "; }
            if(letters_numericUpDown.Value > 0 ) { arg += "--letters=" + letters_numericUpDown.Value.ToString() + " "; }
            if(number_numericUpDown.Value > 0 ) { arg += "--digits=" + number_numericUpDown.Value.ToString() + " "; }

            Console.WriteLine(arg);
            password_Box.Text = (password_generator.RunApp(path, arg));
        }

        private void Name_Box_TextChanged(object sender, EventArgs e)
        {
            login_Box.Text = LoginGenerator();
        }
        private void Surname_Box_TextChanged(object sender, EventArgs e)
        {
            login_Box.Text = LoginGenerator();  
        }

        private string LoginGenerator()
        {
            string new_login = "";
            string login = (name_Box.Text + "_" + surname_Box.Text).ToLower();
            for(int i = 0; i < login.Length; i++) 
            {
                new_login += dictionary[login[i].ToString()];
            }
            return new_login;
        }
        Account CreateResult()
        {
            Account newResult = new Account
            {
                // заполнение данными
                name = name_Box.Text,
                surname = surname_Box.Text,
                birthday = dateTimePicker.Value,
                login = login_Box.Text,
                password = password_Box.Text
            };

            results.Add(newResult);

            return newResult;
        }
        void UpdateResultsList()
        {
            listBox.Items.Clear();

            foreach (Account result in results)
            {
                listBox.Items.Add(result.name);
            }
        }

        private void ListBoxAnswers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox.SelectedIndex;
            Account foundResult = results[index];
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            CreateResult();
            UpdateResultsList();
            ClearForm();
            
        }
        void ClearForm()
        {
            name_Box.Text = "";
            surname_Box.Text = "";
            dateTimePicker.Value = DateTime.Now;
            password_Box.Text = "";
            login_Box.Text = "";
        }
    }
}
