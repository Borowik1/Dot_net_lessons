namespace UsersAwardsPL
{
    partial class AwardForm
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
            this.tbAwardName = new System.Windows.Forms.TextBox();
            this.tbAwardDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.erTextAwardName = new System.Windows.Forms.ErrorProvider(this.components);
            this.erTextAwardDesc = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erTextAwardName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erTextAwardDesc)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAwardName
            // 
            this.tbAwardName.Location = new System.Drawing.Point(92, 44);
            this.tbAwardName.Name = "tbAwardName";
            this.tbAwardName.Size = new System.Drawing.Size(116, 20);
            this.tbAwardName.TabIndex = 0;
            this.tbAwardName.Validating += new System.ComponentModel.CancelEventHandler(this.TbAwardName_Validating);
            this.tbAwardName.Validated += new System.EventHandler(this.TbAwardName_Validated);
            // 
            // tbAwardDesc
            // 
            this.tbAwardDesc.Location = new System.Drawing.Point(92, 71);
            this.tbAwardDesc.Name = "tbAwardDesc";
            this.tbAwardDesc.Size = new System.Drawing.Size(116, 20);
            this.tbAwardDesc.TabIndex = 1;
            this.tbAwardDesc.Validating += new System.ComponentModel.CancelEventHandler(this.TbAwardDesc_Validating);
            this.tbAwardDesc.Validated += new System.EventHandler(this.TbAwardDesc_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Описание";
            // 
            // btnOk
            // 
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOk.Location = new System.Drawing.Point(0, 152);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(260, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "button1";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCancel.Location = new System.Drawing.Point(0, 129);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(260, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // erTextAwardName
            // 
            this.erTextAwardName.ContainerControl = this;
            // 
            // erTextAwardDesc
            // 
            this.erTextAwardDesc.ContainerControl = this;
            // 
            // AwardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 175);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAwardDesc);
            this.Controls.Add(this.tbAwardName);
            this.Name = "AwardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Награды";
            this.Load += new System.EventHandler(this.AwardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erTextAwardName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erTextAwardDesc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAwardName;
        private System.Windows.Forms.TextBox tbAwardDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider erTextAwardName;
        private System.Windows.Forms.ErrorProvider erTextAwardDesc;
    }
}