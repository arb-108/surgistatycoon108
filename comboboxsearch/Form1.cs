using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comboboxsearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getstatescombo();
        }
        private void getstatescombo()
        {
            database db = new database();

            DataTable dt = new DataTable();
            dt = db.getstates();
            //DataRow dr2 = dt.NewRow();
            //dr2[0] = -1;
            //dr2[1] = "--Select State--";
            //dt.Rows.InsertAt(dr2, 0);

            statecomboBox.ValueMember = "id";
            statecomboBox.DisplayMember = "name";
            statecomboBox.DataSource = dt;
            //agar search wala karna e te dropdown hata do

            statecomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isvalid())
            {
                MessageBox.Show("good job ", "congrat", MessageBoxButtons.OK);
            }
        }

        private bool isvalid()
        {
            bool value = true;
            if (inttextbox.Text == string.Empty)
            {
                MessageBox.Show("Please enter int-box value", "missing", MessageBoxButtons.OK);
                inttextbox.Focus();
                return false;
            }
            else
            {
                int num;
                bool isNumeric = int.TryParse(inttextbox.Text.Trim(), out num);
                if (!isNumeric)
                {
                    MessageBox.Show("Please enter integer value", "missing", MessageBoxButtons.OK);
                    inttextbox.Focus();
                    return false;
                }
            }
            if (decimaltextBox.Text == string.Empty)
            {
                MessageBox.Show("Please enter decimal-box value", "missing", MessageBoxButtons.OK);
                decimaltextBox.Focus();
                return false;
            }
            else
            {
                decimal num;
                bool isNumeric = decimal.TryParse(decimaltextBox.Text.Trim(), out num);
                if (!isNumeric)
                {
                    MessageBox.Show("Please enter decimal value", "missing", MessageBoxButtons.OK);
                    decimaltextBox.Focus();
                    return false;
                }
            }
            return value;
        }
    }
}
