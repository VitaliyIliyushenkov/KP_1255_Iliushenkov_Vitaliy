using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace Survey_Test
{
    public partial class Form1 : Form
    {
        readonly List<TestResult> results = new List<TestResult>();
        public string Error;
        public string path;


        public Form1()
        {

            InitializeComponent();
            Settings();
            listBoxAnswers.SelectedIndexChanged += ListBoxAnswers_SelectedIndexChanged;
        }

        void Settings()
        {
            age_up_down.Minimum = 12;
            age_up_down.Maximum = 100;

            group_combo_box.Items.AddRange(new string[]
            { "1251", "1252", "1253", "1254", "1255" });

            answer3_combo_box.Items.AddRange(new string[]
            {"Прекрасно","Хорошо","Нейтрально","Не очень","Плохо"});

            answer4_dom_up_down.Items.AddRange(new string[]
                {"Времени","Свободы","Уважения","Заботы"});
        }
        void FillForm(TestResult result)
        {
            Acces(false);
            ClearForm();
            name_box.Text = result.name;
            surname_box.Text = result.surname;
            age_up_down.Value = result.age;
            group_combo_box.Text = result.group;

            foreach (RadioButton rb in answer1_box.Controls)
            {
                if (rb.Text == result.answer1)
                    rb.Checked = true;
            }
            foreach (CheckBox cb in answer2_box.Controls)
            {
                if (result.answer2.Contains(cb.Text))
                    cb.Checked = true;
            }
            answer3_combo_box.Text = result.answer3;
            answer4_dom_up_down.Text = result.answer4;
            answer5_rich_box.Text = result.answer5;

        }
        void Acces(bool Sw)
        {
            name_box.Enabled = Sw;
            surname_box.Enabled = Sw;
            age_up_down.Enabled = Sw;
            group_combo_box.Enabled = Sw;
            answer1_box.Enabled = Sw;
            answer2_box.Enabled = Sw;
            answer3_combo_box.Enabled = Sw;
            answer4_dom_up_down.Enabled = Sw;
            answer5_rich_box.Enabled = Sw;
            Save_btn.Enabled = Sw;
            buttonClearForm.Enabled = Sw;
        }
        private void Clear_Color()
        {
            name_box.BackColor = Color.Empty;
            surname_box.BackColor = Color.Empty;
            age_up_down.BackColor = Color.Empty;
            group_combo_box.BackColor = Color.Empty;
            answer1_box.BackColor = Color.White;
            answer2_box.BackColor = Color.White;
            answer3_combo_box.BackColor = Color.Empty;
            answer4_dom_up_down.BackColor = Color.Empty;
            answer5_rich_box.BackColor = Color.Empty;
        }
        private bool Debag()
        {
            int mis = 0;

            if (name_box.Text == "")
            {
                name_box.BackColor = Color.IndianRed;
                mis++;
            }
            else
                name_box.BackColor = Color.LightGreen;
            if (listBoxAnswers.Items.Contains(name_box.Text))
            {
                name_box.BackColor = Color.IndianRed;
                Error = "Пользователь с таким именем уже есть";
                mis++;
            }
            if (surname_box.Text == "")
            {
                surname_box.BackColor = Color.IndianRed;
                mis++;
            }
            else
                surname_box.BackColor = Color.LightGreen;
            if (age_up_down.Text == "")
            {
                age_up_down.BackColor = Color.IndianRed;
                mis++;
            }
            else
                age_up_down.BackColor = Color.LightGreen;
            if (group_combo_box.Text == "")
            {
                group_combo_box.BackColor = Color.IndianRed;
                mis++;
            }
            else
                group_combo_box.BackColor = Color.LightGreen;

            bool i = false;
            foreach (RadioButton rb in answer1_box.Controls)
            {
                if (rb.Checked)
                {
                    answer1_box.BackColor = Color.LightGreen;
                    i = true;
                }

            }
            if (i == false)
            {
                answer1_box.BackColor = Color.IndianRed;
                mis++;
            }

            i = false;
            foreach (CheckBox cb in answer2_box.Controls)
            {
                if (cb.Checked)
                {
                    answer2_box.BackColor = Color.LightGreen;
                    i = true;
                }
            }
            if (i == false)
            {
                answer2_box.BackColor = Color.IndianRed;
                mis++;
            }
            if (answer3_combo_box.Text == "")
            {
                answer3_combo_box.BackColor = Color.IndianRed;
                mis++;
            }
            else
                answer3_combo_box.BackColor = Color.LightGreen;
            if (answer4_dom_up_down.Text == "")
            {
                answer4_dom_up_down.BackColor = Color.IndianRed;
                mis++;
            }
            else
                answer4_dom_up_down.BackColor = Color.LightGreen;
            if (answer5_rich_box.Text == "")
            {
                answer5_rich_box.BackColor = Color.IndianRed;
                mis++;
            }
            else
                answer5_rich_box.BackColor = Color.LightGreen;


            if (mis == 0) return true;
            else return false;
        }

        void ClearForm()
        {
            name_box.Text = "";
            surname_box.Text = "";
            age_up_down.Value = age_up_down.Minimum;
            group_combo_box.Text = "";

            foreach (RadioButton rb in answer1_box.Controls)
            {
                if (rb.Checked)
                    rb.Checked = false;
            }
            foreach (CheckBox cb in answer2_box.Controls)
            {
                if (cb.Checked)
                    cb.Checked = false;
            }
            answer3_combo_box.Text = "";
            answer4_dom_up_down.Text = "";
            answer5_rich_box.Text = "";
        }

        TestResult CreateResult()
        {
            TestResult newResult = new TestResult
            {
                // заполнение данными
                name = name_box.Text,
                surname = surname_box.Text,
                age = (int)age_up_down.Value,
                group = group_combo_box.Text
            };

            foreach (RadioButton rb in answer1_box.Controls)
            {
                if (rb.Checked)
                    newResult.answer1 = rb.Text;
            }

            foreach (CheckBox cb in answer2_box.Controls)
            {
                if (cb.Checked)
                    newResult.answer2.Add(cb.Text);
            }

            newResult.answer3 = answer3_combo_box.Text;
            newResult.answer4 = answer4_dom_up_down.Text;
            newResult.answer5 = answer5_rich_box.Text;
            results.Add(newResult);

            return newResult;
        }
        void UpdateResultsList()
        {
            listBoxAnswers.Items.Clear();

            foreach (TestResult result in results)
            {
                listBoxAnswers.Items.Add(result.name);
            }
        }

        private void ListBoxAnswers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxAnswers.SelectedIndex;
            TestResult foundResult = results[index];
            FillForm(foundResult);
        }

        private void ButtonClearForm_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Очистить форму?", "Предупреждение",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Exclamation);

            if (dialogResult == DialogResult.Yes)
                ClearForm();
        }

        private void Download_button_Click(object sender, EventArgs e)
        {
            results.Clear();
            OpenFileDialog od = new OpenFileDialog();
            if (od.ShowDialog() == DialogResult.OK)
            {
                path = od.FileName;
            }

            if (File.Exists(path))
            {
                for (int i = 0; i < File.ReadAllLines(path).Length; i++)
                {
                    TestResult newResult = new TestResult();
                    newResult.Deserialize(path, File.ReadAllLines(path)[i]);
                    results.Add(newResult);
                    UpdateResultsList();
                }
            }
        }

        private void Add_new_file_Click(object sender, EventArgs e)
        {
            Acces(true);
            ClearForm();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            Error = "Заполните все поля";
            {
                if (Debag() == false)
                {
                    _ = MessageBox.Show(Error, "Предупреждение",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Exclamation);
                }
                else
                {
                    CreateResult();
                    UpdateResultsList();
                    ClearForm();
                }
                Clear_Color();
            }
        }

        private void Save_file_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            if (od.ShowDialog() == DialogResult.OK)
            {
                path = od.FileName;
            }
            if (File.Exists(path))
            {
                File.WriteAllText(path, "");
                for (int index = 0; index < results.Count; index++)
                {
                    TestResult saveResult = results[index];
                    saveResult.Serialize(path);
                }
            }
        }
    }
}
