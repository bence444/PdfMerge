using iText.Kernel.Pdf;
using iText.Kernel.Utils;

namespace PdfMerge.Service
{
    /// <summary>
    /// Runs the merge outside of the form view
    /// </summary>
    public class Merger
    {
        #region Constructor
        public Merger() { }
        #endregion

        #region Execute
        /// <summary>
        /// Executes to merge the given pdf files
        /// </summary>
        /// <param name="filePaths">Path to the files to merge</param>
        /// <param name="outputPath">Output path, where to save the file</param>
        /// <exception cref="Exception"></exception>
        public void Execute(
            string[] filePaths,
            string outputPath
        ) {
            try
            {
                PdfDocument combined = new(new PdfWriter(outputPath));
                PdfMerger merger = new(combined);

                MergeFiles(merger, filePaths);
                combined.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        #endregion

        #region Merge Functions
        /// <summary>
        /// Reads the pages of the pdf files and merge
        /// </summary>
        /// <param name="merger">PdfMerger object to merge the pages</param>
        /// <param name="filePaths">Path to the files to merge</param>
        /// <exception cref="Exception"></exception>
        private void MergeFiles(
            PdfMerger merger,
            string[] filePaths
        ) {
            try
            {
                foreach (string path in filePaths)
                {
                    using PdfDocument item = new(new PdfReader(path));
                    merger.Merge(item, 1, item.GetNumberOfPages());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        #endregion
    }
}
