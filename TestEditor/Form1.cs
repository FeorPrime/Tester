using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestEditor
{
    public partial class Form1 : Form
    {
        List<Question> qList = new List<Question>();
        public Form1()
        {
            InitializeComponent();
        }
        void ShowQuestion(int id)
        {
            if (id < 0 || id > qList.Count) return; //
            textBox2.Text = qList[id].name;
            textBox1.Text = qList[id].text;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            string name = "Вопрос " + (listBox1.Items.Count + 1).ToString();
            listBox1.Items.Add(name);
            qList.Add(new Question(name));
            ShowQuestion(listBox1.Items.Count);

        }
    }
    class Answer
    {
        public string text;
        public bool right;
    }
    class Question
    {
        public string name;
        public string text;
        public Answer[] answ = new Answer[4];
        public Question(string Name)
        {
            name = Name;
        }
    }
}
