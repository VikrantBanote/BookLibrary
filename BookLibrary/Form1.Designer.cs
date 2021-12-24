
namespace BookLibrary
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.CancelUser = new System.Windows.Forms.Button();
            this.DeleteUser = new System.Windows.Forms.Button();
            this.UpdateUser = new System.Windows.Forms.Button();
            this.ResetUser = new System.Windows.Forms.Button();
            this.AddUsers = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.UserAddress = new System.Windows.Forms.TextBox();
            this.UserContact = new System.Windows.Forms.TextBox();
            this.UserMail = new System.Windows.Forms.TextBox();
            this.UserId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxBookName = new System.Windows.Forms.TextBox();
            this.dataGridViewBook = new System.Windows.Forms.DataGridView();
            this.CancelBook = new System.Windows.Forms.Button();
            this.DeleteBook = new System.Windows.Forms.Button();
            this.UpdateBook = new System.Windows.Forms.Button();
            this.ResetBook = new System.Windows.Forms.Button();
            this.AddBook = new System.Windows.Forms.Button();
            this.BookDesc = new System.Windows.Forms.TextBox();
            this.AuthorName = new System.Windows.Forms.TextBox();
            this.BookId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ButtonReturn = new System.Windows.Forms.Button();
            this.buttonIssue = new System.Windows.Forms.Button();
            this.dataGridViewAllocation = new System.Windows.Forms.DataGridView();
            this.AllocationReturnDate = new System.Windows.Forms.TextBox();
            this.AllocationIssuedDate = new System.Windows.Forms.TextBox();
            this.AllocationUserId = new System.Windows.Forms.TextBox();
            this.AllocationBookId = new System.Windows.Forms.TextBox();
            this.comboBoxBookName = new System.Windows.Forms.ComboBox();
            this.AllocationUserName = new System.Windows.Forms.ComboBox();
            this.AllocationId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllocation)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-4, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 536);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.textBoxUserName);
            this.tabPage1.Controls.Add(this.dataGridViewUser);
            this.tabPage1.Controls.Add(this.CancelUser);
            this.tabPage1.Controls.Add(this.DeleteUser);
            this.tabPage1.Controls.Add(this.UpdateUser);
            this.tabPage1.Controls.Add(this.ResetUser);
            this.tabPage1.Controls.Add(this.AddUsers);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.UserAddress);
            this.tabPage1.Controls.Add(this.UserContact);
            this.tabPage1.Controls.Add(this.UserMail);
            this.tabPage1.Controls.Add(this.UserId);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(796, 502);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "User Details";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(203, 100);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(147, 29);
            this.textBoxUserName.TabIndex = 34;
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Location = new System.Drawing.Point(-1, 299);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.Size = new System.Drawing.Size(800, 203);
            this.dataGridViewUser.TabIndex = 33;
            this.dataGridViewUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridViewUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // CancelUser
            // 
            this.CancelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelUser.Location = new System.Drawing.Point(528, 231);
            this.CancelUser.Name = "CancelUser";
            this.CancelUser.Size = new System.Drawing.Size(87, 40);
            this.CancelUser.TabIndex = 32;
            this.CancelUser.Text = "CANCEL";
            this.CancelUser.UseVisualStyleBackColor = true;
            this.CancelUser.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // DeleteUser
            // 
            this.DeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteUser.Location = new System.Drawing.Point(528, 148);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(87, 37);
            this.DeleteUser.TabIndex = 31;
            this.DeleteUser.Text = "DELETE";
            this.DeleteUser.UseVisualStyleBackColor = true;
            this.DeleteUser.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // UpdateUser
            // 
            this.UpdateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateUser.Location = new System.Drawing.Point(528, 70);
            this.UpdateUser.Name = "UpdateUser";
            this.UpdateUser.Size = new System.Drawing.Size(87, 39);
            this.UpdateUser.TabIndex = 30;
            this.UpdateUser.Text = "UPDATE";
            this.UpdateUser.UseVisualStyleBackColor = true;
            this.UpdateUser.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // ResetUser
            // 
            this.ResetUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetUser.Location = new System.Drawing.Point(380, 210);
            this.ResetUser.Name = "ResetUser";
            this.ResetUser.Size = new System.Drawing.Size(87, 27);
            this.ResetUser.TabIndex = 29;
            this.ResetUser.Text = "RESET";
            this.ResetUser.UseVisualStyleBackColor = true;
            this.ResetUser.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // AddUsers
            // 
            this.AddUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUsers.Location = new System.Drawing.Point(380, 127);
            this.AddUsers.Name = "AddUsers";
            this.AddUsers.Size = new System.Drawing.Size(87, 27);
            this.AddUsers.TabIndex = 28;
            this.AddUsers.Text = "ADD";
            this.AddUsers.UseVisualStyleBackColor = true;
            this.AddUsers.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Coral;
            this.label6.Font = new System.Drawing.Font("Nirmala UI Semilight", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(223, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(331, 37);
            this.label6.TabIndex = 27;
            this.label6.Text = "USER ACCOUNT DETAILS";
            // 
            // UserAddress
            // 
            this.UserAddress.Location = new System.Drawing.Point(203, 230);
            this.UserAddress.Multiline = true;
            this.UserAddress.Name = "UserAddress";
            this.UserAddress.Size = new System.Drawing.Size(146, 55);
            this.UserAddress.TabIndex = 26;
            // 
            // UserContact
            // 
            this.UserContact.Location = new System.Drawing.Point(203, 188);
            this.UserContact.Name = "UserContact";
            this.UserContact.Size = new System.Drawing.Size(146, 29);
            this.UserContact.TabIndex = 25;
            this.UserContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserContact_KeyPress);
            // 
            // UserMail
            // 
            this.UserMail.Location = new System.Drawing.Point(203, 145);
            this.UserMail.Name = "UserMail";
            this.UserMail.Size = new System.Drawing.Size(146, 29);
            this.UserMail.TabIndex = 24;
            // 
            // UserId
            // 
            this.UserId.Location = new System.Drawing.Point(203, 55);
            this.UserId.Name = "UserId";
            this.UserId.Size = new System.Drawing.Size(146, 29);
            this.UserId.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Pink;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Pink;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Contact Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Pink;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Email ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Pink;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "User Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Pink;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "User ID:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxBookName);
            this.tabPage2.Controls.Add(this.dataGridViewBook);
            this.tabPage2.Controls.Add(this.CancelBook);
            this.tabPage2.Controls.Add(this.DeleteBook);
            this.tabPage2.Controls.Add(this.UpdateBook);
            this.tabPage2.Controls.Add(this.ResetBook);
            this.tabPage2.Controls.Add(this.AddBook);
            this.tabPage2.Controls.Add(this.BookDesc);
            this.tabPage2.Controls.Add(this.AuthorName);
            this.tabPage2.Controls.Add(this.BookId);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(796, 502);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Book Details";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxBookName
            // 
            this.textBoxBookName.Location = new System.Drawing.Point(183, 123);
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.Size = new System.Drawing.Size(159, 29);
            this.textBoxBookName.TabIndex = 30;
            // 
            // dataGridViewBook
            // 
            this.dataGridViewBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBook.Location = new System.Drawing.Point(-7, 255);
            this.dataGridViewBook.Name = "dataGridViewBook";
            this.dataGridViewBook.Size = new System.Drawing.Size(810, 217);
            this.dataGridViewBook.TabIndex = 29;
            this.dataGridViewBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBook_CellClick);
            this.dataGridViewBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBook_CellClick);
            // 
            // CancelBook
            // 
            this.CancelBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBook.Location = new System.Drawing.Point(542, 198);
            this.CancelBook.Name = "CancelBook";
            this.CancelBook.Size = new System.Drawing.Size(117, 29);
            this.CancelBook.TabIndex = 28;
            this.CancelBook.Text = "CANCEL";
            this.CancelBook.UseVisualStyleBackColor = true;
            this.CancelBook.Click += new System.EventHandler(this.button6_Click);
            // 
            // DeleteBook
            // 
            this.DeleteBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBook.Location = new System.Drawing.Point(542, 134);
            this.DeleteBook.Name = "DeleteBook";
            this.DeleteBook.Size = new System.Drawing.Size(117, 32);
            this.DeleteBook.TabIndex = 27;
            this.DeleteBook.Text = "DELETE";
            this.DeleteBook.UseVisualStyleBackColor = true;
            this.DeleteBook.Click += new System.EventHandler(this.button7_Click);
            // 
            // UpdateBook
            // 
            this.UpdateBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBook.Location = new System.Drawing.Point(542, 71);
            this.UpdateBook.Name = "UpdateBook";
            this.UpdateBook.Size = new System.Drawing.Size(117, 33);
            this.UpdateBook.TabIndex = 26;
            this.UpdateBook.Text = "UPDATE";
            this.UpdateBook.UseVisualStyleBackColor = true;
            this.UpdateBook.Click += new System.EventHandler(this.button8_Click);
            // 
            // ResetBook
            // 
            this.ResetBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBook.Location = new System.Drawing.Point(384, 166);
            this.ResetBook.Name = "ResetBook";
            this.ResetBook.Size = new System.Drawing.Size(86, 32);
            this.ResetBook.TabIndex = 25;
            this.ResetBook.Text = "RESET";
            this.ResetBook.UseVisualStyleBackColor = true;
            this.ResetBook.Click += new System.EventHandler(this.button9_Click);
            // 
            // AddBook
            // 
            this.AddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBook.Location = new System.Drawing.Point(384, 98);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(86, 32);
            this.AddBook.TabIndex = 24;
            this.AddBook.Text = "ADD";
            this.AddBook.UseVisualStyleBackColor = true;
            this.AddBook.Click += new System.EventHandler(this.button10_Click);
            // 
            // BookDesc
            // 
            this.BookDesc.Location = new System.Drawing.Point(183, 203);
            this.BookDesc.Name = "BookDesc";
            this.BookDesc.Size = new System.Drawing.Size(159, 29);
            this.BookDesc.TabIndex = 23;
            // 
            // AuthorName
            // 
            this.AuthorName.Location = new System.Drawing.Point(183, 165);
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Size = new System.Drawing.Size(159, 29);
            this.AuthorName.TabIndex = 22;
            // 
            // BookId
            // 
            this.BookId.Location = new System.Drawing.Point(183, 81);
            this.BookId.Name = "BookId";
            this.BookId.Size = new System.Drawing.Size(159, 29);
            this.BookId.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(233, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(276, 37);
            this.label7.TabIndex = 19;
            this.label7.Text = "Book Record Details";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightCoral;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Book Description:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightCoral;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Author Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.LightCoral;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Book Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.LightCoral;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(32, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "Book ID:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ButtonReturn);
            this.tabPage3.Controls.Add(this.buttonIssue);
            this.tabPage3.Controls.Add(this.dataGridViewAllocation);
            this.tabPage3.Controls.Add(this.AllocationReturnDate);
            this.tabPage3.Controls.Add(this.AllocationIssuedDate);
            this.tabPage3.Controls.Add(this.AllocationUserId);
            this.tabPage3.Controls.Add(this.AllocationBookId);
            this.tabPage3.Controls.Add(this.comboBoxBookName);
            this.tabPage3.Controls.Add(this.AllocationUserName);
            this.tabPage3.Controls.Add(this.AllocationId);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(796, 502);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Allocation";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ButtonReturn
            // 
            this.ButtonReturn.Location = new System.Drawing.Point(384, 261);
            this.ButtonReturn.Name = "ButtonReturn";
            this.ButtonReturn.Size = new System.Drawing.Size(105, 35);
            this.ButtonReturn.TabIndex = 35;
            this.ButtonReturn.Text = "Return";
            this.ButtonReturn.UseVisualStyleBackColor = true;
            this.ButtonReturn.Click += new System.EventHandler(this.ButtonReturn_Click);
            // 
            // buttonIssue
            // 
            this.buttonIssue.Location = new System.Drawing.Point(183, 261);
            this.buttonIssue.Name = "buttonIssue";
            this.buttonIssue.Size = new System.Drawing.Size(109, 35);
            this.buttonIssue.TabIndex = 34;
            this.buttonIssue.Text = "Issue";
            this.buttonIssue.UseVisualStyleBackColor = true;
            this.buttonIssue.Click += new System.EventHandler(this.buttonIssue_Click);
            // 
            // dataGridViewAllocation
            // 
            this.dataGridViewAllocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllocation.Location = new System.Drawing.Point(0, 302);
            this.dataGridViewAllocation.Name = "dataGridViewAllocation";
            this.dataGridViewAllocation.Size = new System.Drawing.Size(793, 201);
            this.dataGridViewAllocation.TabIndex = 33;
            this.dataGridViewAllocation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAllocation_CellClick);
            // 
            // AllocationReturnDate
            // 
            this.AllocationReturnDate.Location = new System.Drawing.Point(573, 219);
            this.AllocationReturnDate.Name = "AllocationReturnDate";
            this.AllocationReturnDate.Size = new System.Drawing.Size(194, 29);
            this.AllocationReturnDate.TabIndex = 32;
            // 
            // AllocationIssuedDate
            // 
            this.AllocationIssuedDate.Location = new System.Drawing.Point(183, 222);
            this.AllocationIssuedDate.Name = "AllocationIssuedDate";
            this.AllocationIssuedDate.Size = new System.Drawing.Size(194, 29);
            this.AllocationIssuedDate.TabIndex = 31;
           // this.AllocationIssuedDate.TextChanged += new System.EventHandler(this.AllocationIssuedDate_TextChanged);
            // 
            // AllocationUserId
            // 
            this.AllocationUserId.Location = new System.Drawing.Point(573, 120);
            this.AllocationUserId.Name = "AllocationUserId";
            this.AllocationUserId.Size = new System.Drawing.Size(194, 29);
            this.AllocationUserId.TabIndex = 30;
            // 
            // AllocationBookId
            // 
            this.AllocationBookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllocationBookId.Location = new System.Drawing.Point(573, 169);
            this.AllocationBookId.Name = "AllocationBookId";
            this.AllocationBookId.Size = new System.Drawing.Size(194, 23);
            this.AllocationBookId.TabIndex = 29;
            // 
            // comboBoxBookName
            // 
            this.comboBoxBookName.FormattingEnabled = true;
            this.comboBoxBookName.Location = new System.Drawing.Point(183, 165);
            this.comboBoxBookName.Name = "comboBoxBookName";
            this.comboBoxBookName.Size = new System.Drawing.Size(194, 29);
            this.comboBoxBookName.TabIndex = 28;
            this.comboBoxBookName.SelectedIndexChanged += new System.EventHandler(this.comboBoxBookName_SelectedIndexChanged);
            this.comboBoxBookName.SelectedValueChanged += new System.EventHandler(this.comboBoxBookName_SelectedValueChanged);
            // 
            // AllocationUserName
            // 
            this.AllocationUserName.FormattingEnabled = true;
            this.AllocationUserName.Location = new System.Drawing.Point(183, 123);
            this.AllocationUserName.Name = "AllocationUserName";
            this.AllocationUserName.Size = new System.Drawing.Size(194, 29);
            this.AllocationUserName.TabIndex = 27;
            this.AllocationUserName.SelectedIndexChanged += new System.EventHandler(this.AllocationUserName_SelectedIndexChanged);
            this.AllocationUserName.SelectedValueChanged += new System.EventHandler(this.AllocationUserName_SelectedValueChanged);
            // 
            // AllocationId
            // 
            this.AllocationId.Location = new System.Drawing.Point(183, 83);
            this.AllocationId.Name = "AllocationId";
            this.AllocationId.Size = new System.Drawing.Size(194, 29);
            this.AllocationId.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Coral;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkRed;
            this.label12.Location = new System.Drawing.Point(228, 13);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(342, 37);
            this.label12.TabIndex = 25;
            this.label12.Text = "Allocation Record Details";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.LightCoral;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(448, 222);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 17);
            this.label13.TabIndex = 24;
            this.label13.Text = "Return Date:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.LightCoral;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(29, 225);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 17);
            this.label14.TabIndex = 23;
            this.label14.Text = "Issued Date:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.LightCoral;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(29, 172);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 17);
            this.label15.TabIndex = 22;
            this.label15.Text = "Book Name:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.LightCoral;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(29, 126);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 17);
            this.label16.TabIndex = 21;
            this.label16.Text = "User Name:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.LightCoral;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(448, 172);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 17);
            this.label17.TabIndex = 20;
            this.label17.Text = "Book ID:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.LightCoral;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(450, 126);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 17);
            this.label18.TabIndex = 19;
            this.label18.Text = "User ID:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.LightCoral;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(26, 84);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 17);
            this.label19.TabIndex = 18;
            this.label19.Text = "Allocation ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllocation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button CancelUser;
        private System.Windows.Forms.Button DeleteUser;
        private System.Windows.Forms.Button UpdateUser;
        private System.Windows.Forms.Button ResetUser;
        private System.Windows.Forms.Button AddUsers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox UserAddress;
        private System.Windows.Forms.TextBox UserContact;
        private System.Windows.Forms.TextBox UserMail;
     
        private System.Windows.Forms.TextBox UserId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewBook;
        private System.Windows.Forms.Button CancelBook;
        private System.Windows.Forms.Button DeleteBook;
        private System.Windows.Forms.Button UpdateBook;
        private System.Windows.Forms.Button ResetBook;
        private System.Windows.Forms.Button AddBook;
        private System.Windows.Forms.TextBox BookDesc;
        private System.Windows.Forms.TextBox AuthorName;
     
        private System.Windows.Forms.TextBox BookId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.Button ButtonReturn;
        private System.Windows.Forms.Button buttonIssue;
        private System.Windows.Forms.DataGridView dataGridViewAllocation;
        private System.Windows.Forms.TextBox AllocationReturnDate;
        private System.Windows.Forms.TextBox AllocationIssuedDate;
        private System.Windows.Forms.TextBox AllocationUserId;
        private System.Windows.Forms.TextBox AllocationBookId;
        private System.Windows.Forms.ComboBox comboBoxBookName;
        private System.Windows.Forms.ComboBox AllocationUserName;
        private System.Windows.Forms.TextBox AllocationId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxBookName;
    }
}

