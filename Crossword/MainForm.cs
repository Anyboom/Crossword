using CsvHelper;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crossword
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            Generator crossWord = new Generator(WordsTextBox.Lines, Convert.ToInt32(SizeGridTextBox.Text), Convert.ToInt32(SizeGridTextBox.Text));

            crossWord.Generate();

            UseWordsTextBox.Text = String.Join(Environment.NewLine, crossWord.ListOfUseWords);
            ExcessWordsTextBox.Text = String.Join(Environment.NewLine, crossWord.ListOfExcessWords);

            string pathCsvFile = "result.csv";

            for (int i = 0; i < crossWord.Field.GetLength(0); i++)
            {
                for (int j = 0; j < crossWord.Field.GetLength(1); j++)
                {
                    File.AppendAllText(pathCsvFile, crossWord.Field[i, j] + ";", Encoding.UTF8);
                }
                File.AppendAllText(pathCsvFile, Environment.NewLine, Encoding.UTF8);
            }
        }
    }
}
