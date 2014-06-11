namespace FP.Main
{
    partial class frmPreview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPreview));
            this.pdfView = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.pdfView)).BeginInit();
            this.SuspendLayout();
            // 
            // pdfView
            // 
            this.pdfView.Enabled = true;
            this.pdfView.Location = new System.Drawing.Point(12, 12);
            this.pdfView.Name = "pdfView";
            this.pdfView.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdfView.OcxState")));
            this.pdfView.Size = new System.Drawing.Size(899, 469);
            this.pdfView.TabIndex = 1;
            // 
            // frmPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 493);
            this.Controls.Add(this.pdfView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPreview";
            this.ShowIcon = false;
            this.Text = "Comprovante";
            this.Load += new System.EventHandler(this.frmPreview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pdfView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF pdfView;



    }
}