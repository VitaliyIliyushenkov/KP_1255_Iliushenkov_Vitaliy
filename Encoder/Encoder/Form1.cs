using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encoder
{
    public partial class Form1 : Form
    {
        List<Encryptor> ecryptorsList = new List<Encryptor>();
        DecryptProcessor decryptProcessor;

        string encoder_selected;
        int? index_selected;

        public Form1()
        {
            InitializeComponent();
        }

        // Функция увеличения кода символа на 1
        char IncrementSymbolCode(char symbolCode)
        {
            decryptProcessor = new IncrementDecrypt();
            return decryptProcessor.Process(symbolCode);
        }

        // Функция уменьшения кода символа на 1
        char DecrementSymbolCode(char symbolCode)
        {
            decryptProcessor = new DecrementDecrypt();
            return decryptProcessor.Process(symbolCode);
        }

        // Функция кода символа
        char ZeroSymbolCode(char symbolCode)
        {
            decryptProcessor = new ZeroDecrypt();
            return decryptProcessor.Process(symbolCode);
        }

        // Функция вычитания из 255 кода символа
        char NegativeSymbolCode(char symbolCode)
        {
            decryptProcessor = new NegativeDecrypt();
            return decryptProcessor.Process(symbolCode);
        }

        // Метод заполнения списка шифраторов
        void fillEncryptors()
        {
            ecryptorsList.Clear();
            foreach (string encoder in listBox_added_encoders.Items)
            {
                if (encoder == listBox_encoders.Items[0].ToString())
                    ecryptorsList.Add(new Encryptor(IncrementSymbolCode, "Increment", "I"));
                if (encoder == listBox_encoders.Items[1].ToString())
                    ecryptorsList.Add(new Encryptor(DecrementSymbolCode, "Decrement", "D"));
                if (encoder == listBox_encoders.Items[2].ToString())
                    ecryptorsList.Add(new Encryptor(ZeroSymbolCode, "Zero", "Z"));
                if (encoder == listBox_encoders.Items[3].ToString())
                    ecryptorsList.Add(new Encryptor(NegativeSymbolCode, "Negative", "N"));
            }
        }

        private void listBox_encoders_SelectedIndexChanged(object sender, EventArgs e)
        {
            encoder_selected = listBox_encoders.Items[listBox_encoders.SelectedIndex].ToString();
        }
        private void listBox_added_encoders_SelectedIndexChanged(object sender, EventArgs e)
        {
            index_selected = listBox_added_encoders.SelectedIndex;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            listBox_added_encoders.Items.Add(encoder_selected);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (index_selected != null)
            {
                listBox_added_encoders.Items.RemoveAt((int)index_selected);
            }
            index_selected = null;
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            fillEncryptors();

            textbox_encrypted.Clear();
            textbox_key.Clear();

            int i = 0;
            foreach (char symbol in textbox_your_text.Text)
            {
                char newSymbol = symbol;
                newSymbol = ecryptorsList[i].encrypt(newSymbol);
                textbox_encrypted.Text += newSymbol;

                if (i == ecryptorsList.Count-1)
                    i = 0;
                else
                    i++;
                
            }

            foreach (Encryptor ecryptor in ecryptorsList)
            {
                textbox_key.Text += ecryptor.key;
            }

        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            textbox_unencrypted.Clear();
            Decryptor decryptor = new Decryptor();
            textbox_unencrypted.Text = decryptor.Decrypt(textbox_key.Text, textbox_encrypted.Text);
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            if (index_selected != null && index_selected != 0)
            {
                object temp;
                temp = listBox_added_encoders.Items[(int)index_selected];
                listBox_added_encoders.Items[(int)index_selected] = listBox_added_encoders.Items[(int)index_selected - 1];
                listBox_added_encoders.Items[(int)index_selected - 1] = temp;
                if (index_selected > 0)
                index_selected --;

            }
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            if (index_selected != null && index_selected != listBox_added_encoders.Items.Count-1)
            {
                object temp;
                temp = listBox_added_encoders.Items[(int)index_selected];
                listBox_added_encoders.Items[(int)index_selected] = listBox_added_encoders.Items[(int)index_selected + 1];
                listBox_added_encoders.Items[(int)index_selected + 1] = temp;
                if (index_selected < listBox_added_encoders.Items.Count-1)
                index_selected ++;

            }
        }
    }
}
