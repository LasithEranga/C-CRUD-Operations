using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Operations
{
    public partial class CRUD : Form
    {
        public CRUD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql.Write("INSERT INTO details VALUES("+idInput.Text+",'"+nameInput.Text+ "'," + ageInput.Text+");");
        }
    }
}
