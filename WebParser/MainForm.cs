using MainLogic;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebParser
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void GetContentButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(urlTextBox.Text))
                {
                    throw new Exception("URL is not defined");
                }

                if (!UrlHelper.UrlIsCorrect(urlTextBox.Text))
                {
                    throw new Exception("Invalid URL");
                }

                string url = urlTextBox.Text;

                Task<string> getContentTask = GetWebpageContentAsync(url);

                getContentTask.Wait();

                string webPageContent = getContentTask.Result;

                DialogResult saveFileDialogResult = saveContentDialog.ShowDialog();

                if (saveFileDialogResult == DialogResult.OK)
                {
                    FileHelper.SaveFileFromString(webPageContent, saveContentDialog.FileName);

                    ShowInfoMessage($"File saved: {saveContentDialog.FileName}");
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private async Task<string> GetWebpageContentAsync(string url)
        {
            return await Parser.GetWebpageContent(url).ConfigureAwait(false);
        }

        private void ShowErrorMessage(string error)
        {
            MessageBox.Show(
                error, 
                "Error", 
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }

        private void ShowInfoMessage(string info)
        {
            MessageBox.Show(
                info, 
                "Info message", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information
            );
        }
    }
}