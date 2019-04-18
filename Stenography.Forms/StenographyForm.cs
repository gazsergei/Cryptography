using System;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Stenography.Forms
{
    public partial class StenographyForm : System.Windows.Forms.Form
    {
        public StenographyForm()
        {
            InitializeComponent();
        }

        private void StenographyForm_Load(object sender, EventArgs e)
        {

        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                filePathTextBox.Text = openFileDialog.FileName;
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                object positionLetter = 0;
                object w = 1;

                var app = new Word.Application();
                app.Visible = true;
                var doc = app.Documents.Open(openFileDialog.FileName);

                var input = cipherTextBox.Text;

                var i = 0;

                while (true)
                {
                    var range = doc.Range(ref positionLetter, ref w);
                    var c = input[i];

                    if (c == Convert.ToChar(range.Text))
                    {
                        range.Select();
                        range.Font.Spacing = 2;
                        positionLetter = (int) positionLetter + 1;
                        w = (int) w + 1;
                        i++;
                    }
                    else
                    {
                        positionLetter = (int) positionLetter + 1;
                        w = (int) w + 1;
                    }

                    if (i == input.Length)
                        break;
                }

                doc.Save();
                doc.Close();
                app.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
