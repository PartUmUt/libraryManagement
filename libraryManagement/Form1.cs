using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Drawing;
using System.Linq;

namespace libraryManagement
{
    public partial class formLibrary : MaterialForm
    {
        #region /// -- designs -- ///
        public formLibrary()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme
            (
                Color.FromArgb(133, 72, 232),
                Color.FromArgb(70, 56, 146),
                Color.FromArgb(166, 89, 255),
                Color.FromArgb(243, 121, 255),
                TextShade.WHITE
            );
            /*materialSkinManager.ColorScheme = new ColorScheme
            (
                Primary.BlueGrey800,
                Primary.BlueGrey900,
                Primary.BlueGrey500,
                Accent.LightBlue200,
                TextShade.WHITE
             );*/
        }

        void labelSet()
        {
            lblMemberManagement.Font = new System.Drawing.Font
                (
                    "Verdana", 16, System.Drawing.FontStyle.Bold
                );
            lblBookManagement.Font = new System.Drawing.Font
                (
                    "Verdana", 16, System.Drawing.FontStyle.Bold
                );
            lblLoanManagement.Font = new System.Drawing.Font
                (
                    "Verdana", 16, System.Drawing.FontStyle.Bold
                );
            lblLang.Font = new System.Drawing.Font
                (
                    "Verdana", 16, System.Drawing.FontStyle.Bold
                );
            lblWelcome.Font = new System.Drawing.Font
                (
                    "Verdana", 16, System.Drawing.FontStyle.Bold
                );
        }
        #endregion

        #region /// -- language -- ///
        bool isEnglish = true;

        void setLanguage()
        {
            if (isEnglish)
            {
                // Labels
                lblWelcome.Text = "Welcome to Library Management System";
                lblMemberManagement.Text = "Member Management";
                lblBookManagement.Text = "Book Management";
                lblLoanManagement.Text = "Loan Management";
                lblLang.Text = "Language Preferences";

                lblName.Text = "First Name";
                lblSurname.Text = "Last Name";
                lblPhone.Text = "Phone";
                lblEmail.Text = "E-mail";

                lblBookName.Text = "Book Name";
                lblAuthor.Text = "Author";
                lblYear.Text = "Year";
                lblStock.Text = "Stock";

                lblMemberID.Text = "Member ID";
                lblBookID.Text = "Book ID";
                lblLoanDate.Text = "Loan Date";
                lblReturnDate.Text = "Return Date";

                // Buttons
                btnAddMember.Text = "ADD MEMBER";
                btnDeleteMember.Text = "DELETE MEMBER";
                btnUpdateMember.Text = "UPDATE MEMBER";
                btnSearchMember.Text = "SEARCH MEMBER";

                btnAddBook.Text = "ADD BOOK";
                btnDeleteBook.Text = "DELETE BOOK";
                btnUpdateBook.Text = "UPDATE BOOK";
                btnSearchBook.Text = "SEARCH BOOK";

                btnAddLoan.Text = "ADD LOAN";
                btnDeleteLoan.Text = "DELETE LOAN";
                btnUpdateLoan.Text = "UPDATE LOAN";
                btnSearchLoan.Text = "SEARCH LOAN";

                // Form
                this.Text = "Library Management System";

                // Tabs
                tabHome.Text = "Home";
                tabMembers.Text = "Members";
                tabBooks.Text = "Books";
                tabLoans.Text = "Loans";
                tabSettings.Text = "Settings";

                /// DataGridViews
                // Members
                dgvMemberList.Columns["memberID"].HeaderText = "Member ID";
                dgvMemberList.Columns["mName"].HeaderText = "First Name";
                dgvMemberList.Columns["mSurname"].HeaderText = "Last Name";
                dgvMemberList.Columns["mPhone"].HeaderText = "Phone";
                dgvMemberList.Columns["mEmail"].HeaderText = "Email";
                // Books
                dgvBookList.Columns["bookID"].HeaderText = "Book ID";
                dgvBookList.Columns["bName"].HeaderText = "Book Name";
                dgvBookList.Columns["bAuthor"].HeaderText = "Author";
                dgvBookList.Columns["bYear"].HeaderText = "Year";
                dgvBookList.Columns["Stock"].HeaderText = "Stock";
                // Loans
                dgvLoanList.Columns["loanID"].HeaderText = "Loan ID";
                dgvLoanList.Columns["memberID"].HeaderText = "Member ID";
                dgvLoanList.Columns["bookID"].HeaderText = "Book ID";
                dgvLoanList.Columns["LoanDate"].HeaderText = "Loan Date";
                dgvLoanList.Columns["returnDate"].HeaderText = "Return Date";
            }
            else
            {
                // Labels
                lblWelcome.Text = "Kütüphane Yönetim Sistemine Hoşgeldiniz";
                lblMemberManagement.Text = "Üye Yönetimi";
                lblBookManagement.Text = "Kitap Yönetimi";
                lblLoanManagement.Text = "Ödünç Yönetimi";
                lblLang.Text = "Dil Tercihleri";

                lblName.Text = "Ad";
                lblSurname.Text = "Soyad";
                lblPhone.Text = "Telefon";
                lblEmail.Text = "E-posta";

                lblBookName.Text = "Kitap Adı";
                lblAuthor.Text = "Yazar";
                lblYear.Text = "Yıl";
                lblStock.Text = "Stok";

                lblMemberID.Text = "Üye No";
                lblBookID.Text = "Kitap No";
                lblLoanDate.Text = "Ödünç Tarihi";
                lblReturnDate.Text = "İade Tarihi";

                // Buttons
                btnAddMember.Text = "ÜYE EKLE";
                btnDeleteMember.Text = "ÜYE SİL";
                btnUpdateMember.Text = "ÜYE GÜNCELLE";
                btnSearchMember.Text = "ÜYE ARA";

                btnAddBook.Text = "KİTAP EKLE";
                btnDeleteBook.Text = "KİTAP SİL";
                btnUpdateBook.Text = "KİTAP GÜNCELLE";
                btnSearchBook.Text = "KİTAP ARA";

                btnAddLoan.Text = "ÖDÜNÇ EKLE";
                btnDeleteLoan.Text = "ÖDÜNÇ SİL";
                btnUpdateLoan.Text = "ÖDÜNÇ GÜNCELLE";
                btnSearchLoan.Text = "ÖDÜNÇ ARA";

                // Form
                this.Text = "Kütüphane Yönetim Sistemi";

                // Tabs
                tabHome.Text = "Ana Sayfa";
                tabMembers.Text = "Üyeler";
                tabBooks.Text = "Kitaplar";
                tabLoans.Text = "Ödünç İşlemleri";
                tabSettings.Text = "Ayarlar";

                /// DataGridViews
                // Members
                dgvMemberList.Columns["memberID"].HeaderText = "Üye No";
                dgvMemberList.Columns["mName"].HeaderText = "Ad";
                dgvMemberList.Columns["mSurname"].HeaderText = "Soyad";
                dgvMemberList.Columns["mPhone"].HeaderText = "Telefon";
                dgvMemberList.Columns["mEmail"].HeaderText = "E-posta";
                // Books
                dgvBookList.Columns["bookID"].HeaderText = "Kitap No";
                dgvBookList.Columns["bName"].HeaderText = "Kitap Adı";
                dgvBookList.Columns["bAuthor"].HeaderText = "Yazar";
                dgvBookList.Columns["bYear"].HeaderText = "Yıl";
                dgvBookList.Columns["Stock"].HeaderText = "Stok";
                // Loans
                dgvLoanList.Columns["loanID"].HeaderText = "Ödünç No";
                dgvLoanList.Columns["memberID"].HeaderText = "Üye No";
                dgvLoanList.Columns["bookID"].HeaderText = "Kitap No";
                dgvLoanList.Columns["loanDate"].HeaderText = "Ödünç Tarihi";
                dgvLoanList.Columns["returnDate"].HeaderText = "İade Tarihi";
            }
        }
        private void btnLang_Click(object sender, EventArgs e)
        {
            isEnglish = !isEnglish;

            btnLang.Text = isEnglish ? "Türkçe" : "ENGLISH";

            setLanguage();
        }
        #endregion

        #region /// -- load -- ///
        void listMembers()
        {
            LibraryDBEntities DB = new LibraryDBEntities();
            dgvMemberList.DataSource = DB.lbMembers.ToList();

            dgvMemberList.Columns["lbLoan"].Visible = false;
        }

        void listBooks()
        {
            LibraryDBEntities DB = new LibraryDBEntities();
            dgvBookList.DataSource = DB.lbBooks.ToList();

            dgvBookList.Columns["lbLoan"].Visible = false;
        }

        void listLoans()
        {
            LibraryDBEntities DB = new LibraryDBEntities();
            dgvLoanList.DataSource = DB.lbLoan.ToList();

            dgvLoanList.Columns["lbMembers"].Visible = false;
            dgvLoanList.Columns["lbBooks"].Visible = false;
        }

        void clearMembertxt()
        {
            txtName.Text = "";
            txtSurname.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
        }

        void clearBooktxt()
        {
            txtBookName.Text = "";
            txtAuthor.Text = "";
            txtYear.Text = "";
            txtStock.Text = "";
        }

        private void formLibrary_Load(object sender, EventArgs e)
        {

            listMembers();
            listBooks();
            listLoans();
            setLanguage();
            labelSet();
        }
        #endregion

        #region /// -- Member Management -- ///
        // Add Member
        private void btnAddMember_Click(object sender, EventArgs e)
        {
            LibraryDBEntities DB = new LibraryDBEntities();
            lbMembers member = new lbMembers();

            member.mName = txtName.Text;
            member.mSurname = txtSurname.Text;
            member.mPhone = txtPhone.Text;
            member.mEmail = txtEmail.Text;

            DB.lbMembers.Add(member);
            DB.SaveChanges();

            clearMembertxt();
            listMembers();
        }

        // Delete Member
        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            LibraryDBEntities DB = new LibraryDBEntities();
            int id = Convert.ToInt32(dgvMemberList.CurrentRow.Cells["memberID"].Value);

            lbMembers member = DB.lbMembers.Find(id);

            DB.lbMembers.Remove(member);
            DB.SaveChanges();

            clearMembertxt();
            listMembers();
        }

        // Update Member
        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            LibraryDBEntities DB = new LibraryDBEntities();

            int id = Convert.ToInt32(dgvMemberList.CurrentRow.Cells["memberID"].Value);

            lbMembers member = DB.lbMembers.Find(id);

            member.mName = txtName.Text;
            member.mSurname = txtSurname.Text;
            member.mPhone = txtPhone.Text;
            member.mEmail = txtEmail.Text;

            DB.SaveChanges();

            clearMembertxt();
            listMembers();
        }

        // Search Member
        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            LibraryDBEntities DB = new LibraryDBEntities();

            string isName = txtName.Text;
            string isSurname = txtSurname.Text;
            string isPhone = txtPhone.Text;
            string isEmail = txtEmail.Text;

            dgvMemberList.DataSource = DB.lbMembers
                .Where(m =>
                    (isName == "" || m.mName.Contains(isName)) &&
                    (isSurname == "" || m.mSurname.Contains(isSurname)) &&
                    (isPhone == "" || m.mPhone.Contains(isPhone)) &&
                    (isEmail == "" || m.mEmail.Contains(isEmail))
                )
                .ToList();
        }
        #endregion

        #region /// -- Book Management -- ///
        // Add Book
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            LibraryDBEntities DB = new LibraryDBEntities();
            lbBooks book = new lbBooks();

            book.bName = txtBookName.Text;
            book.bAuthor = txtAuthor.Text;
            book.bYear = Convert.ToInt32(txtYear.Text);
            book.Stock = Convert.ToInt32(txtStock.Text);

            DB.lbBooks.Add(book);
            DB.SaveChanges();

            clearBooktxt();
            listBooks();
        }

        // Delete Book
        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            LibraryDBEntities DB = new LibraryDBEntities();
            int id = Convert.ToInt32(dgvBookList.CurrentRow.Cells["bookID"].Value);

            lbBooks book = DB.lbBooks.Find(id);

            DB.lbBooks.Remove(book);
            DB.SaveChanges();

            clearBooktxt();
            listBooks();
        }

        // Update Book
        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            LibraryDBEntities DB = new LibraryDBEntities();

            int id = Convert.ToInt32(dgvBookList.CurrentRow.Cells["bookID"].Value);

            lbBooks book = DB.lbBooks.Find(id);

            book.bName = txtBookName.Text;
            book.bAuthor = txtAuthor.Text;
            book.bYear = Convert.ToInt32(txtYear.Text);
            book.Stock = Convert.ToInt32(txtStock.Text);

            DB.SaveChanges();

            clearBooktxt();
            listBooks();
        }

        // Search Book
        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            LibraryDBEntities DB = new LibraryDBEntities();

            string isBookName = txtBookName.Text;
            string isAuthor = txtAuthor.Text;
            string isYear = txtYear.Text;
            string isStock = txtStock.Text;

            dgvBookList.DataSource = DB.lbBooks
                .Where(m =>
                    (isBookName == "" || m.bName.Contains(isBookName)) &&
                    (isAuthor == "" || m.bAuthor.Contains(isAuthor)) &&
                    (isYear == "" || m.bYear.ToString().Contains(isYear)) &&
                    (isStock == "" || m.Stock.ToString().Contains(isStock))
                )
                .ToList();
        }
        #endregion

        #region /// -- Loan Management -- ///

        // Add Loan
        private void btnAddLoan_Click(object sender, EventArgs e)
        {
            LibraryDBEntities DB = new LibraryDBEntities();
            lbLoan loan = new lbLoan();

            loan.memberID = Convert.ToInt32(txtMemberID.Text);
            loan.bookID = Convert.ToInt32(txtBookID.Text);
            loan.loanDate = Convert.ToDateTime(txtLoanDate.Text);
            loan.returnDate = null;

            DB.lbLoan.Add(loan);
            DB.SaveChanges();

            listLoans();
        }

        // Delete Loan
        private void btnDeleteLoan_Click(object sender, EventArgs e)
        {
            LibraryDBEntities DB = new LibraryDBEntities();

            int id = Convert.ToInt32(dgvLoanList.CurrentRow.Cells["loanID"].Value);
            lbLoan loan = DB.lbLoan.Find(id);

            DB.lbLoan.Remove(loan);
            DB.SaveChanges();

            listLoans();
        }

        // Update Loan
        private void btnUpdateLoan_Click(object sender, EventArgs e)
        {
            LibraryDBEntities DB = new LibraryDBEntities();

            int id = Convert.ToInt32(dgvLoanList.CurrentRow.Cells["loanID"].Value);
            lbLoan loan = DB.lbLoan.Find(id);

            loan.returnDate = Convert.ToDateTime(txtReturnDate.Text);

            DB.SaveChanges();
            listLoans();
        }

        // Search Loan
        private void btnSearchLoan_Click(object sender, EventArgs e)
        {
            LibraryDBEntities DB = new LibraryDBEntities();

            int memberID = Convert.ToInt32(txtMemberID.Text);
            int bookID = Convert.ToInt32(txtBookID.Text);

            dgvLoanList.DataSource = DB.lbLoan
                .Where(l => l.memberID == memberID || l.bookID == bookID)
                .ToList();
        }
        #endregion
    }
}