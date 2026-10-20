namespace libraryManagement
{
    partial class formLibrary
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLibrary));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.tabMembers = new System.Windows.Forms.TabPage();
            this.btnSearchMember = new MaterialSkin.Controls.MaterialButton();
            this.btnDeleteMember = new MaterialSkin.Controls.MaterialButton();
            this.btnUpdateMember = new MaterialSkin.Controls.MaterialButton();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSurname = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPhone = new MaterialSkin.Controls.MaterialTextBox();
            this.btnAddMember = new MaterialSkin.Controls.MaterialButton();
            this.txtName = new MaterialSkin.Controls.MaterialTextBox();
            this.lblMemberManagement = new System.Windows.Forms.Label();
            this.dgvMemberList = new System.Windows.Forms.DataGridView();
            this.tabBooks = new System.Windows.Forms.TabPage();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.btnSearchBook = new MaterialSkin.Controls.MaterialButton();
            this.btnUpdateBook = new MaterialSkin.Controls.MaterialButton();
            this.btnDeleteBook = new MaterialSkin.Controls.MaterialButton();
            this.btnAddBook = new MaterialSkin.Controls.MaterialButton();
            this.txtStock = new MaterialSkin.Controls.MaterialTextBox();
            this.txtAuthor = new MaterialSkin.Controls.MaterialTextBox();
            this.txtYear = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBookName = new MaterialSkin.Controls.MaterialTextBox();
            this.lblBookManagement = new System.Windows.Forms.Label();
            this.dgvBookList = new System.Windows.Forms.DataGridView();
            this.tabLoans = new System.Windows.Forms.TabPage();
            this.txtLoanDate = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBookID = new MaterialSkin.Controls.MaterialTextBox();
            this.txtReturnDate = new MaterialSkin.Controls.MaterialTextBox();
            this.txtMemberID = new MaterialSkin.Controls.MaterialTextBox();
            this.dgvLoanList = new System.Windows.Forms.DataGridView();
            this.lblLoanManagement = new System.Windows.Forms.Label();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.lblLang = new System.Windows.Forms.Label();
            this.btnLang = new MaterialSkin.Controls.MaterialButton();
            this.Library_imList = new System.Windows.Forms.ImageList(this.components);
            this.lblMemberID = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            this.lblLoanDate = new System.Windows.Forms.Label();
            this.btnAddLoan = new MaterialSkin.Controls.MaterialButton();
            this.btnDeleteLoan = new MaterialSkin.Controls.MaterialButton();
            this.btnUpdateLoan = new MaterialSkin.Controls.MaterialButton();
            this.btnSearchLoan = new MaterialSkin.Controls.MaterialButton();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.materialTabControl1.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.tabMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).BeginInit();
            this.tabBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).BeginInit();
            this.tabLoans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanList)).BeginInit();
            this.tabSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabHome);
            this.materialTabControl1.Controls.Add(this.tabMembers);
            this.materialTabControl1.Controls.Add(this.tabBooks);
            this.materialTabControl1.Controls.Add(this.tabLoans);
            this.materialTabControl1.Controls.Add(this.tabSettings);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.Library_imList;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(880, 428);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.lblWelcome);
            this.tabHome.ImageKey = "icons8-home-48.png";
            this.tabHome.Location = new System.Drawing.Point(4, 25);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(872, 399);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // tabMembers
            // 
            this.tabMembers.Controls.Add(this.btnSearchMember);
            this.tabMembers.Controls.Add(this.btnDeleteMember);
            this.tabMembers.Controls.Add(this.btnUpdateMember);
            this.tabMembers.Controls.Add(this.lblPhone);
            this.tabMembers.Controls.Add(this.lblEmail);
            this.tabMembers.Controls.Add(this.lblSurname);
            this.tabMembers.Controls.Add(this.lblName);
            this.tabMembers.Controls.Add(this.txtEmail);
            this.tabMembers.Controls.Add(this.txtSurname);
            this.tabMembers.Controls.Add(this.txtPhone);
            this.tabMembers.Controls.Add(this.btnAddMember);
            this.tabMembers.Controls.Add(this.txtName);
            this.tabMembers.Controls.Add(this.lblMemberManagement);
            this.tabMembers.Controls.Add(this.dgvMemberList);
            this.tabMembers.ImageKey = "icons8-people-48.png";
            this.tabMembers.Location = new System.Drawing.Point(4, 25);
            this.tabMembers.Name = "tabMembers";
            this.tabMembers.Size = new System.Drawing.Size(872, 399);
            this.tabMembers.TabIndex = 1;
            this.tabMembers.Text = "Members";
            this.tabMembers.UseVisualStyleBackColor = true;
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.AutoSize = false;
            this.btnSearchMember.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearchMember.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSearchMember.Depth = 0;
            this.btnSearchMember.HighEmphasis = true;
            this.btnSearchMember.Icon = null;
            this.btnSearchMember.Location = new System.Drawing.Point(512, 202);
            this.btnSearchMember.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearchMember.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSearchMember.Size = new System.Drawing.Size(200, 40);
            this.btnSearchMember.TabIndex = 14;
            this.btnSearchMember.Text = "SEARCH MEMBER";
            this.btnSearchMember.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSearchMember.UseAccentColor = false;
            this.btnSearchMember.UseVisualStyleBackColor = true;
            this.btnSearchMember.Click += new System.EventHandler(this.btnSearchMember_Click);
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.AutoSize = false;
            this.btnDeleteMember.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteMember.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteMember.Depth = 0;
            this.btnDeleteMember.HighEmphasis = true;
            this.btnDeleteMember.Icon = null;
            this.btnDeleteMember.Location = new System.Drawing.Point(512, 74);
            this.btnDeleteMember.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteMember.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteMember.Size = new System.Drawing.Size(200, 40);
            this.btnDeleteMember.TabIndex = 13;
            this.btnDeleteMember.Text = "DELETE MEMBER";
            this.btnDeleteMember.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteMember.UseAccentColor = false;
            this.btnDeleteMember.UseVisualStyleBackColor = true;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // btnUpdateMember
            // 
            this.btnUpdateMember.AutoSize = false;
            this.btnUpdateMember.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdateMember.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUpdateMember.Depth = 0;
            this.btnUpdateMember.HighEmphasis = true;
            this.btnUpdateMember.Icon = null;
            this.btnUpdateMember.Location = new System.Drawing.Point(512, 138);
            this.btnUpdateMember.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdateMember.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdateMember.Name = "btnUpdateMember";
            this.btnUpdateMember.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUpdateMember.Size = new System.Drawing.Size(200, 40);
            this.btnUpdateMember.TabIndex = 12;
            this.btnUpdateMember.Text = "UPDATE MEMBER";
            this.btnUpdateMember.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUpdateMember.UseAccentColor = false;
            this.btnUpdateMember.UseVisualStyleBackColor = true;
            this.btnUpdateMember.Click += new System.EventHandler(this.btnUpdateMember_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(12, 158);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(46, 16);
            this.lblPhone.TabIndex = 11;
            this.lblPhone.Text = "Phone";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(259, 158);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 16);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "E-mail";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(259, 57);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(72, 16);
            this.lblSurname.TabIndex = 9;
            this.lblSurname.Text = "Last Name";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 57);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(72, 16);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "First Name";
            // 
            // txtEmail
            // 
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(262, 190);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 50);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.Text = "";
            this.txtEmail.TrailingIcon = null;
            // 
            // txtSurname
            // 
            this.txtSurname.AnimateReadOnly = false;
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSurname.Depth = 0;
            this.txtSurname.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSurname.LeadingIcon = null;
            this.txtSurname.Location = new System.Drawing.Point(262, 89);
            this.txtSurname.MaxLength = 50;
            this.txtSurname.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSurname.Multiline = false;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(200, 50);
            this.txtSurname.TabIndex = 6;
            this.txtSurname.Text = "";
            this.txtSurname.TrailingIcon = null;
            // 
            // txtPhone
            // 
            this.txtPhone.AnimateReadOnly = false;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Depth = 0;
            this.txtPhone.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPhone.LeadingIcon = null;
            this.txtPhone.Location = new System.Drawing.Point(15, 190);
            this.txtPhone.MaxLength = 50;
            this.txtPhone.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPhone.Multiline = false;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 50);
            this.txtPhone.TabIndex = 5;
            this.txtPhone.Text = "";
            this.txtPhone.TrailingIcon = null;
            // 
            // btnAddMember
            // 
            this.btnAddMember.AutoSize = false;
            this.btnAddMember.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddMember.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddMember.Depth = 0;
            this.btnAddMember.HighEmphasis = true;
            this.btnAddMember.Icon = null;
            this.btnAddMember.Location = new System.Drawing.Point(512, 10);
            this.btnAddMember.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddMember.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddMember.Size = new System.Drawing.Size(200, 40);
            this.btnAddMember.TabIndex = 4;
            this.btnAddMember.Text = "ADD MEMBER";
            this.btnAddMember.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddMember.UseAccentColor = false;
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // txtName
            // 
            this.txtName.AnimateReadOnly = false;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Depth = 0;
            this.txtName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.LeadingIcon = null;
            this.txtName.Location = new System.Drawing.Point(15, 89);
            this.txtName.MaxLength = 50;
            this.txtName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 50);
            this.txtName.TabIndex = 3;
            this.txtName.Text = "";
            this.txtName.TrailingIcon = null;
            // 
            // lblMemberManagement
            // 
            this.lblMemberManagement.AutoSize = true;
            this.lblMemberManagement.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMemberManagement.Location = new System.Drawing.Point(9, 8);
            this.lblMemberManagement.Name = "lblMemberManagement";
            this.lblMemberManagement.Size = new System.Drawing.Size(360, 34);
            this.lblMemberManagement.TabIndex = 2;
            this.lblMemberManagement.Text = "Member Management";
            // 
            // dgvMemberList
            // 
            this.dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberList.Location = new System.Drawing.Point(3, 262);
            this.dgvMemberList.Name = "dgvMemberList";
            this.dgvMemberList.RowHeadersWidth = 51;
            this.dgvMemberList.RowTemplate.Height = 24;
            this.dgvMemberList.Size = new System.Drawing.Size(796, 150);
            this.dgvMemberList.TabIndex = 0;
            // 
            // tabBooks
            // 
            this.tabBooks.Controls.Add(this.lblYear);
            this.tabBooks.Controls.Add(this.lblStock);
            this.tabBooks.Controls.Add(this.lblAuthor);
            this.tabBooks.Controls.Add(this.lblBookName);
            this.tabBooks.Controls.Add(this.btnSearchBook);
            this.tabBooks.Controls.Add(this.btnUpdateBook);
            this.tabBooks.Controls.Add(this.btnDeleteBook);
            this.tabBooks.Controls.Add(this.btnAddBook);
            this.tabBooks.Controls.Add(this.txtStock);
            this.tabBooks.Controls.Add(this.txtAuthor);
            this.tabBooks.Controls.Add(this.txtYear);
            this.tabBooks.Controls.Add(this.txtBookName);
            this.tabBooks.Controls.Add(this.lblBookManagement);
            this.tabBooks.Controls.Add(this.dgvBookList);
            this.tabBooks.ImageKey = "icons8-book-48.png";
            this.tabBooks.Location = new System.Drawing.Point(4, 25);
            this.tabBooks.Name = "tabBooks";
            this.tabBooks.Size = new System.Drawing.Size(872, 399);
            this.tabBooks.TabIndex = 2;
            this.tabBooks.Text = "Books";
            this.tabBooks.UseVisualStyleBackColor = true;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(11, 158);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(36, 16);
            this.lblYear.TabIndex = 15;
            this.lblYear.Text = "Year";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(259, 158);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(41, 16);
            this.lblStock.TabIndex = 14;
            this.lblStock.Text = "Stock";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(259, 57);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(45, 16);
            this.lblAuthor.TabIndex = 13;
            this.lblAuthor.Text = "Author";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(12, 57);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(79, 16);
            this.lblBookName.TabIndex = 12;
            this.lblBookName.Text = "Book Name";
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.AutoSize = false;
            this.btnSearchBook.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearchBook.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSearchBook.Depth = 0;
            this.btnSearchBook.HighEmphasis = true;
            this.btnSearchBook.Icon = null;
            this.btnSearchBook.Location = new System.Drawing.Point(512, 202);
            this.btnSearchBook.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearchBook.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSearchBook.Size = new System.Drawing.Size(200, 40);
            this.btnSearchBook.TabIndex = 11;
            this.btnSearchBook.Text = "SEARCH BOOK";
            this.btnSearchBook.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSearchBook.UseAccentColor = false;
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.AutoSize = false;
            this.btnUpdateBook.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdateBook.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUpdateBook.Depth = 0;
            this.btnUpdateBook.HighEmphasis = true;
            this.btnUpdateBook.Icon = null;
            this.btnUpdateBook.Location = new System.Drawing.Point(512, 138);
            this.btnUpdateBook.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdateBook.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUpdateBook.Size = new System.Drawing.Size(200, 40);
            this.btnUpdateBook.TabIndex = 10;
            this.btnUpdateBook.Text = "UPDATE BOOK";
            this.btnUpdateBook.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUpdateBook.UseAccentColor = false;
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.AutoSize = false;
            this.btnDeleteBook.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteBook.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteBook.Depth = 0;
            this.btnDeleteBook.HighEmphasis = true;
            this.btnDeleteBook.Icon = null;
            this.btnDeleteBook.Location = new System.Drawing.Point(512, 74);
            this.btnDeleteBook.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteBook.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteBook.Size = new System.Drawing.Size(200, 40);
            this.btnDeleteBook.TabIndex = 9;
            this.btnDeleteBook.Text = "DELETE BOOK";
            this.btnDeleteBook.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteBook.UseAccentColor = false;
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.AutoSize = false;
            this.btnAddBook.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddBook.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddBook.Depth = 0;
            this.btnAddBook.HighEmphasis = true;
            this.btnAddBook.Icon = null;
            this.btnAddBook.Location = new System.Drawing.Point(512, 10);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddBook.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddBook.Size = new System.Drawing.Size(200, 40);
            this.btnAddBook.TabIndex = 8;
            this.btnAddBook.Text = "ADD BOOK";
            this.btnAddBook.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddBook.UseAccentColor = false;
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // txtStock
            // 
            this.txtStock.AnimateReadOnly = false;
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStock.Depth = 0;
            this.txtStock.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtStock.LeadingIcon = null;
            this.txtStock.Location = new System.Drawing.Point(262, 190);
            this.txtStock.MaxLength = 50;
            this.txtStock.MouseState = MaterialSkin.MouseState.OUT;
            this.txtStock.Multiline = false;
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(200, 50);
            this.txtStock.TabIndex = 7;
            this.txtStock.Text = "";
            this.txtStock.TrailingIcon = null;
            // 
            // txtAuthor
            // 
            this.txtAuthor.AnimateReadOnly = false;
            this.txtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAuthor.Depth = 0;
            this.txtAuthor.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAuthor.LeadingIcon = null;
            this.txtAuthor.Location = new System.Drawing.Point(262, 89);
            this.txtAuthor.MaxLength = 50;
            this.txtAuthor.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAuthor.Multiline = false;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(200, 50);
            this.txtAuthor.TabIndex = 6;
            this.txtAuthor.Text = "";
            this.txtAuthor.TrailingIcon = null;
            // 
            // txtYear
            // 
            this.txtYear.AnimateReadOnly = false;
            this.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYear.Depth = 0;
            this.txtYear.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtYear.LeadingIcon = null;
            this.txtYear.Location = new System.Drawing.Point(15, 190);
            this.txtYear.MaxLength = 50;
            this.txtYear.MouseState = MaterialSkin.MouseState.OUT;
            this.txtYear.Multiline = false;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(200, 50);
            this.txtYear.TabIndex = 5;
            this.txtYear.Text = "";
            this.txtYear.TrailingIcon = null;
            // 
            // txtBookName
            // 
            this.txtBookName.AnimateReadOnly = false;
            this.txtBookName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBookName.Depth = 0;
            this.txtBookName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBookName.LeadingIcon = null;
            this.txtBookName.Location = new System.Drawing.Point(15, 89);
            this.txtBookName.MaxLength = 50;
            this.txtBookName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBookName.Multiline = false;
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(200, 50);
            this.txtBookName.TabIndex = 4;
            this.txtBookName.Text = "";
            this.txtBookName.TrailingIcon = null;
            // 
            // lblBookManagement
            // 
            this.lblBookManagement.AutoSize = true;
            this.lblBookManagement.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookManagement.Location = new System.Drawing.Point(8, 8);
            this.lblBookManagement.Name = "lblBookManagement";
            this.lblBookManagement.Size = new System.Drawing.Size(309, 34);
            this.lblBookManagement.TabIndex = 3;
            this.lblBookManagement.Text = "Book Management";
            // 
            // dgvBookList
            // 
            this.dgvBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookList.Location = new System.Drawing.Point(3, 262);
            this.dgvBookList.Name = "dgvBookList";
            this.dgvBookList.RowHeadersWidth = 51;
            this.dgvBookList.RowTemplate.Height = 24;
            this.dgvBookList.Size = new System.Drawing.Size(796, 150);
            this.dgvBookList.TabIndex = 1;
            // 
            // tabLoans
            // 
            this.tabLoans.Controls.Add(this.btnSearchLoan);
            this.tabLoans.Controls.Add(this.btnUpdateLoan);
            this.tabLoans.Controls.Add(this.btnDeleteLoan);
            this.tabLoans.Controls.Add(this.btnAddLoan);
            this.tabLoans.Controls.Add(this.lblLoanDate);
            this.tabLoans.Controls.Add(this.lblBookID);
            this.tabLoans.Controls.Add(this.lblReturnDate);
            this.tabLoans.Controls.Add(this.lblMemberID);
            this.tabLoans.Controls.Add(this.txtLoanDate);
            this.tabLoans.Controls.Add(this.txtBookID);
            this.tabLoans.Controls.Add(this.txtReturnDate);
            this.tabLoans.Controls.Add(this.txtMemberID);
            this.tabLoans.Controls.Add(this.dgvLoanList);
            this.tabLoans.Controls.Add(this.lblLoanManagement);
            this.tabLoans.ImageKey = "icons8-calendar-48.png";
            this.tabLoans.Location = new System.Drawing.Point(4, 25);
            this.tabLoans.Name = "tabLoans";
            this.tabLoans.Size = new System.Drawing.Size(872, 399);
            this.tabLoans.TabIndex = 3;
            this.tabLoans.Text = "Loans";
            this.tabLoans.UseVisualStyleBackColor = true;
            // 
            // txtLoanDate
            // 
            this.txtLoanDate.AnimateReadOnly = false;
            this.txtLoanDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoanDate.Depth = 0;
            this.txtLoanDate.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLoanDate.LeadingIcon = null;
            this.txtLoanDate.Location = new System.Drawing.Point(15, 190);
            this.txtLoanDate.MaxLength = 50;
            this.txtLoanDate.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLoanDate.Multiline = false;
            this.txtLoanDate.Name = "txtLoanDate";
            this.txtLoanDate.Size = new System.Drawing.Size(200, 50);
            this.txtLoanDate.TabIndex = 9;
            this.txtLoanDate.Text = "";
            this.txtLoanDate.TrailingIcon = null;
            // 
            // txtBookID
            // 
            this.txtBookID.AnimateReadOnly = false;
            this.txtBookID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBookID.Depth = 0;
            this.txtBookID.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBookID.LeadingIcon = null;
            this.txtBookID.Location = new System.Drawing.Point(262, 89);
            this.txtBookID.MaxLength = 50;
            this.txtBookID.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBookID.Multiline = false;
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(200, 50);
            this.txtBookID.TabIndex = 8;
            this.txtBookID.Text = "";
            this.txtBookID.TrailingIcon = null;
            // 
            // txtReturnDate
            // 
            this.txtReturnDate.AnimateReadOnly = false;
            this.txtReturnDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReturnDate.Depth = 0;
            this.txtReturnDate.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtReturnDate.LeadingIcon = null;
            this.txtReturnDate.Location = new System.Drawing.Point(262, 190);
            this.txtReturnDate.MaxLength = 50;
            this.txtReturnDate.MouseState = MaterialSkin.MouseState.OUT;
            this.txtReturnDate.Multiline = false;
            this.txtReturnDate.Name = "txtReturnDate";
            this.txtReturnDate.Size = new System.Drawing.Size(200, 50);
            this.txtReturnDate.TabIndex = 7;
            this.txtReturnDate.Text = "";
            this.txtReturnDate.TrailingIcon = null;
            // 
            // txtMemberID
            // 
            this.txtMemberID.AnimateReadOnly = false;
            this.txtMemberID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMemberID.Depth = 0;
            this.txtMemberID.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMemberID.LeadingIcon = null;
            this.txtMemberID.Location = new System.Drawing.Point(15, 89);
            this.txtMemberID.MaxLength = 50;
            this.txtMemberID.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMemberID.Multiline = false;
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(200, 50);
            this.txtMemberID.TabIndex = 6;
            this.txtMemberID.Text = "";
            this.txtMemberID.TrailingIcon = null;
            // 
            // dgvLoanList
            // 
            this.dgvLoanList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoanList.Location = new System.Drawing.Point(3, 262);
            this.dgvLoanList.Name = "dgvLoanList";
            this.dgvLoanList.RowHeadersWidth = 51;
            this.dgvLoanList.RowTemplate.Height = 24;
            this.dgvLoanList.Size = new System.Drawing.Size(796, 150);
            this.dgvLoanList.TabIndex = 5;
            // 
            // lblLoanManagement
            // 
            this.lblLoanManagement.AutoSize = true;
            this.lblLoanManagement.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLoanManagement.Location = new System.Drawing.Point(8, 8);
            this.lblLoanManagement.Name = "lblLoanManagement";
            this.lblLoanManagement.Size = new System.Drawing.Size(307, 34);
            this.lblLoanManagement.TabIndex = 4;
            this.lblLoanManagement.Text = "Loan Management";
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.lblLang);
            this.tabSettings.Controls.Add(this.btnLang);
            this.tabSettings.ImageKey = "icons8-settings-48.png";
            this.tabSettings.Location = new System.Drawing.Point(4, 25);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(872, 399);
            this.tabSettings.TabIndex = 4;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // lblLang
            // 
            this.lblLang.AutoSize = true;
            this.lblLang.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLang.Location = new System.Drawing.Point(8, 8);
            this.lblLang.Name = "lblLang";
            this.lblLang.Size = new System.Drawing.Size(370, 34);
            this.lblLang.TabIndex = 3;
            this.lblLang.Text = "Language Preferences";
            // 
            // btnLang
            // 
            this.btnLang.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLang.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLang.Depth = 0;
            this.btnLang.HighEmphasis = true;
            this.btnLang.Icon = null;
            this.btnLang.Location = new System.Drawing.Point(8, 56);
            this.btnLang.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLang.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLang.Name = "btnLang";
            this.btnLang.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLang.Size = new System.Drawing.Size(76, 36);
            this.btnLang.TabIndex = 0;
            this.btnLang.Text = "Türkçe";
            this.btnLang.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLang.UseAccentColor = false;
            this.btnLang.UseVisualStyleBackColor = true;
            this.btnLang.Click += new System.EventHandler(this.btnLang_Click);
            // 
            // Library_imList
            // 
            this.Library_imList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Library_imList.ImageStream")));
            this.Library_imList.TransparentColor = System.Drawing.Color.Transparent;
            this.Library_imList.Images.SetKeyName(0, "icons8-book-48.png");
            this.Library_imList.Images.SetKeyName(1, "icons8-calendar-48.png");
            this.Library_imList.Images.SetKeyName(2, "icons8-home-48.png");
            this.Library_imList.Images.SetKeyName(3, "icons8-people-48.png");
            this.Library_imList.Images.SetKeyName(4, "icons8-search-48.png");
            this.Library_imList.Images.SetKeyName(5, "icons8-settings-48.png");
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Location = new System.Drawing.Point(12, 57);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(73, 16);
            this.lblMemberID.TabIndex = 10;
            this.lblMemberID.Text = "Member ID";
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Location = new System.Drawing.Point(259, 158);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(78, 16);
            this.lblReturnDate.TabIndex = 11;
            this.lblReturnDate.Text = "Return Date";
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Location = new System.Drawing.Point(259, 57);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(55, 16);
            this.lblBookID.TabIndex = 12;
            this.lblBookID.Text = "Book ID";
            // 
            // lblLoanDate
            // 
            this.lblLoanDate.AutoSize = true;
            this.lblLoanDate.Location = new System.Drawing.Point(12, 158);
            this.lblLoanDate.Name = "lblLoanDate";
            this.lblLoanDate.Size = new System.Drawing.Size(69, 16);
            this.lblLoanDate.TabIndex = 13;
            this.lblLoanDate.Text = "Loan Date";
            // 
            // btnAddLoan
            // 
            this.btnAddLoan.AutoSize = false;
            this.btnAddLoan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddLoan.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddLoan.Depth = 0;
            this.btnAddLoan.HighEmphasis = true;
            this.btnAddLoan.Icon = null;
            this.btnAddLoan.Location = new System.Drawing.Point(512, 10);
            this.btnAddLoan.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddLoan.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddLoan.Name = "btnAddLoan";
            this.btnAddLoan.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddLoan.Size = new System.Drawing.Size(200, 40);
            this.btnAddLoan.TabIndex = 14;
            this.btnAddLoan.Text = "ADD LOAN";
            this.btnAddLoan.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddLoan.UseAccentColor = false;
            this.btnAddLoan.UseVisualStyleBackColor = true;
            this.btnAddLoan.Click += new System.EventHandler(this.btnAddLoan_Click);
            // 
            // btnDeleteLoan
            // 
            this.btnDeleteLoan.AutoSize = false;
            this.btnDeleteLoan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteLoan.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteLoan.Depth = 0;
            this.btnDeleteLoan.HighEmphasis = true;
            this.btnDeleteLoan.Icon = null;
            this.btnDeleteLoan.Location = new System.Drawing.Point(512, 74);
            this.btnDeleteLoan.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteLoan.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteLoan.Name = "btnDeleteLoan";
            this.btnDeleteLoan.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteLoan.Size = new System.Drawing.Size(200, 40);
            this.btnDeleteLoan.TabIndex = 15;
            this.btnDeleteLoan.Text = "DELETE LOAN";
            this.btnDeleteLoan.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteLoan.UseAccentColor = false;
            this.btnDeleteLoan.UseVisualStyleBackColor = true;
            this.btnDeleteLoan.Click += new System.EventHandler(this.btnDeleteLoan_Click);
            // 
            // btnUpdateLoan
            // 
            this.btnUpdateLoan.AutoSize = false;
            this.btnUpdateLoan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdateLoan.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUpdateLoan.Depth = 0;
            this.btnUpdateLoan.HighEmphasis = true;
            this.btnUpdateLoan.Icon = null;
            this.btnUpdateLoan.Location = new System.Drawing.Point(512, 138);
            this.btnUpdateLoan.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdateLoan.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdateLoan.Name = "btnUpdateLoan";
            this.btnUpdateLoan.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUpdateLoan.Size = new System.Drawing.Size(200, 40);
            this.btnUpdateLoan.TabIndex = 16;
            this.btnUpdateLoan.Text = "UPDATE LOAN";
            this.btnUpdateLoan.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUpdateLoan.UseAccentColor = false;
            this.btnUpdateLoan.UseVisualStyleBackColor = true;
            this.btnUpdateLoan.Click += new System.EventHandler(this.btnUpdateLoan_Click);
            // 
            // btnSearchLoan
            // 
            this.btnSearchLoan.AutoSize = false;
            this.btnSearchLoan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearchLoan.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSearchLoan.Depth = 0;
            this.btnSearchLoan.HighEmphasis = true;
            this.btnSearchLoan.Icon = null;
            this.btnSearchLoan.Location = new System.Drawing.Point(512, 202);
            this.btnSearchLoan.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearchLoan.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearchLoan.Name = "btnSearchLoan";
            this.btnSearchLoan.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSearchLoan.Size = new System.Drawing.Size(200, 40);
            this.btnSearchLoan.TabIndex = 17;
            this.btnSearchLoan.Text = "SEARCH LOAN";
            this.btnSearchLoan.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSearchLoan.UseAccentColor = false;
            this.btnSearchLoan.UseVisualStyleBackColor = true;
            this.btnSearchLoan.Click += new System.EventHandler(this.btnSearchLoan_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(20, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(277, 16);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to the Library Management System!";
            // 
            // formLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 495);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "formLibrary";
            this.Text = "Library Management";
            this.Load += new System.EventHandler(this.formLibrary_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            this.tabMembers.ResumeLayout(false);
            this.tabMembers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).EndInit();
            this.tabBooks.ResumeLayout(false);
            this.tabBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).EndInit();
            this.tabLoans.ResumeLayout(false);
            this.tabLoans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanList)).EndInit();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.ImageList Library_imList;
        private System.Windows.Forms.TabPage tabMembers;
        private System.Windows.Forms.TabPage tabBooks;
        private System.Windows.Forms.TabPage tabLoans;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.DataGridView dgvMemberList;
        private System.Windows.Forms.Label lblMemberManagement;
        private System.Windows.Forms.DataGridView dgvBookList;
        private MaterialSkin.Controls.MaterialButton btnLang;
        private System.Windows.Forms.Label lblBookManagement;
        private System.Windows.Forms.DataGridView dgvLoanList;
        private System.Windows.Forms.Label lblLoanManagement;
        private MaterialSkin.Controls.MaterialButton btnAddMember;
        private MaterialSkin.Controls.MaterialTextBox txtName;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialTextBox txtSurname;
        private MaterialSkin.Controls.MaterialTextBox txtPhone;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLang;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblPhone;
        private MaterialSkin.Controls.MaterialButton btnSearchMember;
        private MaterialSkin.Controls.MaterialButton btnDeleteMember;
        private MaterialSkin.Controls.MaterialButton btnUpdateMember;
        private MaterialSkin.Controls.MaterialTextBox txtYear;
        private MaterialSkin.Controls.MaterialTextBox txtBookName;
        private MaterialSkin.Controls.MaterialTextBox txtAuthor;
        private MaterialSkin.Controls.MaterialTextBox txtStock;
        private MaterialSkin.Controls.MaterialButton btnAddBook;
        private MaterialSkin.Controls.MaterialButton btnSearchBook;
        private MaterialSkin.Controls.MaterialButton btnUpdateBook;
        private MaterialSkin.Controls.MaterialButton btnDeleteBook;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblAuthor;
        private MaterialSkin.Controls.MaterialTextBox txtLoanDate;
        private MaterialSkin.Controls.MaterialTextBox txtBookID;
        private MaterialSkin.Controls.MaterialTextBox txtReturnDate;
        private MaterialSkin.Controls.MaterialTextBox txtMemberID;
        private MaterialSkin.Controls.MaterialButton btnAddLoan;
        private System.Windows.Forms.Label lblLoanDate;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lblMemberID;
        private MaterialSkin.Controls.MaterialButton btnSearchLoan;
        private MaterialSkin.Controls.MaterialButton btnUpdateLoan;
        private MaterialSkin.Controls.MaterialButton btnDeleteLoan;
        private System.Windows.Forms.Label lblWelcome;
    }
}

