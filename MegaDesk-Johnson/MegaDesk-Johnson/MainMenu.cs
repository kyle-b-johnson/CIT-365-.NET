using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Johnson
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            ViewAllQuotes quote = new ViewAllQuotes();
            quote.Show();
            this.Hide();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchQuotes search = new SearchQuotes();
            search.Show();
            this.Hide();
        }

        private void AddQuote_Click(object sender, EventArgs e)
        {
            AddQuote add = new AddQuote();
            add.Show();
            this.Hide();
        }
    }
}
