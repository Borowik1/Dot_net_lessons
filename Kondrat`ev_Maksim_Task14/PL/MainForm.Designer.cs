namespace PL
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.ctlFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUser = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditUser = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAwards = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddAward = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditAward = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteAward = new System.Windows.Forms.ToolStripMenuItem();
            this.разделительToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlHelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrUsersContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAddUserContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditUserContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteUserContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrGridUser = new System.Windows.Forms.DataGridView();
            this.tabUsers = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ctrAwardsContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAddAwardContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditAwardContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteAwardContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrGridAward = new System.Windows.Forms.DataGridView();
            this.AwardName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AwardDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Awards = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainMenu.SuspendLayout();
            this.ctrUsersContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctrGridUser)).BeginInit();
            this.tabUsers.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.ctrAwardsContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctrGridAward)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlFileMenu,
            this.ctlHelpMenu});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(555, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // ctlFileMenu
            // 
            this.ctlFileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUser,
            this.btnAwards,
            this.разделительToolStripMenuItem,
            this.btnExit});
            this.ctlFileMenu.Name = "ctlFileMenu";
            this.ctlFileMenu.Size = new System.Drawing.Size(48, 20);
            this.ctlFileMenu.Text = "Файл";
            // 
            // btnUser
            // 
            this.btnUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddUser,
            this.btnEditUser,
            this.btnDeleteUser});
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(180, 22);
            this.btnUser.Text = "Пользователи";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(180, 22);
            this.btnAddUser.Text = "Добавить...";
            this.btnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click_1);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(180, 22);
            this.btnEditUser.Text = "Редактировать...";
            this.btnEditUser.Click += new System.EventHandler(this.BtnEditUser_Click_1);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(180, 22);
            this.btnDeleteUser.Text = "Удалить";
            this.btnDeleteUser.Click += new System.EventHandler(this.BtnDeleteUser_Click);
            // 
            // btnAwards
            // 
            this.btnAwards.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddAward,
            this.btnEditAward,
            this.btnDeleteAward});
            this.btnAwards.Name = "btnAwards";
            this.btnAwards.Size = new System.Drawing.Size(180, 22);
            this.btnAwards.Text = "Награды";
            // 
            // btnAddAward
            // 
            this.btnAddAward.Name = "btnAddAward";
            this.btnAddAward.Size = new System.Drawing.Size(180, 22);
            this.btnAddAward.Text = "Добавить...";
            this.btnAddAward.Click += new System.EventHandler(this.BtnAddAward_Click);
            // 
            // btnEditAward
            // 
            this.btnEditAward.Name = "btnEditAward";
            this.btnEditAward.Size = new System.Drawing.Size(180, 22);
            this.btnEditAward.Text = "Редактировать...";
            this.btnEditAward.Click += new System.EventHandler(this.BtnEditAward_Click);
            // 
            // btnDeleteAward
            // 
            this.btnDeleteAward.Name = "btnDeleteAward";
            this.btnDeleteAward.Size = new System.Drawing.Size(180, 22);
            this.btnDeleteAward.Text = "Удалить";
            this.btnDeleteAward.Click += new System.EventHandler(this.BtnDeleteAward_Click);
            // 
            // разделительToolStripMenuItem
            // 
            this.разделительToolStripMenuItem.Name = "разделительToolStripMenuItem";
            this.разделительToolStripMenuItem.Size = new System.Drawing.Size(177, 6);
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.btnExit.Size = new System.Drawing.Size(180, 22);
            this.btnExit.Text = "Выход";
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // ctlHelpMenu
            // 
            this.ctlHelpMenu.Name = "ctlHelpMenu";
            this.ctlHelpMenu.Size = new System.Drawing.Size(68, 20);
            this.ctlHelpMenu.Text = "Помощь";
            // 
            // ctrUsersContextMenu
            // 
            this.ctrUsersContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddUserContextMenu,
            this.btnEditUserContextMenu,
            this.btnDeleteUserContextMenu});
            this.ctrUsersContextMenu.Name = "contextMenuStrip1";
            this.ctrUsersContextMenu.Size = new System.Drawing.Size(164, 70);
            // 
            // btnAddUserContextMenu
            // 
            this.btnAddUserContextMenu.Name = "btnAddUserContextMenu";
            this.btnAddUserContextMenu.Size = new System.Drawing.Size(163, 22);
            this.btnAddUserContextMenu.Text = "Добавить...";
            this.btnAddUserContextMenu.Click += new System.EventHandler(this.BtnAddUserContextMenu_Click);
            // 
            // btnEditUserContextMenu
            // 
            this.btnEditUserContextMenu.Name = "btnEditUserContextMenu";
            this.btnEditUserContextMenu.Size = new System.Drawing.Size(163, 22);
            this.btnEditUserContextMenu.Text = "Редактировать...";
            this.btnEditUserContextMenu.Click += new System.EventHandler(this.BtnEditUserContextMenu_Click);
            // 
            // btnDeleteUserContextMenu
            // 
            this.btnDeleteUserContextMenu.Name = "btnDeleteUserContextMenu";
            this.btnDeleteUserContextMenu.Size = new System.Drawing.Size(163, 22);
            this.btnDeleteUserContextMenu.Text = "Удалить";
            this.btnDeleteUserContextMenu.Click += new System.EventHandler(this.BtnDeleteUserContextMenu_Click);
            // 
            // ctrGridUser
            // 
            this.ctrGridUser.AllowUserToAddRows = false;
            this.ctrGridUser.AllowUserToDeleteRows = false;
            this.ctrGridUser.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ctrGridUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ctrGridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctrGridUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Awards,
            this.Column4,
            this.Age});
            this.ctrGridUser.ContextMenuStrip = this.ctrUsersContextMenu;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ctrGridUser.DefaultCellStyle = dataGridViewCellStyle2;
            this.ctrGridUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrGridUser.Location = new System.Drawing.Point(3, 3);
            this.ctrGridUser.MultiSelect = false;
            this.ctrGridUser.Name = "ctrGridUser";
            this.ctrGridUser.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ctrGridUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ctrGridUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ctrGridUser.Size = new System.Drawing.Size(541, 246);
            this.ctrGridUser.TabIndex = 1;
            this.ctrGridUser.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CtrGrid_ColumnHeaderMouseClick);
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.tabPage1);
            this.tabUsers.Controls.Add(this.tabPage2);
            this.tabUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabUsers.Location = new System.Drawing.Point(0, 24);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.SelectedIndex = 0;
            this.tabUsers.Size = new System.Drawing.Size(555, 278);
            this.tabUsers.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ctrGridUser);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(547, 252);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Пользователи";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.ContextMenuStrip = this.ctrAwardsContextMenu;
            this.tabPage2.Controls.Add(this.ctrGridAward);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(547, 252);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Награды";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ctrAwardsContextMenu
            // 
            this.ctrAwardsContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddAwardContextMenu,
            this.btnEditAwardContextMenu,
            this.btnDeleteAwardContextMenu});
            this.ctrAwardsContextMenu.Name = "ctrAwardsContextMenu";
            this.ctrAwardsContextMenu.Size = new System.Drawing.Size(158, 70);
            // 
            // btnAddAwardContextMenu
            // 
            this.btnAddAwardContextMenu.Name = "btnAddAwardContextMenu";
            this.btnAddAwardContextMenu.Size = new System.Drawing.Size(157, 22);
            this.btnAddAwardContextMenu.Text = "Добавить...";
            this.btnAddAwardContextMenu.Click += new System.EventHandler(this.BtnAddAwardContextMenu_Click);
            // 
            // btnEditAwardContextMenu
            // 
            this.btnEditAwardContextMenu.Name = "btnEditAwardContextMenu";
            this.btnEditAwardContextMenu.Size = new System.Drawing.Size(157, 22);
            this.btnEditAwardContextMenu.Text = "Реактировать...";
            this.btnEditAwardContextMenu.Click += new System.EventHandler(this.BtnEditAwardContextMenu_Click);
            // 
            // btnDeleteAwardContextMenu
            // 
            this.btnDeleteAwardContextMenu.Name = "btnDeleteAwardContextMenu";
            this.btnDeleteAwardContextMenu.Size = new System.Drawing.Size(157, 22);
            this.btnDeleteAwardContextMenu.Text = "Удалить";
            this.btnDeleteAwardContextMenu.Click += new System.EventHandler(this.BtnDeleteAwardContextMenu_Click);
            // 
            // ctrGridAward
            // 
            this.ctrGridAward.AllowUserToAddRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ctrGridAward.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ctrGridAward.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctrGridAward.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AwardName,
            this.AwardDescription,
            this.Id});
            this.ctrGridAward.ContextMenuStrip = this.ctrAwardsContextMenu;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ctrGridAward.DefaultCellStyle = dataGridViewCellStyle5;
            this.ctrGridAward.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrGridAward.Location = new System.Drawing.Point(3, 3);
            this.ctrGridAward.MultiSelect = false;
            this.ctrGridAward.Name = "ctrGridAward";
            this.ctrGridAward.ReadOnly = true;
            this.ctrGridAward.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ctrGridAward.ShowEditingIcon = false;
            this.ctrGridAward.Size = new System.Drawing.Size(541, 246);
            this.ctrGridAward.TabIndex = 2;
            this.ctrGridAward.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CtrGridAward_ColumnHeaderMouseClick);
            // 
            // AwardName
            // 
            this.AwardName.DataPropertyName = "AwardName";
            this.AwardName.HeaderText = "Название";
            this.AwardName.Name = "AwardName";
            this.AwardName.ReadOnly = true;
            // 
            // AwardDescription
            // 
            this.AwardDescription.DataPropertyName = "AwardDescription";
            this.AwardDescription.HeaderText = "Описание";
            this.AwardDescription.Name = "AwardDescription";
            this.AwardDescription.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "AwardId";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "LastName";
            this.Column1.HeaderText = "Фамилия";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "FirstName";
            this.Column2.HeaderText = "Имя";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DateOfBirth";
            this.Column3.HeaderText = "Дата рождения";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Awards
            // 
            this.Awards.HeaderText = "Награды";
            this.Awards.Name = "Awards";
            this.Awards.ReadOnly = true;
            this.Awards.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Awards.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Id";
            this.Column4.HeaderText = "Id";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "Возраст";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 302);
            this.Controls.Add(this.tabUsers);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Пользователи и награды";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ctrUsersContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctrGridUser)).EndInit();
            this.tabUsers.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ctrAwardsContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctrGridAward)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ContextMenuStrip ctrUsersContextMenu;
        private System.Windows.Forms.ToolStripMenuItem ctlFileMenu;
        private System.Windows.Forms.ToolStripMenuItem btnUser;
        private System.Windows.Forms.ToolStripMenuItem btnAwards;
        private System.Windows.Forms.ToolStripMenuItem ctlHelpMenu;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.DataGridView ctrGridUser;
        private System.Windows.Forms.ToolStripMenuItem btnAddUserContextMenu;
        private System.Windows.Forms.TabControl tabUsers;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ContextMenuStrip ctrAwardsContextMenu;
        private System.Windows.Forms.ToolStripMenuItem btnEditUserContextMenu;
        private System.Windows.Forms.ToolStripMenuItem btnAddAwardContextMenu;
        private System.Windows.Forms.ToolStripMenuItem btnEditAwardContextMenu;
        private System.Windows.Forms.ToolStripSeparator разделительToolStripMenuItem;
        private System.Windows.Forms.DataGridView ctrGridAward;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteAwardContextMenu;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteUserContextMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn AwardName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AwardDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.ToolStripMenuItem btnAddUser;
        private System.Windows.Forms.ToolStripMenuItem btnEditUser;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteUser;
        private System.Windows.Forms.ToolStripMenuItem btnAddAward;
        private System.Windows.Forms.ToolStripMenuItem btnEditAward;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteAward;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Awards;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
    }
}

