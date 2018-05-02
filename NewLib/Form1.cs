using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewLib
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var collection = GetAuthorsEF();
            foreach (var item in collection)
            {
                listBox1.Items.Add(item.FirstName + " " + item.LastName);
            }
        }

        private List<Author> GetAuthorsEF()
        {
            var context = new LibraryEntities();
            var customers = context.Authors.ToList();
            return customers;
        }
    }
}