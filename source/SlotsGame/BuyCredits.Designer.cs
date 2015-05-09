namespace SlotsGame
{
    partial class BuyCredits
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyCredits));
            this.label1 = new System.Windows.Forms.Label();
            this.btnProceed = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbCredits = new System.Windows.Forms.TextBox();
            this.creditInputErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.creditInputErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "How many credits do you want to buy?";
            // 
            // btnProceed
            // 
            this.btnProceed.Location = new System.Drawing.Point(62, 100);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(75, 32);
            this.btnProceed.TabIndex = 2;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            this.btnProceed.Validating += new System.ComponentModel.CancelEventHandler(this.btnProceed_Validating);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(174, 100);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 32);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbCredits
            // 
            this.tbCredits.Location = new System.Drawing.Point(103, 59);
            this.tbCredits.Name = "tbCredits";
            this.tbCredits.Size = new System.Drawing.Size(100, 20);
            this.tbCredits.TabIndex = 1;
            this.tbCredits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCredits.Validating += new System.ComponentModel.CancelEventHandler(this.tbCredits_Validating);
            // 
            // creditInputErrorProvider
            // 
            this.creditInputErrorProvider.ContainerControl = this;
            // 
            // BuyCredits
            // 
            this.AcceptButton = this.btnProceed;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(316, 141);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.tbCredits);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(332, 180);
            this.MinimumSize = new System.Drawing.Size(332, 180);
            this.Name = "BuyCredits";
            this.Text = "Buy Credits";
            ((System.ComponentModel.ISupportInitialize)(this.creditInputErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbCredits;
        private System.Windows.Forms.ErrorProvider creditInputErrorProvider;
    }
}