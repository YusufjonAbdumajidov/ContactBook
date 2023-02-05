using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_book
{
    public partial class ContactBook : Form
    {
        DataTable contacts = new DataTable();
        bool editing = false;
        public ContactBook()
        {
            InitializeComponent();
        }

        private void ContactBook_Load(object sender, EventArgs e)
        {
            contacts.Columns.Add("Name");
            contacts.Columns.Add("Surname");
            contacts.Columns.Add("Tel number");
            contacts.Columns.Add("Email");
            contacts.Columns.Add("Date of birth");

            //Set data source
            contactsData.DataSource = contacts;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            nameText.Text = "";
            surnameText.Text = "";
            telText.Text = "";
            emailText.Text = "";
            dateText.Text = "";
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            nameText.Text = contacts.Rows[contactsData.CurrentCell.RowIndex].ItemArray[0].ToString();
            surnameText.Text = contacts.Rows[contactsData.CurrentCell.RowIndex].ItemArray[1].ToString();
            telText.Text = contacts.Rows[contactsData.CurrentCell.RowIndex].ItemArray[2].ToString();
            emailText.Text = contacts.Rows[contactsData.CurrentCell.RowIndex].ItemArray[3].ToString();
            dateText.Text = contacts.Rows[contactsData.CurrentCell.RowIndex].ItemArray[4].ToString();
            editing = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                contacts.Rows[contactsData.CurrentCell.RowIndex]["Name"] = nameText.Text;
                contacts.Rows[contactsData.CurrentCell.RowIndex]["Surname"] = surnameText.Text;
                contacts.Rows[contactsData.CurrentCell.RowIndex]["Tel number"] = telText.Text;
                contacts.Rows[contactsData.CurrentCell.RowIndex]["Email"] = emailText.Text;
                contacts.Rows[contactsData.CurrentCell.RowIndex]["Date of birth"] = dateText.Text;
            }
            else
            {
                contacts.Rows.Add(nameText.Text, surnameText.Text, telText.Text, emailText.Text, dateText.Text);
            }
            nameText.Text = "";
            surnameText.Text = "";
            telText.Text = "";
            emailText.Text = "";
            dateText.Text = "";
            editing = false;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                contacts.Rows[contactsData.CurrentCell.RowIndex].Delete();
            }
            catch(Exception ex) { Console.WriteLine("Not a valid row"); }
        }

        private void contactsData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            nameText.Text = contacts.Rows[contactsData.CurrentCell.RowIndex].ItemArray[0].ToString();
            surnameText.Text = contacts.Rows[contactsData.CurrentCell.RowIndex].ItemArray[1].ToString();
            telText.Text = contacts.Rows[contactsData.CurrentCell.RowIndex].ItemArray[2].ToString();
            emailText.Text = contacts.Rows[contactsData.CurrentCell.RowIndex].ItemArray[3].ToString();
            dateText.Text = contacts.Rows[contactsData.CurrentCell.RowIndex].ItemArray[4].ToString();
            editing = true;
        }
    }
}
