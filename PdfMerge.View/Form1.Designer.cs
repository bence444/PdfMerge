namespace PdfMerge.View
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
            this.filesSelect = new System.Windows.Forms.Button();
            this.selectFiles = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.selectSavePath = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filesSelect
            // 
            resources.ApplyResources(this.filesSelect, "filesSelect");
            this.filesSelect.Name = "filesSelect";
            this.filesSelect.UseVisualStyleBackColor = true;
            // 
            // selectFiles
            // 
            resources.ApplyResources(this.selectFiles, "selectFiles");
            this.selectFiles.Name = "selectFiles";
            this.selectFiles.UseVisualStyleBackColor = true;
            this.selectFiles.Click += new System.EventHandler(this.selectFiles_Click);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // selectSavePath
            // 
            resources.ApplyResources(this.selectSavePath, "selectSavePath");
            this.selectSavePath.Name = "selectSavePath";
            this.selectSavePath.UseVisualStyleBackColor = true;
            this.selectSavePath.Click += new System.EventHandler(this.selectSavePath_Click);
            // 
            // save
            // 
            resources.ApplyResources(this.save, "save");
            this.save.Name = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.save);
            this.Controls.Add(this.selectSavePath);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.selectFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button filesSelect;
        private Button selectFiles;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button selectSavePath;
        private Button save;
    }
}