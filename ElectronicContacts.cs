using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using customerContacts.onlineContactClasses;

namespace customerContacts
{
    public partial class ElectronicContacts : Form
    {
        public ElectronicContacts()
        {
            InitializeComponent();
            // Resize is an event that triggers when main window is resized!
            this.Resize += new EventHandler(ElectronicContacts_Resize);
        }

        private const string insertSuccessString = "New Contact Successfully Inserted!";
        private const string insertFailedString = "New Contact Failed To Insert!";
        private const string updateSuccessString = "Contact Successfully Updated!";
        private const string updateFailedString = "Contact Failed To Update!";
        private const string deleteSuccessString = "Contact Successfully Deleted!";
        private const string deleteFailedString = "Contact Failed To Delete!";
        ContactsClass contacts = new ContactsClass();


        private void AddButton_Click(object sender, EventArgs e)
        {
            contacts.FirstName = firstNameTB.Text;
            contacts.LastName = LastNameTB.Text;
            contacts.Email = EmailTB.Text;
            contacts.Address = AddressTB.Text;
            contacts.Gender = GenderCB.Text;
            contacts.Number = PhoneNumberTB.Text;

            bool success = contacts.Insert(contacts);
            if (success)
            {
                MessageBox.Show(insertSuccessString);
                ClearFields();
            }
            else
                MessageBox.Show(insertFailedString);
            DataTable dt = contacts.SelectAll();
            dbGridView.DataSource = dt;
        }

        private void ElectronicContacts_Load(object sender, EventArgs e)
        {
            // what runs when the application is loaded
            DataTable dt = contacts.SelectAll();
            dbGridView.DataSource = dt;
        }

        public void ClearFields()
        {
            ContactID_TB.Text = "";
            firstNameTB.Text = "";
            LastNameTB.Text = "";
            EmailTB.Text = "";
            AddressTB.Text = "";
            PhoneNumberTB.Text = "";
            GenderCB.Text = "";
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            contacts.ContactID = int.Parse(ContactID_TB.Text);
            contacts.FirstName = firstNameTB.Text;
            contacts.LastName = LastNameTB.Text;
            contacts.Email = EmailTB.Text;
            contacts.Address = AddressTB.Text;
            contacts.Gender = GenderCB.Text;
            contacts.Number = PhoneNumberTB.Text;

            bool success = contacts.Update(contacts);
            if (success)
            {
                MessageBox.Show(updateSuccessString);
                DataTable dt = contacts.SelectAll();
                dbGridView.DataSource = dt;
                ClearFields();
            }
            else
                MessageBox.Show(updateFailedString);

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dbGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            ContactID_TB.Text = dbGridView.Rows[rowIndex].Cells[0].Value.ToString();
            firstNameTB.Text = dbGridView.Rows[rowIndex].Cells[1].Value.ToString();
            LastNameTB.Text = dbGridView.Rows[rowIndex].Cells[2].Value.ToString();
            EmailTB.Text = dbGridView.Rows[rowIndex].Cells[3].Value.ToString();
            PhoneNumberTB.Text = dbGridView.Rows[rowIndex].Cells[4].Value.ToString();
            AddressTB.Text = dbGridView.Rows[rowIndex].Cells[5].Value.ToString();
            GenderCB.Text = dbGridView.Rows[rowIndex].Cells[6].Value.ToString();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ContactID_TB.Text.Length == 0)
            {
                MessageBox.Show("Cannot delete entry without inserting ContactID");
                return;
            }

            contacts.ContactID = Convert.ToInt32(ContactID_TB.Text);
            bool success = contacts.Delete(contacts);
            if (success)
            {
                MessageBox.Show(deleteSuccessString);
                DataTable dt = contacts.SelectAll();
                dbGridView.DataSource = dt;
                ClearFields();
            }
            else
            {
                MessageBox.Show(deleteFailedString);
            }

        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string connString = ContactsClass.GetConnString();
            string searchText = SearchTextBox.Text;
            SqlConnection conn = new SqlConnection(connString);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_contacts WHERE " +
                                                    "firstName LIKE '%" + searchText + "%' OR " +
                                                    "lastName LIKE '%" + searchText + "%' OR " +
                                                    "contactID LIKE '%" + searchText + "%' OR " +
                                                    "email LIKE '%" + searchText + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dbGridView.DataSource = dt;
        }
        private void ElectronicContacts_Resize(object sender, EventArgs e)
        {
            // Calculate the new width for the text boxes
            int formWidth = this.ClientSize.Width;

            int margin = 20; // Margin from the right side of the form
            // Console.WriteLine(formWidth);  use f11 to see debugs
            dbGridView.Width = formWidth - dbGridView.Left - margin;
            Console.WriteLine(dbGridView.Width);
            SearchTextBox.Width = formWidth - SearchTextBox.Left - margin;
        }
    }
}
