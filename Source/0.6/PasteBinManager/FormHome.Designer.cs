namespace PasteBinManager
{
    partial class FormHome
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.tcPrincipal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.btnCopyResult = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.gbSelectType = new System.Windows.Forms.GroupBox();
            this.txtUseThis = new System.Windows.Forms.TextBox();
            this.rbUseThis2 = new System.Windows.Forms.RadioButton();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.rbUseThis1 = new System.Windows.Forms.RadioButton();
            this.gbEnterFile = new System.Windows.Forms.GroupBox();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.txtEnterFile = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbOutput = new System.Windows.Forms.GroupBox();
            this.mmOutput = new System.Windows.Forms.RichTextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.gbEnterPageToDownload = new System.Windows.Forms.GroupBox();
            this.txtPages = new System.Windows.Forms.NumericUpDown();
            this.gbEnterPage = new System.Windows.Forms.GroupBox();
            this.txtEnterPage = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gbFilesDownloaded = new System.Windows.Forms.GroupBox();
            this.lbFilesDownloaded = new System.Windows.Forms.ListBox();
            this.lvFilesDownloaded = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsOpciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LoadFileDownloaded = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFolderDownloaded = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.gbAbout = new System.Windows.Forms.GroupBox();
            this.lblCopyRight = new System.Windows.Forms.Label();
            this.pbAbout = new System.Windows.Forms.PictureBox();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tcPrincipal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbResult.SuspendLayout();
            this.gbSelectType.SuspendLayout();
            this.gbEnterFile.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbOutput.SuspendLayout();
            this.gbEnterPageToDownload.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPages)).BeginInit();
            this.gbEnterPage.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.gbFilesDownloaded.SuspendLayout();
            this.cmsOpciones.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.gbAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAbout)).BeginInit();
            this.ssStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Controls.Add(this.tabPage1);
            this.tcPrincipal.Controls.Add(this.tabPage2);
            this.tcPrincipal.Controls.Add(this.tabPage3);
            this.tcPrincipal.Controls.Add(this.tabPage4);
            this.tcPrincipal.Location = new System.Drawing.Point(11, 104);
            this.tcPrincipal.Name = "tcPrincipal";
            this.tcPrincipal.SelectedIndex = 0;
            this.tcPrincipal.Size = new System.Drawing.Size(377, 322);
            this.tcPrincipal.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbResult);
            this.tabPage1.Controls.Add(this.btnUpload);
            this.tabPage1.Controls.Add(this.gbSelectType);
            this.tabPage1.Controls.Add(this.gbEnterFile);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(369, 296);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Uploader";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.btnCopyResult);
            this.gbResult.Controls.Add(this.txtResult);
            this.gbResult.Location = new System.Drawing.Point(16, 185);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(339, 53);
            this.gbResult.TabIndex = 3;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Result";
            // 
            // btnCopyResult
            // 
            this.btnCopyResult.Location = new System.Drawing.Point(266, 20);
            this.btnCopyResult.Name = "btnCopyResult";
            this.btnCopyResult.Size = new System.Drawing.Size(58, 23);
            this.btnCopyResult.TabIndex = 1;
            this.btnCopyResult.Text = "Copy";
            this.btnCopyResult.UseVisualStyleBackColor = true;
            this.btnCopyResult.Click += new System.EventHandler(this.btnCopyResult_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(19, 20);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(240, 20);
            this.txtResult.TabIndex = 0;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(98, 258);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(160, 23);
            this.btnUpload.TabIndex = 2;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // gbSelectType
            // 
            this.gbSelectType.Controls.Add(this.txtUseThis);
            this.gbSelectType.Controls.Add(this.rbUseThis2);
            this.gbSelectType.Controls.Add(this.cmbType);
            this.gbSelectType.Controls.Add(this.rbUseThis1);
            this.gbSelectType.Location = new System.Drawing.Point(16, 99);
            this.gbSelectType.Name = "gbSelectType";
            this.gbSelectType.Size = new System.Drawing.Size(339, 79);
            this.gbSelectType.TabIndex = 1;
            this.gbSelectType.TabStop = false;
            this.gbSelectType.Text = "Select Type";
            // 
            // txtUseThis
            // 
            this.txtUseThis.Location = new System.Drawing.Point(97, 43);
            this.txtUseThis.Name = "txtUseThis";
            this.txtUseThis.Size = new System.Drawing.Size(121, 20);
            this.txtUseThis.TabIndex = 3;
            this.txtUseThis.Text = "None";
            // 
            // rbUseThis2
            // 
            this.rbUseThis2.AutoSize = true;
            this.rbUseThis2.Checked = true;
            this.rbUseThis2.Location = new System.Drawing.Point(19, 43);
            this.rbUseThis2.Name = "rbUseThis2";
            this.rbUseThis2.Size = new System.Drawing.Size(72, 17);
            this.rbUseThis2.TabIndex = 2;
            this.rbUseThis2.TabStop = true;
            this.rbUseThis2.Text = "Use this : ";
            this.rbUseThis2.UseVisualStyleBackColor = true;
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "None",
            "C",
            "C#",
            "Perl",
            "Python",
            "PHP",
            "Ruby",
            "Delphi",
            "HTML",
            "JavaScript",
            "SQL",
            "Java"});
            this.cmbType.Location = new System.Drawing.Point(97, 19);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 21);
            this.cmbType.TabIndex = 1;
            // 
            // rbUseThis1
            // 
            this.rbUseThis1.AutoSize = true;
            this.rbUseThis1.Location = new System.Drawing.Point(19, 20);
            this.rbUseThis1.Name = "rbUseThis1";
            this.rbUseThis1.Size = new System.Drawing.Size(72, 17);
            this.rbUseThis1.TabIndex = 0;
            this.rbUseThis1.Text = "Use this : ";
            this.rbUseThis1.UseVisualStyleBackColor = true;
            // 
            // gbEnterFile
            // 
            this.gbEnterFile.Controls.Add(this.btnLoadFile);
            this.gbEnterFile.Controls.Add(this.txtEnterFile);
            this.gbEnterFile.Location = new System.Drawing.Point(16, 21);
            this.gbEnterFile.Name = "gbEnterFile";
            this.gbEnterFile.Size = new System.Drawing.Size(339, 71);
            this.gbEnterFile.TabIndex = 0;
            this.gbEnterFile.TabStop = false;
            this.gbEnterFile.Text = "Enter File";
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(249, 31);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFile.TabIndex = 1;
            this.btnLoadFile.Text = "...";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // txtEnterFile
            // 
            this.txtEnterFile.AllowDrop = true;
            this.txtEnterFile.Location = new System.Drawing.Point(19, 31);
            this.txtEnterFile.Name = "txtEnterFile";
            this.txtEnterFile.ReadOnly = true;
            this.txtEnterFile.Size = new System.Drawing.Size(223, 20);
            this.txtEnterFile.TabIndex = 0;
            this.txtEnterFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtEnterFile_DragDrop);
            this.txtEnterFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtEnterFile_DragEnter);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gbOutput);
            this.tabPage2.Controls.Add(this.btnDownload);
            this.tabPage2.Controls.Add(this.gbEnterPageToDownload);
            this.tabPage2.Controls.Add(this.gbEnterPage);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(369, 296);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Downloader";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gbOutput
            // 
            this.gbOutput.Controls.Add(this.mmOutput);
            this.gbOutput.Location = new System.Drawing.Point(16, 134);
            this.gbOutput.Name = "gbOutput";
            this.gbOutput.Size = new System.Drawing.Size(335, 145);
            this.gbOutput.TabIndex = 3;
            this.gbOutput.TabStop = false;
            this.gbOutput.Text = "Output";
            // 
            // mmOutput
            // 
            this.mmOutput.Location = new System.Drawing.Point(16, 20);
            this.mmOutput.Name = "mmOutput";
            this.mmOutput.Size = new System.Drawing.Size(303, 105);
            this.mmOutput.TabIndex = 0;
            this.mmOutput.Text = "";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(168, 93);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(167, 23);
            this.btnDownload.TabIndex = 2;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // gbEnterPageToDownload
            // 
            this.gbEnterPageToDownload.Controls.Add(this.txtPages);
            this.gbEnterPageToDownload.Location = new System.Drawing.Point(16, 76);
            this.gbEnterPageToDownload.Name = "gbEnterPageToDownload";
            this.gbEnterPageToDownload.Size = new System.Drawing.Size(146, 51);
            this.gbEnterPageToDownload.TabIndex = 1;
            this.gbEnterPageToDownload.TabStop = false;
            this.gbEnterPageToDownload.Text = "Enter page to download";
            // 
            // txtPages
            // 
            this.txtPages.Location = new System.Drawing.Point(16, 20);
            this.txtPages.Name = "txtPages";
            this.txtPages.Size = new System.Drawing.Size(120, 20);
            this.txtPages.TabIndex = 0;
            this.txtPages.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gbEnterPage
            // 
            this.gbEnterPage.Controls.Add(this.txtEnterPage);
            this.gbEnterPage.Location = new System.Drawing.Point(16, 17);
            this.gbEnterPage.Name = "gbEnterPage";
            this.gbEnterPage.Size = new System.Drawing.Size(335, 52);
            this.gbEnterPage.TabIndex = 0;
            this.gbEnterPage.TabStop = false;
            this.gbEnterPage.Text = "Enter Page ";
            // 
            // txtEnterPage
            // 
            this.txtEnterPage.Location = new System.Drawing.Point(16, 20);
            this.txtEnterPage.Name = "txtEnterPage";
            this.txtEnterPage.Size = new System.Drawing.Size(303, 20);
            this.txtEnterPage.TabIndex = 0;
            this.txtEnterPage.Text = "http://pastebin.com/u/Ismael_Heredia";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gbFilesDownloaded);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(369, 296);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Files Downloaded";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gbFilesDownloaded
            // 
            this.gbFilesDownloaded.Controls.Add(this.lbFilesDownloaded);
            this.gbFilesDownloaded.Controls.Add(this.lvFilesDownloaded);
            this.gbFilesDownloaded.Location = new System.Drawing.Point(17, 15);
            this.gbFilesDownloaded.Name = "gbFilesDownloaded";
            this.gbFilesDownloaded.Size = new System.Drawing.Size(334, 262);
            this.gbFilesDownloaded.TabIndex = 0;
            this.gbFilesDownloaded.TabStop = false;
            this.gbFilesDownloaded.Text = "Files Downloaded";
            // 
            // lbFilesDownloaded
            // 
            this.lbFilesDownloaded.FormattingEnabled = true;
            this.lbFilesDownloaded.Location = new System.Drawing.Point(193, 65);
            this.lbFilesDownloaded.Name = "lbFilesDownloaded";
            this.lbFilesDownloaded.Size = new System.Drawing.Size(120, 95);
            this.lbFilesDownloaded.TabIndex = 1;
            this.lbFilesDownloaded.Visible = false;
            // 
            // lvFilesDownloaded
            // 
            this.lvFilesDownloaded.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvFilesDownloaded.ContextMenuStrip = this.cmsOpciones;
            this.lvFilesDownloaded.FullRowSelect = true;
            this.lvFilesDownloaded.Location = new System.Drawing.Point(26, 29);
            this.lvFilesDownloaded.Name = "lvFilesDownloaded";
            this.lvFilesDownloaded.Size = new System.Drawing.Size(282, 213);
            this.lvFilesDownloaded.TabIndex = 0;
            this.lvFilesDownloaded.UseCompatibleStateImageBehavior = false;
            this.lvFilesDownloaded.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 141;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date";
            this.columnHeader2.Width = 137;
            // 
            // cmsOpciones
            // 
            this.cmsOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadFileDownloaded,
            this.OpenFolderDownloaded});
            this.cmsOpciones.Name = "contextMenuStrip1";
            this.cmsOpciones.Size = new System.Drawing.Size(140, 48);
            // 
            // LoadFileDownloaded
            // 
            this.LoadFileDownloaded.Name = "LoadFileDownloaded";
            this.LoadFileDownloaded.Size = new System.Drawing.Size(139, 22);
            this.LoadFileDownloaded.Text = "Load";
            this.LoadFileDownloaded.Click += new System.EventHandler(this.LoadFileDownloaded_Click);
            // 
            // OpenFolderDownloaded
            // 
            this.OpenFolderDownloaded.Name = "OpenFolderDownloaded";
            this.OpenFolderDownloaded.Size = new System.Drawing.Size(139, 22);
            this.OpenFolderDownloaded.Text = "Open Folder";
            this.OpenFolderDownloaded.Click += new System.EventHandler(this.OpenFolderDownloaded_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.gbAbout);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(369, 296);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "About";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // gbAbout
            // 
            this.gbAbout.Controls.Add(this.lblCopyRight);
            this.gbAbout.Controls.Add(this.pbAbout);
            this.gbAbout.Location = new System.Drawing.Point(17, 17);
            this.gbAbout.Name = "gbAbout";
            this.gbAbout.Size = new System.Drawing.Size(332, 260);
            this.gbAbout.TabIndex = 0;
            this.gbAbout.TabStop = false;
            this.gbAbout.Text = "About";
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.Location = new System.Drawing.Point(80, 215);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(176, 13);
            this.lblCopyRight.TabIndex = 1;
            this.lblCopyRight.Text = "© Ismael Heredia , Argentina , 2017";
            this.lblCopyRight.Click += new System.EventHandler(this.lblCopyRight_Click);
            // 
            // pbAbout
            // 
            this.pbAbout.Image = ((System.Drawing.Image)(resources.GetObject("pbAbout.Image")));
            this.pbAbout.Location = new System.Drawing.Point(83, 44);
            this.pbAbout.Name = "pbAbout";
            this.pbAbout.Size = new System.Drawing.Size(174, 152);
            this.pbAbout.TabIndex = 0;
            this.pbAbout.TabStop = false;
            // 
            // ssStatus
            // 
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.ssStatus.Location = new System.Drawing.Point(0, 436);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(400, 22);
            this.ssStatus.TabIndex = 1;
            this.ssStatus.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(58, 17);
            this.status.Text = "[+] Ready";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(15, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(369, 69);
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 458);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.tcPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHome";
            this.Text = " - PasteBin Manager 0.6 - © Ismael Heredia , Argentina , 2017 -";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.tcPrincipal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            this.gbSelectType.ResumeLayout(false);
            this.gbSelectType.PerformLayout();
            this.gbEnterFile.ResumeLayout(false);
            this.gbEnterFile.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.gbOutput.ResumeLayout(false);
            this.gbEnterPageToDownload.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPages)).EndInit();
            this.gbEnterPage.ResumeLayout(false);
            this.gbEnterPage.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.gbFilesDownloaded.ResumeLayout(false);
            this.cmsOpciones.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.gbAbout.ResumeLayout(false);
            this.gbAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAbout)).EndInit();
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcPrincipal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.GroupBox gbEnterFile;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.TextBox txtEnterFile;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.GroupBox gbSelectType;
        private System.Windows.Forms.TextBox txtUseThis;
        private System.Windows.Forms.RadioButton rbUseThis2;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.RadioButton rbUseThis1;
        private System.Windows.Forms.GroupBox gbOutput;
        private System.Windows.Forms.RichTextBox mmOutput;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.GroupBox gbEnterPageToDownload;
        private System.Windows.Forms.NumericUpDown txtPages;
        private System.Windows.Forms.GroupBox gbEnterPage;
        private System.Windows.Forms.TextBox txtEnterPage;
        private System.Windows.Forms.GroupBox gbFilesDownloaded;
        private System.Windows.Forms.ListView lvFilesDownloaded;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox gbAbout;
        private System.Windows.Forms.PictureBox pbAbout;
        private System.Windows.Forms.Label lblCopyRight;
        private System.Windows.Forms.ListBox lbFilesDownloaded;
        private System.Windows.Forms.ContextMenuStrip cmsOpciones;
        private System.Windows.Forms.ToolStripMenuItem LoadFileDownloaded;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.Button btnCopyResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.ToolStripMenuItem OpenFolderDownloaded;
    }
}

