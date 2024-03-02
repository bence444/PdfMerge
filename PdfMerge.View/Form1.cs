using PdfMerge.Service;

namespace PdfMerge.View
{
    public partial class Form1 : Form
    {
        #region Properties
        private List<string> _files { get; set; }
        private string _outputPath { get; set; }
        #endregion

        #region Constructor
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region HandleError
        /// <summary>
        /// Show details from the first exception in a row
        /// </summary>
        /// <param name="ex">The last catched exception</param>
        private void HandleError(Exception ex)
        {
            while (ex.InnerException != null)
                ex = ex.InnerException;

            MessageBox.Show($@"Hiba:

            {ex.Message}

            {ex.StackTrace}");
        }
        #endregion

        #region Select Click
        /// <summary>
        /// Store the selected the pdf files path
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new();

            file.Filter = "PDF Files|*.pdf";
            file.Multiselect = true;

            if (file.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var files = file.FileNames;
                    
                    textBox1.Text = string.Join(',', files);
                    _files = files.ToList();
                }
                catch (Exception ex)
                {
                    HandleError(ex);
                }
            }
        }
        #endregion

        #region Select Path
        /// <summary>
        /// Store the path to the new pdf file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectSavePath_Click(object sender, EventArgs e)
        {
            SaveFileDialog file = new();
            file.FileName = $"merged_{DateTime.Now:yyyy_MM_dd_-_HH_mm_ss}.pdf";
            file.Filter = "PDF File|*.pdf";
            file.DefaultExt = ".pdf";
            file.AddExtension = true;

            if (file.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = Path.GetFullPath(file.FileName);
                    
                    textBox2.Text = path;
                    _outputPath = path;
                }
                catch (Exception ex)
                {
                    HandleError(ex);
                }
            }
        }
        #endregion

        #region Save
        /// <summary>
        /// Executes the merger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                var start = DateTime.Now;

                Merger merger = new();
                merger.Execute(_files.ToArray(), _outputPath);

                var end = DateTime.Now;
                var elapsed = (end - start).TotalSeconds;

                MessageBox.Show($"Mentve! ({Math.Round(elapsed, 2)}s)");
            }
            catch (Exception ex)
            {
                HandleError(ex);
            }
        }
        #endregion
    }
}