
namespace Crossword
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainGroup = new System.Windows.Forms.GroupBox();
            this.SizeGridTextBox = new System.Windows.Forms.TextBox();
            this.SizeGridLabel = new System.Windows.Forms.Label();
            this.ExcessWordsLabel = new System.Windows.Forms.Label();
            this.UseWordsLabel = new System.Windows.Forms.Label();
            this.WordsLabel = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.ExcessWordsTextBox = new System.Windows.Forms.TextBox();
            this.UseWordsTextBox = new System.Windows.Forms.TextBox();
            this.WordsTextBox = new System.Windows.Forms.TextBox();
            this.MainGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainGroup
            // 
            this.MainGroup.Controls.Add(this.SizeGridTextBox);
            this.MainGroup.Controls.Add(this.SizeGridLabel);
            this.MainGroup.Controls.Add(this.ExcessWordsLabel);
            this.MainGroup.Controls.Add(this.UseWordsLabel);
            this.MainGroup.Controls.Add(this.WordsLabel);
            this.MainGroup.Controls.Add(this.CreateButton);
            this.MainGroup.Controls.Add(this.ExcessWordsTextBox);
            this.MainGroup.Controls.Add(this.UseWordsTextBox);
            this.MainGroup.Controls.Add(this.WordsTextBox);
            this.MainGroup.Location = new System.Drawing.Point(12, 12);
            this.MainGroup.Name = "MainGroup";
            this.MainGroup.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.MainGroup.Size = new System.Drawing.Size(521, 300);
            this.MainGroup.TabIndex = 0;
            this.MainGroup.TabStop = false;
            // 
            // SizeGridTextBox
            // 
            this.SizeGridTextBox.Location = new System.Drawing.Point(103, 267);
            this.SizeGridTextBox.Name = "SizeGridTextBox";
            this.SizeGridTextBox.Size = new System.Drawing.Size(70, 23);
            this.SizeGridTextBox.TabIndex = 8;
            this.SizeGridTextBox.Text = "10";
            // 
            // SizeGridLabel
            // 
            this.SizeGridLabel.AutoSize = true;
            this.SizeGridLabel.Location = new System.Drawing.Point(13, 270);
            this.SizeGridLabel.Name = "SizeGridLabel";
            this.SizeGridLabel.Size = new System.Drawing.Size(83, 15);
            this.SizeGridLabel.TabIndex = 7;
            this.SizeGridLabel.Text = "Размер сетки:";
            // 
            // ExcessWordsLabel
            // 
            this.ExcessWordsLabel.AutoSize = true;
            this.ExcessWordsLabel.Location = new System.Drawing.Point(351, 28);
            this.ExcessWordsLabel.Name = "ExcessWordsLabel";
            this.ExcessWordsLabel.Size = new System.Drawing.Size(118, 15);
            this.ExcessWordsLabel.TabIndex = 6;
            this.ExcessWordsLabel.Text = "Слова, которых нет:";
            // 
            // UseWordsLabel
            // 
            this.UseWordsLabel.AutoSize = true;
            this.UseWordsLabel.Location = new System.Drawing.Point(179, 28);
            this.UseWordsLabel.Name = "UseWordsLabel";
            this.UseWordsLabel.Size = new System.Drawing.Size(123, 15);
            this.UseWordsLabel.TabIndex = 5;
            this.UseWordsLabel.Text = "Слова, которые есть:";
            // 
            // WordsLabel
            // 
            this.WordsLabel.AutoSize = true;
            this.WordsLabel.Location = new System.Drawing.Point(13, 28);
            this.WordsLabel.Margin = new System.Windows.Forms.Padding(0);
            this.WordsLabel.Name = "WordsLabel";
            this.WordsLabel.Size = new System.Drawing.Size(44, 15);
            this.WordsLabel.TabIndex = 4;
            this.WordsLabel.Text = "Слова:";
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(433, 267);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 3;
            this.CreateButton.Text = "Создать";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // ExcessWordsTextBox
            // 
            this.ExcessWordsTextBox.Location = new System.Drawing.Point(351, 46);
            this.ExcessWordsTextBox.Multiline = true;
            this.ExcessWordsTextBox.Name = "ExcessWordsTextBox";
            this.ExcessWordsTextBox.Size = new System.Drawing.Size(157, 213);
            this.ExcessWordsTextBox.TabIndex = 2;
            // 
            // UseWordsTextBox
            // 
            this.UseWordsTextBox.Location = new System.Drawing.Point(179, 46);
            this.UseWordsTextBox.Multiline = true;
            this.UseWordsTextBox.Name = "UseWordsTextBox";
            this.UseWordsTextBox.Size = new System.Drawing.Size(166, 213);
            this.UseWordsTextBox.TabIndex = 1;
            // 
            // WordsTextBox
            // 
            this.WordsTextBox.Location = new System.Drawing.Point(13, 46);
            this.WordsTextBox.Multiline = true;
            this.WordsTextBox.Name = "WordsTextBox";
            this.WordsTextBox.Size = new System.Drawing.Size(160, 213);
            this.WordsTextBox.TabIndex = 0;
            this.WordsTextBox.Text = "Даниил\r\nВолков\r\nВадимович\r\nНиколай\r\nПетренько";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 324);
            this.Controls.Add(this.MainGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Кроссворд";
            this.MainGroup.ResumeLayout(false);
            this.MainGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MainGroup;
        private System.Windows.Forms.Label ExcessWordsLabel;
        private System.Windows.Forms.Label UseWordsLabel;
        private System.Windows.Forms.Label WordsLabel;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.TextBox ExcessWordsTextBox;
        private System.Windows.Forms.TextBox UseWordsTextBox;
        private System.Windows.Forms.TextBox WordsTextBox;
        private System.Windows.Forms.TextBox SizeGridTextBox;
        private System.Windows.Forms.Label SizeGridLabel;
    }
}

