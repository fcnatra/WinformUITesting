namespace JustAWinForm
{
    partial class TestForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConvertToUpper = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtTextToConvert = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConvertToUpper
            // 
            this.btnConvertToUpper.Location = new System.Drawing.Point(12, 42);
            this.btnConvertToUpper.Name = "btnConvertToUpper";
            this.btnConvertToUpper.Size = new System.Drawing.Size(166, 23);
            this.btnConvertToUpper.TabIndex = 2;
            this.btnConvertToUpper.Text = "CONVERT TO UPPER";
            this.btnConvertToUpper.UseVisualStyleBackColor = true;
            this.btnConvertToUpper.Click += new System.EventHandler(this.OnClick_btnConvertToUpper);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(713, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.OnClick_btnClose);
            // 
            // txtTextToConvert
            // 
            this.txtTextToConvert.Location = new System.Drawing.Point(12, 13);
            this.txtTextToConvert.Name = "txtTextToConvert";
            this.txtTextToConvert.Size = new System.Drawing.Size(166, 20);
            this.txtTextToConvert.TabIndex = 1;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTextToConvert);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConvertToUpper);
            this.Name = "TestForm";
            this.Text = "TEST FORM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvertToUpper;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtTextToConvert;
    }
}

