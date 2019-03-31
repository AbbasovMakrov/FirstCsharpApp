using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DataBaseLearnnig
{
    public partial class Form1 : Form
    {
        
         DataBaseClass dataBase = new DataBaseClass(@"INFINITY\SQLEXPRSS",true,"learn");
        CurrencyManager currencyManagerFeild;
        SqlCommandBuilder builder;
        public Form1()
        {
            InitializeComponent();
            try
            {
                dataBase.connectionProperty.Open();
                dataBase.adapter_Property = new SqlDataAdapter("SELECT * FROM students", dataBase.connectionProperty);
                dataBase.adapter_Property.Fill(dataBase.dataTable_Property);
                nameTxTBox.DataBindings.Add("Text",dataBase.dataTable_Property,"name");
                gradeTxTBox.DataBindings.Add("Text", dataBase.dataTable_Property, "grade");
                currencyManagerFeild = (CurrencyManager)BindingContext[dataBase.dataTable_Property];
                this.elNumber.Text = (currencyManagerFeild.Position + 1) + "/" + dataBase.dataTable_Property.Rows.Count;
                currencyManagerFeild.Position = 0;
                currencyManagerFeild.Refresh();
                //nameTxTBox.Text = dataBase.x;
               // textBox1.Text = dataBase.x;
            }
            catch (SqlException ex)
            {
                DialogResult dialog = MessageBox.Show(ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dataBase.connectionProperty.Close();
            }
            nameLabel.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void FirstButt_Click(object sender, EventArgs e)
        {
             currencyManagerFeild.Position = 0;
            this.elNumber.Text = (currencyManagerFeild.Position + 1)+"/"+dataBase.dataTable_Property.Rows.Count;
        }

        private void LastButt_Click(object sender, EventArgs e)
        {
            currencyManagerFeild.Position = dataBase.dataTable_Property.Rows.Count - 1;
            this.elNumber.Text = (currencyManagerFeild.Position + 1) + "/" + dataBase.dataTable_Property.Rows.Count;

        }

        private void nextButt_Click(object sender, EventArgs e)
        {
            currencyManagerFeild.Position += 1;
            this.elNumber.Text = (currencyManagerFeild.Position + 1) + "/" + dataBase.dataTable_Property.Rows.Count;

        }

        private void prevButt_Click(object sender, EventArgs e)
        {
            currencyManagerFeild.Position -= 1;
            this.elNumber.Text = (currencyManagerFeild.Position + 1) + "/" + dataBase.dataTable_Property.Rows.Count;

        }

        private void newButt_Click(object sender, EventArgs e)
        {
            currencyManagerFeild.AddNew();
            this.nameTxTBox.Focus();
        }

        private void addButt_Click(object sender, EventArgs e)
        {

            try
            {


                currencyManagerFeild.EndCurrentEdit();
                if (dataBase.dataTable_Property != null)
                {
                    builder = new SqlCommandBuilder(dataBase.adapter_Property);
                    dataBase.adapter_Property.Update(dataBase.dataTable_Property);
                    currencyManagerFeild.Refresh();
                    //currencyManagerFeild.AddNew();
                    currencyManagerFeild.Position = dataBase.dataTable_Property.Rows.Count - 1;
                    this.elNumber.Text = (currencyManagerFeild.Position + 1) + "/" + dataBase.dataTable_Property.Rows.Count;

                    MessageBox.Show("Added New Row", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (SqlException ex)
            {

                //throw;
                MessageBox.Show(ex.Message,"Error" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void delButt_Click(object sender, EventArgs e)
        {
            
            try
            {
               currencyManagerFeild.EndCurrentEdit();
                currencyManagerFeild.RemoveAt(currencyManagerFeild.Position);

                if (dataBase.dataTable_Property != null)
                {
                    currencyManagerFeild.Position = dataBase.dataTable_Property.Rows.Count - 1;

                    builder = new SqlCommandBuilder(dataBase.adapter_Property);
                    dataBase.adapter_Property.Update(dataBase.dataTable_Property);
                    currencyManagerFeild.Refresh();
                    // currencyManagerFeild.AddNew();
                    nameTxTBox.Focus();
                    this.elNumber.Text = (currencyManagerFeild.Position + 1) + "/" + dataBase.dataTable_Property.Rows.Count;

                    MessageBox.Show("One Row Deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editButt_Click(object sender, EventArgs e)
        {
            
            try
            {
                currencyManagerFeild.EndCurrentEdit();

                if (dataBase.dataTable_Property.Rows.Count > 0)
                {
                    
                    builder = new SqlCommandBuilder(dataBase.adapter_Property);
                    dataBase.adapter_Property.Update(dataBase.dataTable_Property);
                    currencyManagerFeild.Position = dataBase.dataTable_Property.Rows.Count - 1;
                    currencyManagerFeild.Refresh();
                    this.elNumber.Text = (currencyManagerFeild.Position + 1) + "/" + dataBase.dataTable_Property.Rows.Count;

                    //currencyManagerFeild.AddNew();
                    MessageBox.Show("Edited", "edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    
    }
}
