
namespace GetOrderInfo
{
    partial class FormBarCode
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
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator1 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            this.barCodeControlMain = new DevExpress.XtraEditors.BarCodeControl();
            this.SuspendLayout();
            // 
            // barCodeControlMain
            // 
            this.barCodeControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barCodeControlMain.Appearance.Font = new System.Drawing.Font("Tahoma", 18.25F);
            this.barCodeControlMain.Appearance.Options.UseFont = true;
            this.barCodeControlMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.barCodeControlMain.HorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.barCodeControlMain.HorizontalTextAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.barCodeControlMain.Location = new System.Drawing.Point(12, 12);
            this.barCodeControlMain.Name = "barCodeControlMain";
            this.barCodeControlMain.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.barCodeControlMain.Size = new System.Drawing.Size(557, 144);
            this.barCodeControlMain.Symbology = code128Generator1;
            this.barCodeControlMain.TabIndex = 0;
            this.barCodeControlMain.Text = "046100304600094313";
            // 
            // FormBarCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(579, 163);
            this.Controls.Add(this.barCodeControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormBarCode";
            this.Text = "Штрих код";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.BarCodeControl barCodeControlMain;
    }
}