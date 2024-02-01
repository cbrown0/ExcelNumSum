namespace ExcelNumSum
{
    partial class Form1
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
            openFile = new Button();
            outputBox = new RichTextBox();
            SuspendLayout();
            // 
            // openFile
            // 
            openFile.Location = new Point(366, 73);
            openFile.Name = "openFile";
            openFile.Size = new Size(94, 29);
            openFile.TabIndex = 0;
            openFile.Text = "Open File";
            openFile.UseMnemonic = false;
            openFile.UseVisualStyleBackColor = true;
            openFile.Click += openFile_Click;
            // 
            // outputBox
            // 
            outputBox.Cursor = Cursors.SizeNS;
            outputBox.Location = new Point(150, 136);
            outputBox.Name = "outputBox";
            outputBox.ReadOnly = true;
            outputBox.Size = new Size(539, 251);
            outputBox.TabIndex = 1;
            outputBox.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 450);
            Controls.Add(outputBox);
            Controls.Add(openFile);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Excel Sum Digits";
            ResumeLayout(false);
        }

        #endregion

        private Button openFile;
        private RichTextBox outputBox;
    }
}
