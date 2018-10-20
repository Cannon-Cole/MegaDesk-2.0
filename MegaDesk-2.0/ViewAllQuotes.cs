using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_4_ColeCannon
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
            ViewAllDisplay.Columns.Add("Name", 125, HorizontalAlignment.Center);
            ViewAllDisplay.Columns.Add("Date", 90, HorizontalAlignment.Center);
            ViewAllDisplay.Columns.Add("Height", 50, HorizontalAlignment.Center);
            ViewAllDisplay.Columns.Add("Width", 40, HorizontalAlignment.Center);
            ViewAllDisplay.Columns.Add("Materials", 90, HorizontalAlignment.Center);
            ViewAllDisplay.Columns.Add("Rush Days", 70, HorizontalAlignment.Center);
            ViewAllDisplay.Columns.Add("Drawers", 70, HorizontalAlignment.Center);
            ViewAllDisplay.Columns.Add("Total", 70, HorizontalAlignment.Center);
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            StreamReader re = new StreamReader(@"../../assets/quotes.json");
            ViewAllDisplay.Items.Clear();

            try
            {
                while (!re.EndOfStream)
                {
                    string quote = re.ReadLine();
                    string[] quoteProperties = quote.Split(',');

                    ViewAllDisplay.Items.Add(new ListViewItem(new[] { quoteProperties[0], quoteProperties[1], quoteProperties[2] + "\"", quoteProperties[3] + "\"", quoteProperties[4], quoteProperties[5], quoteProperties[6], "$" + quoteProperties[7] }));

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("File read issue: " + ex.Message);
            }
            finally
            {
                re.Close();
            }
        }

        private void ViewQuotesBtn_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }
    }
}