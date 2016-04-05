using System;
using System.Collections.Generic;
using System.Windows.Forms;

using System.IO;

namespace WFLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            FileStream i_stream = File.Open("Input.txt", FileMode.Open, FileAccess.Read);
            string input = string.Empty;

            if (i_stream != null)
            {
                StreamReader reader = new StreamReader(i_stream);
                input = reader.ReadToEnd();
                i_stream.Close();
            }

            string[] text = input.Split(' ', ',', '.', '/', '!', '\n','\t');
            List<int> mas = new List<int>();
            List<string> words = new List<string>();
            int res;

            string label = string.Empty;

            for (int i = 0; i < text.Length; ++i)
                if (int.TryParse(text[i], out res))
                    mas.Add(res);
                else if (words.IndexOf(text[i]) == -1)
                {
                    words.Add(text[i]);
                    label += text[i] + " ";
                }
                else
                    continue;

            FileStream o_stream = File.Open("Output.txt", FileMode.Open, FileAccess.Write);
            if (o_stream != null)
            {
                StreamWriter writer = new StreamWriter(o_stream);

                writer.Write(mas.Count);
                writer.Flush();
                o_stream.Close();
            }

            label+= "\n\nMax " + M(mas, 1) + "\nMin " + M(mas, -1);
            Out.Text = label;
        }

        private static int M(List<int> mas, int l)
        {
            int temp = mas[0];

            for (int i = 0; i < mas.Count; ++i)
                if (l * mas[i] > temp * l)
                    temp = mas[i];

            return temp;
        }
    }
}
