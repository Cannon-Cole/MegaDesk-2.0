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
    public partial class SearchDisplay : Form
    {
        public SearchDisplay()
        {
            InitializeComponent();
            SearchColumnDisplay.Columns.Add("Name", 125, HorizontalAlignment.Center);
            SearchColumnDisplay.Columns.Add("Date", 90, HorizontalAlignment.Center);
            SearchColumnDisplay.Columns.Add("Height", 50, HorizontalAlignment.Center);
            SearchColumnDisplay.Columns.Add("Width", 40, HorizontalAlignment.Center);
            SearchColumnDisplay.Columns.Add("Materials", 90, HorizontalAlignment.Center);
            SearchColumnDisplay.Columns.Add("Rush Days", 70, HorizontalAlignment.Center);
            SearchColumnDisplay.Columns.Add("Drawers", 70, HorizontalAlignment.Center);
            SearchColumnDisplay.Columns.Add("Total", 70, HorizontalAlignment.Center);
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {

            List<string> materialList = new List<string>();

            materialList.Add("Select");

            foreach (var name in Enum.GetNames(typeof(Materials)))
            {
                materialList.Add(name);
            }

            SearchMaterialCombo.DataSource = materialList;         
        }

        private void ViewQuotesBackBtn_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchColumnDisplay.Items.Clear();
            StreamReader re = new StreamReader(@"quotes.txt");
            
            try
            {
                while (!re.EndOfStream)
                {
                    string quote = re.ReadLine();
                    string[] quoteProperties = quote.Split(',');

                    if (quoteProperties[4] == SearchMaterialCombo.Text)
                    {

                        SearchColumnDisplay.Items.Add(new ListViewItem(new[] { quoteProperties[0], quoteProperties[1], quoteProperties[2] + "\"", quoteProperties[3] + "\"", quoteProperties[4], quoteProperties[5], quoteProperties[6], "$" + quoteProperties[7] }));
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("File read issue: " + ex.Message);
            }
            finally
            {
                re.Close();
            }
        }
    }
}
