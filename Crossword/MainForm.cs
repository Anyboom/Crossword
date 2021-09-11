using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            Generator crossWord = new Generator(textBox1.Lines, Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox4.Text));

            crossWord.Generate();

            textBox2.Text = String.Join(Environment.NewLine, crossWord.ListOfUseWords);
            textBox3.Text = String.Join(Environment.NewLine, crossWord.ListOfExcessWords);

            pictureBox1.Image = Extensions.ToImage(crossWord.Field);
        }
    }
}
