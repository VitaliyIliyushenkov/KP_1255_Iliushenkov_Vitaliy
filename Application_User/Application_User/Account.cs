using System;
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
using System.Text.Json.Serialization;

namespace Application_User
{
    public class Account
    {
        string json;
        public string name;
        public string surname;
        public string login;
        public string password;
        public DateTime birthday;
        public int usertype;


        public string NAME
        {
            get { return name; }
            set { name = value; }
        }
        public string SURNAME
        {
            get { return surname;}
            set { surname = value;}
        }
        public string LOGIN
        {
            get { return login;}
            set { login = value;}
        }
        [JsonIgnore]
        public string PASSWORD
        {
            get { return password; }
            set { password = value; }
        }
        public DateTime BIRTHDAY
        {
            get { return birthday; }
            set { birthday = value;}
        }
        public int USERTYPE
        {
            get { return usertype; }
            set { usertype = value; }
        }
        public string Serialize()
        {
            json = JsonSerializer.Serialize(this);
            File.AppendAllText(Program.path_date, json + "\n");
            File.AppendAllText(Program.path_password, PASSWORD +"\n");
            return json;
        }
     }
}
