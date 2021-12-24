using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace BookLibrary
{
    public partial class Form1 : Form
    {
      //*************** Connection String **************************************************
        string str = ConfigurationManager.ConnectionStrings["library"].ConnectionString;
        //**************************************************************************************
        CultureInfo ci = CultureInfo.CurrentCulture;
        int AlloGrid = 0;
        string ret = "";
        int count;
        SqlCommand com;
        public Form1()
        {
            InitializeComponent();
        }  
        private void tabPage1_Click(object sender, EventArgs e)
        {
            try
            {
                count = 0;
                UpdateUser.Enabled = false;
                DeleteUser.Enabled = false;
                CancelUser.Enabled = false;
                UserId.Enabled = false;

                SqlDataAdapter da = new SqlDataAdapter("Select * from UserDetails", str);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewBook.DataSource = (ds.Tables[0]);
            }
            catch(Exception)
            {
                MessageBox.Show("Try Again");
            }

        }
 //**********************************************************************************************
 //**********************Book Coding Starts******************************************************
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void AddBooks()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand com = new SqlCommand("Insert into BookDetails values('" + textBoxBookName.Text + "','" + AuthorName.Text + "','" + (BookDesc.Text) + "')", con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Book Inserted");
                    SqlDataAdapter da = new SqlDataAdapter("Select * from BookDetails", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridViewBook.DataSource = (ds.Tables[0]);
                    
                    BookId.Text = "";
                    textBoxBookName.Text = "";
                    AuthorName.Text = "";
                    BookDesc.Text = "";
                }
            }
            catch(Exception)
            {
                MessageBox.Show("All Fields Are Mandetory");
            }

        }
        bool BookNameValidation()
        {
                string text = textBoxBookName.Text;
                Match m = Regex.Match(text, @"^[a-zA-Z0-9]*$", RegexOptions.IgnoreCase);
                if (textBoxBookName.Text.Trim()==string.Empty || (!m.Success))
                {
                MessageBox.Show("Please Fill All Fields");
                return false;
                }
            return true;
        }
        bool AuthorNameValidation()
        {
            string text = textBoxBookName.Text;
            Match m = Regex.Match(text, @"^[a-zA-Z]*$", RegexOptions.IgnoreCase);
            if (AuthorName.Text.Trim() == string.Empty || (!m.Success))
            {
                return false;
            }         
                return true;            
        }
        bool BookDescriptionValidation()
        {

            string text = textBoxBookName.Text;
            Match m = Regex.Match(text, @"^[a-zA-Z.,-]*$", RegexOptions.IgnoreCase);
            if (BookDesc.Text.Trim() == string.Empty || (!m.Success))
            {
                return false;
            }
            return true;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                { 
                con.Open();
                SqlCommand com = new SqlCommand("delete from BookDetails where BookID='" + BookId.Text + "' ", con);
                com.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Successfully");

                SqlDataAdapter da = new SqlDataAdapter("Select * from BookDetails", con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewBook.DataSource = (ds.Tables[0]);
                BookId.Text = "";
                textBoxBookName.Text = "";
                AuthorName.Text = "";
                BookDesc.Text = "";                
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Book Cannot be Deleted");

            }

        }
        private void button8_Click(object sender, EventArgs e)
        {
            try
            { 
            using (SqlConnection con = new SqlConnection(str))
            { 
            con.Open();
            SqlCommand com = new SqlCommand("Update BookDetails set BookName='" + textBoxBookName.Text + "',AuthorName='" + AuthorName.Text + "',BookDescription='" + BookDesc.Text + "' Where BookID='" + BookId.Text + "'", con);
            com.ExecuteNonQuery();
            MessageBox.Show("Data Updated");           
            SqlDataAdapter da = new SqlDataAdapter("Select * from BookDetails", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewBook.DataSource = (ds.Tables[0]);
            BookId.Text = "";
            textBoxBookName.Text = "";
            AuthorName.Text = "";
            BookDesc.Text = "";
            }
            }
            catch(Exception)
            {
                MessageBox.Show("Not Updated");
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            BookId.Text = "";
            textBoxBookName.Text = "";
            AuthorName.Text = "";
            BookDesc.Text = "";
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (BookNameValidation() && AuthorNameValidation() && BookDescriptionValidation())
                {
                    AddBooks();
                }
                else
                {
                    MessageBox.Show("Data Not Inserted");
                }    
        
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridViewBook.CurrentRow;
            BookId.Text = row.Cells[0].Value.ToString();
            textBoxBookName.Text = row.Cells[1].Value.ToString();
            AuthorName.Text = row.Cells[2].Value.ToString();
            BookDesc.Text = row.Cells[3].Value.ToString();
            UpdateBook.Enabled = true;
            DeleteBook.Enabled = true;
            CancelBook.Enabled = true;
            AddBook.Enabled = false;
            ResetBook.Enabled = false;
        }        
 //******Book coding Ends********************************
//***************************************************************************************************


//************************************************************************************************
//************************* User Code Starts from Here *******************************************
//************************************************************************************************
        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                { 
                con.Open();
                SqlCommand com = new SqlCommand("delete from UserDetails where UserId='" + UserId.Text + "' ", con);
                com.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Successfully");

                SqlDataAdapter da = new SqlDataAdapter("Select * from UserDetails", str);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewUser.DataSource = (ds.Tables[0]);
                UserId.Text = "";
                textBoxUserName.Text = "";
                UserMail.Text = "";
                UserContact.Text = "";
                UserAddress.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("User cannot be deleted");
            }

        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridViewUser.CurrentRow;
            UserId.Text = row.Cells[0].Value.ToString();
            textBoxUserName.Text = row.Cells[1].Value.ToString();
            UserMail.Text = row.Cells[2].Value.ToString();
            UserContact.Text = row.Cells[3].Value.ToString();
            UserAddress.Text = row.Cells[4].Value.ToString();
            UpdateUser.Enabled = true;
            DeleteUser.Enabled = true;
            CancelUser.Enabled = true;
            AddUsers.Enabled = false;
            ResetUser.Enabled = false;
        }
        bool NameValidation()
        {
            string text = textBoxUserName.Text;
            Match m = Regex.Match(text, @"^[a-z A-Z]*$", RegexOptions.IgnoreCase);
            if (textBoxUserName.Text.Trim() == string.Empty || (!m.Success))
            {
                return false;
            }
            return true;
        }
        //Add data in User Details Table.
        void AddUser()
        {
            try
            {
                if (count > 0)
            {
                MessageBox.Show("All Fields Are Mandetory. Enter All Fields");
            }
            else
            {               
                    using (SqlConnection con = new SqlConnection(str))
                    { 
                    con.Open();
                    SqlCommand com = new SqlCommand("Insert into UserDetails values('" + textBoxUserName.Text + "','" + UserMail.Text + "','" + Convert.ToInt64(UserContact.Text) + "','" + UserAddress.Text + "')", con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Inserted Successfully");
                    SqlDataAdapter da = new SqlDataAdapter("Select * from UserDetails", str);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridViewUser.DataSource = (ds.Tables[0]);
                    UserId.Text = "";
                    textBoxUserName.Text = "";
                    UserMail.Text = "";
                    UserContact.Text = "";
                    UserAddress.Text = "";
                    }
                }
            }
            catch (Exception)
                {
                    MessageBox.Show("Enter All Fields");
                }
            
        }
        //Address Validation Code. Only alphanumeric and(,.) allowed.
        bool addressValidation()
        {           
                string text = UserAddress.Text;
                Match m = Regex.Match(text, @"^[a-zA-Z0-9,-]*$", RegexOptions.IgnoreCase);
                if (UserAddress.Text.Trim() == string.Empty || (!m.Success))
                {
                    return false;
                }
                return true;
        }             
        public int ValidateEmailId(string emailId)
        {
            //Regular Expressions for email id
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (emailId.Length > 0)
            {
                if (!rEMail.IsMatch(emailId))
                {
                    return 0;
                }
                else
                {
                    return 1;
                    count++;
                }
            }
            return 2;
        }
        //Email Validation Code.  
        void EmailValidation()
        {
            int status = ValidateEmailId(UserMail.Text);
            if (status == 0)
            {
                MessageBox.Show("E-Mail Id expected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserMail.Focus();
                count++;
            }
            else if (status == 1)
            {
                UserMail.Focus();                
            }
            else if (status == 2)
            {
                UserMail.Focus();
                count++;

            }
        }
        private void UserContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
            {
                e.Handled = true;
            }
            else
            {
                if (char.IsDigit(e.KeyChar) && UserContact.Text.Length > 9)
                {                  
                   MessageBox.Show("Enter valid Contact");
                   e.Handled = true;                    
                }
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            count = 0;

            NameValidation();
            EmailValidation();
            addressValidation();
            AddUser();

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            UserId.Text = "";
            textBoxUserName.Text = "";
            UserMail.Text = "";
            UserContact.Text = "";
            UserAddress.Text = "";
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand com = new SqlCommand("Update UserDetails set UserName='" + textBoxUserName.Text + "',EmailID='" + UserMail.Text + "',contact='" + Convert.ToInt64(UserContact.Text) + "',Address='" + UserAddress.Text + "' Where UserId='" + UserId.Text + "'", con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Data Updated");
                    SqlDataAdapter da = new SqlDataAdapter("Select * from UserDetails", str);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridViewUser.DataSource = (ds.Tables[0]);
                    UserId.Text = "";
                    textBoxUserName.Text = "";
                    UserMail.Text = "";
                    UserContact.Text = "";
                    UserAddress.Text = "";
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Not Updated");
            }
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridViewUser.CurrentRow;
            UserId.Text = row.Cells[0].Value.ToString();
            textBoxUserName.Text = row.Cells[1].Value.ToString();
            UserMail.Text = row.Cells[2].Value.ToString();
            UserContact.Text = row.Cells[3].Value.ToString();
            UserAddress.Text = row.Cells[4].Value.ToString();
            UpdateUser.Enabled = true;
            DeleteUser.Enabled = true;
            CancelUser.Enabled = true;
            AddUsers.Enabled = false;
            ResetUser.Enabled = false;
        }
//************************************************************************************************
//*********************** All Loads Code Start from here *****************************************
//************************************************************************************************
        void UserLoad()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    count = 0;
                    UpdateUser.Enabled = false;
                    DeleteUser.Enabled = false;
                    CancelUser.Enabled = false;
                    UserId.Enabled = false;
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from UserDetails", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridViewUser.DataSource = (ds.Tables[0]);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Try Again");
            }          
        }
        void BookLoad()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    BookId.Enabled = false;
                    UpdateBook.Enabled = false;
                    DeleteBook.Enabled = false;
                    CancelBook.Enabled = false;
                    SqlConnection con1 = new SqlConnection(str);
                    con.Open();
                    SqlDataAdapter DA = new SqlDataAdapter("Select * from BookDetails", con1);
                    DataSet DS = new DataSet();
                    DA.Fill(DS);
                    dataGridViewBook.DataSource = (DS.Tables[0]);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Try Again");
            }
    
        }
        void AllocateLoad()
        {
            try
            {
                var t = DateTime.Now;
                string format = t.ToString("yyyy-MM-dd, hh:mm:ss");
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlDataAdapter da1 = new SqlDataAdapter("Select * from BookAllocation", con);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);
                    dataGridViewAllocation.DataSource = (ds1.Tables[0]);
                    AllocationId.Enabled = false;
                    AllocationIssuedDate.Text = format;
                    AllocationReturnDate.Text = format;
                    AllUserName();
                    AllBookName();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Try Again");
            }
    
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UserLoad();
            BookLoad();
            AllocateLoad();
                  
        }
 //***********************************************************************************************
 //*********************** Load Code Ends ********************************************************
 //***********************************************************************************************
       

//************************************************************************************************
//******************************** Allocation Code Starts ****************************************
        private void dataGridViewBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridViewBook.CurrentRow;
            BookId.Text = row.Cells[0].Value.ToString();
            textBoxBookName.Text = row.Cells[1].Value.ToString();
            AuthorName.Text = row.Cells[2].Value.ToString();
            BookDesc.Text = row.Cells[3].Value.ToString();
            UpdateBook.Enabled = true;
            DeleteBook.Enabled = true;
            CancelBook.Enabled = true;
            AddBook.Enabled = false;
            ResetBook.Enabled = false;

        }
        void AllUserName()
        {
            using (SqlConnection con = new SqlConnection(str))
            { 
            con.Open();
            SqlCommand com = new SqlCommand("Select * from UserDetails", con);
            SqlDataReader sd = com.ExecuteReader();
            while (sd.Read())
            {
                AllocationUserName.Items.Add(sd[1].ToString());
            }
            sd.Close();
            }
        }
        void AllBookName()
        {
            using (SqlConnection con = new SqlConnection(str))
            { 
                con.Open();
            SqlCommand com = new SqlCommand("Select * from BookDetails", con);
            SqlDataReader sd = com.ExecuteReader();
            while (sd.Read())
            {
                comboBoxBookName.Items.Add(sd[1].ToString());
            }
            sd.Close();
            }

        }
        private void AllocationUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(str))
            { 
            con.Open();         
            SqlDataAdapter da = new SqlDataAdapter("select UserId from UserDetails where UserName='" + AllocationUserName.Text + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                AllocationUserName.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
            }
        }
        private void comboBoxBookName_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(str))
            { 
            con.Open();     
            SqlDataAdapter da=new SqlDataAdapter("select BookID from BookDetails where BookName='" + comboBoxBookName.Text + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            for(int i=0;i<ds.Tables[0].Rows.Count;i++)
            {
                comboBoxBookName.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
            }
        }
        private void buttonIssue_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(str))
            {     
            con.Open();
            com = new SqlCommand("Insert into BookAllocation values('" + Convert.ToInt32(AllocationUserId.Text) + "','" + Convert.ToInt32(AllocationBookId.Text) + "','" + AllocationUserName.Text + "','" + comboBoxBookName.Text + "','" + Convert.ToDateTime(AllocationIssuedDate.Text, ci) + "','" + ret + "')", con);
            com.ExecuteNonQuery();
            MessageBox.Show("Inserted Successfully");
            SqlDataAdapter da = new SqlDataAdapter("Select * from BookAllocation", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewAllocation.DataSource = (ds.Tables[0]);
            }
        }
        private void ButtonReturn_Click(object sender, EventArgs e)
        {
            if (AlloGrid == 1)
            {

                AllocationReturnDate.Text = DateTime.UtcNow.ToString();
                using (SqlConnection con = new SqlConnection(str))
                { 
                con.Open();
                com = new SqlCommand("update BookAllocation set ReturnDate='" + Convert.ToDateTime(AllocationReturnDate.Text, ci) + "'  where AllocationID='" + Convert.ToInt32(AllocationId.Text) + "'  ", con);
                com.ExecuteNonQuery();
                MessageBox.Show("Book Return");
                SqlDataAdapter da = new SqlDataAdapter("Select * from BookAllocation", con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewAllocation.DataSource = (ds.Tables[0]);
                }
                AlloGrid = 0;
            }
            else
            {
                MessageBox.Show("Book is Allready returned");
            }
        }
        private void dataGridViewAllocation_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridViewAllocation.RowCount > 0)
            {
                var row = dataGridViewAllocation.CurrentRow;
                AllocationId.Text = row.Cells[0].Value.ToString();
                AllocationUserId.Text = row.Cells[1].Value.ToString();
                AllocationBookId.Text = row.Cells[2].Value.ToString();
                AllocationUserName.Text = row.Cells[3].Value.ToString();
                comboBoxBookName.Text = row.Cells[4].Value.ToString();
                AllocationIssuedDate.Text = row.Cells[5].Value.ToString();
                AllocationReturnDate.Text = row.Cells[6].Value.ToString();
                if (Convert.ToDateTime(AllocationReturnDate.Text) <= DateTime.Now.Date)
                {
                    AlloGrid++;
                }
            }
        }

        private void AllocationUserName_SelectedValueChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(str))
            { 
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select UserId from UserDetails where UserName='" + AllocationUserName.Text + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            for(int i=0;i<ds.Tables[0].Rows.Count;i++)
            {
                AllocationUserId.Text = ds.Tables[0].Rows[i][0].ToString();
            }
            }
        }

        private void comboBoxBookName_SelectedValueChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select BookID from BookDetails where BookName='" + comboBoxBookName.Text + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                AllocationBookId.Text = ds.Tables[0].Rows[i][0].ToString();
            }
            con.Close();
        }

   
        //*************************************************************************************************
        //************************ Allocation Code Ends****************************************************
    }
}
