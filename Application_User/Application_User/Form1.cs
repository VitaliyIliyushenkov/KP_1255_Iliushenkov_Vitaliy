﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using System.Text.Json.Nodes;
using System.CodeDom.Compiler;

namespace Application_User
{
    public partial class Form1 : Form
    {
        string[] json_strings;
        string[] passwords;

        public Form1()
        {
            InitializeComponent();
        }

        private void guest_btn_Click(object sender, EventArgs e)
        {
            Program.user_key = (int)Program.Permissions.Guest;
            Form2 newForm = new Form2();
            newForm.Show();
            Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            json_strings = File.ReadAllLines(Program.path_date);
            passwords = File.ReadAllLines(Program.path_password);
            for(int i = 0; i < json_strings.Length; i++)
            {
                Program.results.Add(JsonSerializer.Deserialize<Account>(json_strings[i]));
                Program.results[i].PASSWORD = passwords[i];
            }
        }

        private void authoriz_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Program.results.Count; i++)
            {
                if (Program.results[i].LOGIN == login_box.Text)
                {
                    if (passwords[i] == password_box.Text) 
                    {
                        Program.user_name = Program.results[i].NAME;
                        Program.user_key = Program.results[i].usertype;
                        Form2 newForm = new Form2();
                        newForm.Show();
                        Hide();
                    }
                }
            }
        }
    }
}
