namespace favman
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
            textBoxName = new TextBox();
            textBoxURL = new TextBox();
            textBoxIcon = new TextBox();
            labelName = new Label();
            labelURL = new Label();
            labelIcon = new Label();
            buttonCreate = new Button();
            openFileDialog1 = new OpenFileDialog();
            buttonFileOpen = new Button();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(67, 20);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(359, 23);
            textBoxName.TabIndex = 0;
            // 
            // textBoxURL
            // 
            textBoxURL.Location = new Point(67, 65);
            textBoxURL.Name = "textBoxURL";
            textBoxURL.Size = new Size(359, 23);
            textBoxURL.TabIndex = 1;
            textBoxURL.Text = "https://";
            // 
            // textBoxIcon
            // 
            textBoxIcon.Location = new Point(67, 108);
            textBoxIcon.Name = "textBoxIcon";
            textBoxIcon.Size = new Size(359, 23);
            textBoxIcon.TabIndex = 2;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(12, 20);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 3;
            labelName.Text = "Name";
            // 
            // labelURL
            // 
            labelURL.AutoSize = true;
            labelURL.Location = new Point(12, 71);
            labelURL.Name = "labelURL";
            labelURL.Size = new Size(28, 15);
            labelURL.TabIndex = 4;
            labelURL.Text = "URL";
            // 
            // labelIcon
            // 
            labelIcon.AutoSize = true;
            labelIcon.Location = new Point(12, 119);
            labelIcon.Name = "labelIcon";
            labelIcon.Size = new Size(30, 15);
            labelIcon.TabIndex = 5;
            labelIcon.Text = "Icon";
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(351, 146);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(75, 23);
            buttonCreate.TabIndex = 6;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonFileOpen
            // 
            buttonFileOpen.Location = new Point(423, 108);
            buttonFileOpen.Name = "buttonFileOpen";
            buttonFileOpen.Size = new Size(31, 23);
            buttonFileOpen.TabIndex = 7;
            buttonFileOpen.Text = "...";
            buttonFileOpen.UseVisualStyleBackColor = true;
            buttonFileOpen.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 183);
            Controls.Add(buttonFileOpen);
            Controls.Add(buttonCreate);
            Controls.Add(labelIcon);
            Controls.Add(labelURL);
            Controls.Add(labelName);
            Controls.Add(textBoxIcon);
            Controls.Add(textBoxURL);
            Controls.Add(textBoxName);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Favman v0.2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxURL;
        private TextBox textBoxIcon;
        private Label labelName;
        private Label labelURL;
        private Label labelIcon;
        private Button buttonCreate;
        private OpenFileDialog openFileDialog1;
        private Button buttonFileOpen;
        private LinkLabel linkLabel1;
    }
}
