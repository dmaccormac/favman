using System.Diagnostics;
using System.Windows.Forms;

namespace favman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            //show a dialog box to select icon file
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Icon Files (*.ico)|*.ico";
            ofd.Title = "Select an Icon File";
            ofd.ShowDialog();

            //set the text of the icon textbox to the path of the selected icon file
            textBoxIcon.Text = ofd.FileName;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string url = textBoxURL.Text;
            string icon = textBoxIcon.Text;

            string html = $@"
            <!DOCTYPE html>
            <html>
            <head>
                <title>{name}</title>
                <link rel=""icon"" href=""{name}.ico"" type=""image/x-icon"">
                <meta http-equiv=""refresh"" content=""5;url={url}"">
            </head>
            <body>   
                <p>Redirecting to <a href=""{url}"">{url}</a>
            </body>
            </html>";



            // check if favman directory exists
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Favman\\Bookmarks";
            if (!System.IO.Directory.Exists(path))
            {
                System.IO.Directory.CreateDirectory(path);
            }

            // write to file 
            string filename = path + $"\\{name}.html";
            System.IO.File.WriteAllText(filename, html);

            //copy icon file to favman directory
            string iconname = path + $"\\{name}.ico";
            System.IO.File.Copy(icon, iconname);

            //show success message
            MessageBox.Show("Shortcut created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }


    }
}
