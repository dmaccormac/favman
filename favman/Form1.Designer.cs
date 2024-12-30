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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBoxTitle = new TextBox();
            textBoxURL = new TextBox();
            textBoxIcon = new TextBox();
            labelTitle = new Label();
            labelURL = new Label();
            labelIcon = new Label();
            buttonCreate = new Button();
            openFileDialog1 = new OpenFileDialog();
            buttonFileOpen = new Button();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            checkBoxOpen = new CheckBox();
            SuspendLayout();
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(67, 12);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(359, 23);
            textBoxTitle.TabIndex = 0;
            // 
            // textBoxURL
            // 
            textBoxURL.Location = new Point(67, 57);
            textBoxURL.Name = "textBoxURL";
            textBoxURL.Size = new Size(359, 23);
            textBoxURL.TabIndex = 1;
            textBoxURL.Text = "https://";
            // 
            // textBoxIcon
            // 
            textBoxIcon.Location = new Point(67, 100);
            textBoxIcon.Name = "textBoxIcon";
            textBoxIcon.Size = new Size(359, 23);
            textBoxIcon.TabIndex = 2;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(31, 15);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(30, 15);
            labelTitle.TabIndex = 3;
            labelTitle.Text = "Title";
            // 
            // labelURL
            // 
            labelURL.AutoSize = true;
            labelURL.Location = new Point(33, 60);
            labelURL.Name = "labelURL";
            labelURL.Size = new Size(28, 15);
            labelURL.TabIndex = 4;
            labelURL.Text = "URL";
            // 
            // labelIcon
            // 
            labelIcon.AutoSize = true;
            labelIcon.Location = new Point(31, 103);
            labelIcon.Name = "labelIcon";
            labelIcon.Size = new Size(30, 15);
            labelIcon.TabIndex = 5;
            labelIcon.Text = "Icon";
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(351, 145);
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
            buttonFileOpen.Location = new Point(423, 100);
            buttonFileOpen.Name = "buttonFileOpen";
            buttonFileOpen.Size = new Size(31, 23);
            buttonFileOpen.TabIndex = 7;
            buttonFileOpen.Text = "...";
            buttonFileOpen.UseVisualStyleBackColor = true;
            buttonFileOpen.Click += button2_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(339, 180);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(87, 15);
            linkLabel2.TabIndex = 8;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Project website";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(67, 180);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(101, 15);
            linkLabel3.TabIndex = 9;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Open file location";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // checkBoxOpen
            // 
            checkBoxOpen.AutoSize = true;
            checkBoxOpen.Checked = true;
            checkBoxOpen.CheckState = CheckState.Checked;
            checkBoxOpen.Location = new Point(67, 149);
            checkBoxOpen.Name = "checkBoxOpen";
            checkBoxOpen.Size = new Size(112, 19);
            checkBoxOpen.TabIndex = 10;
            checkBoxOpen.Text = "Open bookmark";
            checkBoxOpen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 215);
            Controls.Add(checkBoxOpen);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(buttonFileOpen);
            Controls.Add(buttonCreate);
            Controls.Add(labelIcon);
            Controls.Add(labelURL);
            Controls.Add(labelTitle);
            Controls.Add(textBoxIcon);
            Controls.Add(textBoxURL);
            Controls.Add(textBoxTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Favman 0.3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTitle;
        private TextBox textBoxURL;
        private TextBox textBoxIcon;
        private Label labelTitle;
        private Label labelURL;
        private Label labelIcon;
        private Button buttonCreate;
        private OpenFileDialog openFileDialog1;
        private Button buttonFileOpen;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private CheckBox checkBoxOpen;
    }
}
