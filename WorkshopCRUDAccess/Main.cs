using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;
namespace WorkshopCRUDAccess
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //using(OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings.))
            //   {
            //       con.Open();
            //       MessageBox.Show(con.State.ToString());
            //   }
            Console.WriteLine("Connection String : "+ConfigurationManager.ConnectionStrings[1]);
        }
    }
}
