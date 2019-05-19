namespace Entities
{
    partial class UserForm
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
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.dateDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.clbUsersAwards = new System.Windows.Forms.CheckedListBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.erTextLastName = new System.Windows.Forms.ErrorProvider(this.components);
            this.erTextFirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.erDateDateOfBirth = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erTextLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erTextFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erDateDateOfBirth)).BeginInit();
            this.SuspendLayout();
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(98, 59);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(125, 20);
            this.textFirstName.TabIndex = 1;
            this.textFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.TextFirstName_Validating);
            this.textFirstName.Validated += new System.EventHandler(this.TextFirstName_Validated);
            // 
            // dateDateOfBirth
            // 
            this.dateDateOfBirth.Location = new System.Drawing.Point(98, 92);
            this.dateDateOfBirth.Name = "dateDateOfBirth";
            this.dateDateOfBirth.Size = new System.Drawing.Size(125, 20);
            this.dateDateOfBirth.TabIndex = 2;
            this.dateDateOfBirth.Validating += new System.ComponentModel.CancelEventHandler(this.DateDateOfBirth_Validating);
            this.dateDateOfBirth.Validated += new System.EventHandler(this.DateDateOfBirth_Validated);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(63, 62);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Имя";
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Location = new System.Drawing.Point(12, 95);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(80, 13);
            this.labelDateOfBirth.TabIndex = 2;
            this.labelDateOfBirth.Text = "Дата рждения";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(36, 29);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(56, 13);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Фамилия";
            // 
            // btnOk
            // 
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOk.Location = new System.Drawing.Point(0, 287);
            this.btnOk.Name = "btnOk";
            this.btnOk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnOk.Size = new System.Drawing.Size(260, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCancel.Location = new System.Drawing.Point(0, 264);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancel.Size = new System.Drawing.Size(260, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // clbUsersAwards
            // 
            this.clbUsersAwards.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clbUsersAwards.FormattingEnabled = true;
            this.clbUsersAwards.Location = new System.Drawing.Point(0, 125);
            this.clbUsersAwards.Name = "clbUsersAwards";
            this.clbUsersAwards.Size = new System.Drawing.Size(260, 139);
            this.clbUsersAwards.TabIndex = 4;
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(98, 29);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(125, 20);
            this.textLastName.TabIndex = 0;
            this.textLastName.Validating += new System.ComponentModel.CancelEventHandler(this.TextLastName_Validating);
            this.textLastName.Validated += new System.EventHandler(this.TextLastName_Validated);
            // 
            // erTextLastName
            // 
            this.erTextLastName.ContainerControl = this;
            // 
            // erTextFirstName
            // 
            this.erTextFirstName.ContainerControl = this;
            // 
            // erDateDateOfBirth
            // 
            this.erDateDateOfBirth.ContainerControl = this;
            // 
            // UserForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(260, 310);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.clbUsersAwards);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.labelDateOfBirth);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.dateDateOfBirth);
            this.Controls.Add(this.textFirstName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Пльзователь";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erTextLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erTextFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erDateDateOfBirth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.DateTimePicker dateDateOfBirth;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckedListBox clbUsersAwards;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.ErrorProvider erTextLastName;
        private System.Windows.Forms.ErrorProvider erTextFirstName;
        private System.Windows.Forms.ErrorProvider erDateDateOfBirth;
    }
}