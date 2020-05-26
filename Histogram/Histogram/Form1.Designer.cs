namespace Histogram
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.histogramControl = new ZedGraph.ZedGraphControl();
            this.acButton = new System.Windows.Forms.Button();
            this.dcButton = new System.Windows.Forms.Button();
            this.padButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // histogramControl
            // 
            this.histogramControl.Location = new System.Drawing.Point(12, 12);
            this.histogramControl.Name = "histogramControl";
            this.histogramControl.ScrollGrace = 0D;
            this.histogramControl.ScrollMaxX = 0D;
            this.histogramControl.ScrollMaxY = 0D;
            this.histogramControl.ScrollMaxY2 = 0D;
            this.histogramControl.ScrollMinX = 0D;
            this.histogramControl.ScrollMinY = 0D;
            this.histogramControl.ScrollMinY2 = 0D;
            this.histogramControl.Size = new System.Drawing.Size(874, 399);
            this.histogramControl.TabIndex = 0;
            this.histogramControl.UseExtendedPrintDialog = true;
            this.histogramControl.Load += new System.EventHandler(this.zedGraphControl1_Load);
            // 
            // acButton
            // 
            this.acButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.acButton.Location = new System.Drawing.Point(892, 12);
            this.acButton.Name = "acButton";
            this.acButton.Size = new System.Drawing.Size(75, 23);
            this.acButton.TabIndex = 7;
            this.acButton.Text = "AC";
            this.acButton.UseVisualStyleBackColor = true;
            this.acButton.Click += new System.EventHandler(this.acButton_Click);
            // 
            // dcButton
            // 
            this.dcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dcButton.Location = new System.Drawing.Point(892, 50);
            this.dcButton.Name = "dcButton";
            this.dcButton.Size = new System.Drawing.Size(75, 23);
            this.dcButton.TabIndex = 8;
            this.dcButton.Text = "DC";
            this.dcButton.UseVisualStyleBackColor = true;
            this.dcButton.Click += new System.EventHandler(this.dcButton_Click);
            // 
            // padButton
            // 
            this.padButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.padButton.Location = new System.Drawing.Point(892, 88);
            this.padButton.Name = "padButton";
            this.padButton.Size = new System.Drawing.Size(75, 23);
            this.padButton.TabIndex = 9;
            this.padButton.Text = "PAD";
            this.padButton.UseVisualStyleBackColor = true;
            this.padButton.Click += new System.EventHandler(this.padButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 450);
            this.Controls.Add(this.padButton);
            this.Controls.Add(this.dcButton);
            this.Controls.Add(this.acButton);
            this.Controls.Add(this.histogramControl);
            this.Name = "Form1";
            this.Text = "Histogram";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl histogramControl;
        private System.Windows.Forms.Button acButton;
        private System.Windows.Forms.Button dcButton;
        private System.Windows.Forms.Button padButton;
    }
}

