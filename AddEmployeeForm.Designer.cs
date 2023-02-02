namespace CashRegister
{
    partial class AddEmployeeForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CollapseButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.surnameField = new System.Windows.Forms.TextBox();
            this.nameField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.patronymicField = new System.Windows.Forms.TextBox();
            this.adminField = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(71)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.adminField);
            this.panel1.Controls.Add(this.passwordField);
            this.panel1.Controls.Add(this.patronymicField);
            this.panel1.Controls.Add(this.nameField);
            this.panel1.Controls.Add(this.surnameField);
            this.panel1.Controls.Add(this.CollapseButton);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 497);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // CollapseButton
            // 
            this.CollapseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CollapseButton.FlatAppearance.BorderSize = 0;
            this.CollapseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CollapseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollapseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.CollapseButton.Location = new System.Drawing.Point(256, 3);
            this.CollapseButton.Name = "CollapseButton";
            this.CollapseButton.Size = new System.Drawing.Size(37, 35);
            this.CollapseButton.TabIndex = 1;
            this.CollapseButton.Text = "-";
            this.CollapseButton.UseVisualStyleBackColor = true;
            this.CollapseButton.Click += new System.EventHandler(this.CollapseButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.CloseButton.Location = new System.Drawing.Point(286, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(37, 35);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "x";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // surnameField
            // 
            this.surnameField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameField.Location = new System.Drawing.Point(60, 76);
            this.surnameField.Name = "surnameField";
            this.surnameField.Size = new System.Drawing.Size(204, 30);
            this.surnameField.TabIndex = 2;
            this.surnameField.Click += new System.EventHandler(this.surnameField_Click);
            // 
            // nameField
            // 
            this.nameField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameField.Location = new System.Drawing.Point(60, 131);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(204, 30);
            this.nameField.TabIndex = 3;
            this.nameField.Click += new System.EventHandler(this.nameField_Click);
            // 
            // passwordField
            // 
            this.passwordField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordField.Location = new System.Drawing.Point(60, 242);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(204, 30);
            this.passwordField.TabIndex = 5;
            this.passwordField.Click += new System.EventHandler(this.passwordField_Click);
            // 
            // patronymicField
            // 
            this.patronymicField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patronymicField.Location = new System.Drawing.Point(60, 187);
            this.patronymicField.Name = "patronymicField";
            this.patronymicField.Size = new System.Drawing.Size(204, 30);
            this.patronymicField.TabIndex = 4;
            this.patronymicField.Click += new System.EventHandler(this.patronymicField_Click);
            // 
            // adminField
            // 
            this.adminField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminField.FormattingEnabled = true;
            this.adminField.Items.AddRange(new object[] {
            "Кассир",
            "Администратор"});
            this.adminField.Location = new System.Drawing.Point(60, 297);
            this.adminField.Name = "adminField";
            this.adminField.Size = new System.Drawing.Size(204, 30);
            this.adminField.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.btnAdd.Location = new System.Drawing.Point(60, 367);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(204, 49);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 497);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEmployee";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CollapseButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox surnameField;
        private System.Windows.Forms.ComboBox adminField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.TextBox patronymicField;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Button btnAdd;
    }
}