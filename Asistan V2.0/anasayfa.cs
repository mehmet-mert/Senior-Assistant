using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asistan_V2._0
{
    
    public partial class anasayfa : UserControl
    {
        string user_message;
        int laaaan = 0;
        questions_tr nesne = new questions_tr();
        
        void Create_answer()
        {
            Take_message();
            Give_message();

            //Aşağı Kaydır ve Ortala
            richTextBox1.ScrollToCaret();
            richTextBox1.SelectAll();
            richTextBox1.SelectionIndent += 30;
            richTextBox1.SelectionRightIndent += 15;
            richTextBox1.SelectionLength = 0;
            richTextBox1.SelectionBackColor = richTextBox1.BackColor;
            user_message = "";
        }
        

        void Give_message()
        {
            richTextBox1.AppendText("Senior : ", Color.Red);
            richTextBox1.AppendText(nesne.Find_answer(user_message)+Environment.NewLine);
            
        }
        void Take_message()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) != true)
            {
                richTextBox1.AppendText(Environment.NewLine);
                richTextBox1.AppendText("Ben : ", Color.Orange);
                user_message = textBox1.Text.ToLower();
                richTextBox1.AppendText(textBox1.Text + Environment.NewLine);
                textBox1.Clear();
            }
 
        }
        public anasayfa()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Create_answer();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                Create_answer();
                e.SuppressKeyPress = true;
            }
        }
    }
    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
}
