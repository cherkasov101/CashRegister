namespace CashRegister
{
    partial class WorkingForm
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.CollapseButton = new System.Windows.Forms.Button();
            this.addEmployee = new System.Windows.Forms.Label();
            this.addProduct = new System.Windows.Forms.Label();
            this.nameEmployee = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.idProduct = new System.Windows.Forms.TextBox();
            this.countProduct = new System.Windows.Forms.TextBox();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.receiptTextBox = new System.Windows.Forms.RichTextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPayInCard = new System.Windows.Forms.Button();
            this.btnPayInCash = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.CloseButton.Location = new System.Drawing.Point(789, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(37, 35);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "x";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // CollapseButton
            // 
            this.CollapseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CollapseButton.FlatAppearance.BorderSize = 0;
            this.CollapseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CollapseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollapseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.CollapseButton.Location = new System.Drawing.Point(755, 0);
            this.CollapseButton.Name = "CollapseButton";
            this.CollapseButton.Size = new System.Drawing.Size(37, 35);
            this.CollapseButton.TabIndex = 1;
            this.CollapseButton.Text = "-";
            this.CollapseButton.UseVisualStyleBackColor = true;
            this.CollapseButton.Click += new System.EventHandler(this.CollapseButton_Click);
            // 
            // addEmployee
            // 
            this.addEmployee.AutoSize = true;
            this.addEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.addEmployee.Location = new System.Drawing.Point(437, 16);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(160, 19);
            this.addEmployee.TabIndex = 2;
            this.addEmployee.Text = "Добавить сотрудника";
            this.addEmployee.Click += new System.EventHandler(this.addEmployee_Click);
            // 
            // addProduct
            // 
            this.addProduct.AutoSize = true;
            this.addProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addProduct.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.addProduct.Location = new System.Drawing.Point(614, 16);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(120, 19);
            this.addProduct.TabIndex = 3;
            this.addProduct.Text = "Добавить товар";
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // nameEmployee
            // 
            this.nameEmployee.AutoSize = true;
            this.nameEmployee.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.nameEmployee.Location = new System.Drawing.Point(64, 12);
            this.nameEmployee.Name = "nameEmployee";
            this.nameEmployee.Size = new System.Drawing.Size(58, 23);
            this.nameEmployee.TabIndex = 4;
            this.nameEmployee.Text = "ФИО";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CashRegister.Properties.Resources._2931147_user_face_avatar_account_head_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // idProduct
            // 
            this.idProduct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idProduct.Location = new System.Drawing.Point(66, 81);
            this.idProduct.Name = "idProduct";
            this.idProduct.Size = new System.Drawing.Size(149, 30);
            this.idProduct.TabIndex = 6;
            // 
            // countProduct
            // 
            this.countProduct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countProduct.Location = new System.Drawing.Point(278, 81);
            this.countProduct.Name = "countProduct";
            this.countProduct.Size = new System.Drawing.Size(54, 30);
            this.countProduct.TabIndex = 7;
            this.countProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMinus
            // 
            this.btnMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.btnMinus.Location = new System.Drawing.Point(232, 81);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(40, 30);
            this.btnMinus.TabIndex = 8;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.btnPlus.Location = new System.Drawing.Point(338, 81);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(40, 30);
            this.btnPlus.TabIndex = 9;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.Color.White;
            this.btnOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOne.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(71)))), ((int)(((byte)(59)))));
            this.btnOne.Location = new System.Drawing.Point(66, 128);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(100, 100);
            this.btnOne.TabIndex = 19;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.Color.White;
            this.btnTwo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(71)))), ((int)(((byte)(59)))));
            this.btnTwo.Location = new System.Drawing.Point(172, 128);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(100, 100);
            this.btnTwo.TabIndex = 20;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.Color.White;
            this.btnFive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(71)))), ((int)(((byte)(59)))));
            this.btnFive.Location = new System.Drawing.Point(172, 233);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(100, 100);
            this.btnFive.TabIndex = 21;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.Color.White;
            this.btnSix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(71)))), ((int)(((byte)(59)))));
            this.btnSix.Location = new System.Drawing.Point(278, 233);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(100, 100);
            this.btnSix.TabIndex = 22;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.Color.White;
            this.btnThree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(71)))), ((int)(((byte)(59)))));
            this.btnThree.Location = new System.Drawing.Point(278, 128);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(100, 100);
            this.btnThree.TabIndex = 23;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.Color.White;
            this.btnFour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(71)))), ((int)(((byte)(59)))));
            this.btnFour.Location = new System.Drawing.Point(66, 233);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(100, 100);
            this.btnFour.TabIndex = 24;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.Color.White;
            this.btnSeven.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeven.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(71)))), ((int)(((byte)(59)))));
            this.btnSeven.Location = new System.Drawing.Point(66, 338);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(100, 100);
            this.btnSeven.TabIndex = 25;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.Color.White;
            this.btnEight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(71)))), ((int)(((byte)(59)))));
            this.btnEight.Location = new System.Drawing.Point(172, 338);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(100, 100);
            this.btnEight.TabIndex = 26;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(71)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.receiptTextBox);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnPayInCard);
            this.panel1.Controls.Add(this.btnPayInCash);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnNine);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnZero);
            this.panel1.Controls.Add(this.btnEight);
            this.panel1.Controls.Add(this.btnSeven);
            this.panel1.Controls.Add(this.btnFour);
            this.panel1.Controls.Add(this.btnThree);
            this.panel1.Controls.Add(this.btnSix);
            this.panel1.Controls.Add(this.btnFive);
            this.panel1.Controls.Add(this.btnTwo);
            this.panel1.Controls.Add(this.btnOne);
            this.panel1.Controls.Add(this.btnPlus);
            this.panel1.Controls.Add(this.btnMinus);
            this.panel1.Controls.Add(this.countProduct);
            this.panel1.Controls.Add(this.idProduct);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.nameEmployee);
            this.panel1.Controls.Add(this.addProduct);
            this.panel1.Controls.Add(this.addEmployee);
            this.panel1.Controls.Add(this.CollapseButton);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 583);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // receiptTextBox
            // 
            this.receiptTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptTextBox.Location = new System.Drawing.Point(468, 81);
            this.receiptTextBox.Name = "receiptTextBox";
            this.receiptTextBox.Size = new System.Drawing.Size(312, 357);
            this.receiptTextBox.TabIndex = 34;
            this.receiptTextBox.Text = "";
            this.receiptTextBox.Click += new System.EventHandler(this.receiptTextBox_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(71)))), ((int)(((byte)(59)))));
            this.btnBack.Location = new System.Drawing.Point(680, 444);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 100);
            this.btnBack.TabIndex = 33;
            this.btnBack.Text = "Выход";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPayInCard
            // 
            this.btnPayInCard.BackColor = System.Drawing.Color.White;
            this.btnPayInCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayInCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayInCard.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayInCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(71)))), ((int)(((byte)(59)))));
            this.btnPayInCard.Location = new System.Drawing.Point(574, 444);
            this.btnPayInCard.Name = "btnPayInCard";
            this.btnPayInCard.Size = new System.Drawing.Size(100, 100);
            this.btnPayInCard.TabIndex = 32;
            this.btnPayInCard.Text = "Оплата картой";
            this.btnPayInCard.UseVisualStyleBackColor = false;
            this.btnPayInCard.Click += new System.EventHandler(this.btnPayInCard_Click);
            // 
            // btnPayInCash
            // 
            this.btnPayInCash.BackColor = System.Drawing.Color.White;
            this.btnPayInCash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayInCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayInCash.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayInCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(71)))), ((int)(((byte)(59)))));
            this.btnPayInCash.Location = new System.Drawing.Point(468, 444);
            this.btnPayInCash.Name = "btnPayInCash";
            this.btnPayInCash.Size = new System.Drawing.Size(100, 100);
            this.btnPayInCash.TabIndex = 31;
            this.btnPayInCash.Text = "Оплата налич.";
            this.btnPayInCash.UseVisualStyleBackColor = false;
            this.btnPayInCash.Click += new System.EventHandler(this.btnPayInCash_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(71)))), ((int)(((byte)(59)))));
            this.btnAdd.Location = new System.Drawing.Point(66, 444);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 100);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.Color.White;
            this.btnNine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(71)))), ((int)(((byte)(59)))));
            this.btnNine.Location = new System.Drawing.Point(278, 339);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(100, 100);
            this.btnNine.TabIndex = 29;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(71)))), ((int)(((byte)(59)))));
            this.btnDelete.Location = new System.Drawing.Point(278, 444);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 100);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.White;
            this.btnZero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(71)))), ((int)(((byte)(59)))));
            this.btnZero.Location = new System.Drawing.Point(172, 444);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(100, 100);
            this.btnZero.TabIndex = 27;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // WorkingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 583);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkingForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button CollapseButton;
        private System.Windows.Forms.Label addEmployee;
        private System.Windows.Forms.Label addProduct;
        private System.Windows.Forms.Label nameEmployee;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox idProduct;
        private System.Windows.Forms.TextBox countProduct;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPayInCard;
        private System.Windows.Forms.Button btnPayInCash;
        private System.Windows.Forms.RichTextBox receiptTextBox;
    }
}