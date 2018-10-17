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
    public partial class AddQuote : Form
    {
        public List<string> materialList = new List<string>();

        public AddQuote()
        {
            InitializeComponent();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

            materialList.Insert(0, "Select");
          
            foreach (var name in Enum.GetNames(typeof(Materials)))
            {
                materialList.Add(name);
                MaterialCombo.Items.Add(name);
            }

            //MaterialCombo.DataSource = materialList;
        }

        private void AddNewQuoteAccept_Click(object sender, EventArgs e)
        {
            bool validated = validateFields();

            if(validated)
            {
            StreamWriter wr = new StreamWriter(@"quotes.txt", append: true);
            try
            {
                string rushtime = "None";

                if (RushCombo.Text != "None")
                { 
                    rushtime = RushCombo.Text.Split(null)[0];
                }

                wr.WriteLine(CustomerNameBox.Text + "," + DateTime.Now.ToString("dd/MM/yyyy") + "," + HeightInput.Text + "," + WidthInput.Text + "," + MaterialCombo.Text + "," + rushtime + "," + DrawerCombo.Text + "," + DeskQuote.getPrice(int.Parse(HeightInput.Text), int.Parse(WidthInput.Text), MaterialCombo.Text, RushCombo.Text, int.Parse(DrawerCombo.Text)));

                QuoteAdded.Visible = true;
              
                NotificationTimer.Enabled = true;
                NotificationTimer.Tick += NotificationTimer_Tick;

            }
            catch (Exception ex)
            {
                Console.WriteLine("File write issue: " + ex.Message);
            }
            finally
            {
                wr.Close();
            }
            }
        }

        private bool validateFields()
        {
            bool name = checkName();
            bool drawers = checkDrawers();
            bool height = checkHeight();
            bool width = checkWidth();
            bool material = checkMaterial();
            bool rush = checkRush();

            if (name && drawers && height && width && material && rush)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void NotificationTimer_Tick(object sender, EventArgs e)
        {
            QuoteAdded.Visible = false;
        }

        

        private void CancelQuote_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private bool checkName()
        {
            if (CustomerNameBox.Text.Length  < 1)
            {
                CustomerNameErrorLabel.Text = "Must enter a name";
                return false;
            }
            else
            {
                CustomerNameErrorLabel.Text = "";
                return true;
            }
        }

        private bool checkHeight()
        {
            string errorMessage = "Must be between " + Desk.MIN_HEIGHT + " and " + Desk.MAX_HEIGHT;
            int heightConvert;
            int height = 0;

            try
            {
                heightConvert = System.Convert.ToInt32(HeightInput.Text);
                height = heightConvert;              
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                HeightInputErrorLabel.Text = "Enter an integer";
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
                HeightInputErrorLabel.Text = errorMessage;
            }
            finally
            {
                HeightInputErrorLabel.Text = errorMessage;
                
            }

            if (height > Desk.MAX_HEIGHT)
            {
                HeightInputErrorLabel.Text = errorMessage;
                return false;
            }
            else if (height < Desk.MIN_HEIGHT)
            {
                HeightInputErrorLabel.Text = errorMessage;
                return false;
            }
            else
            {
                HeightInputErrorLabel.Text = "";
                return true;
            }
        }

        private bool checkWidth()
        {
            string errorMessage = "Must be between " + Desk.MIN_WIDTH + " and " + Desk.MAX_WIDTH;
            int widthConvert;
            int width = 0;

            try
            {
                widthConvert = System.Convert.ToInt32(WidthInput.Text);
                width = widthConvert;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                WidthInputErrorLabel.Text = errorMessage;
            }

            if (width > Desk.MAX_WIDTH)
            {
                WidthInputErrorLabel.Text = errorMessage;
                return false;
            }
            else if (width < Desk.MIN_WIDTH)
            {
                WidthInputErrorLabel.Text = errorMessage;
                return false;
            }
            else
            {
                WidthInputErrorLabel.Text = "";
                return true;
            }
        }

        private bool checkDrawers()
        {
            if(DrawerCombo.Text == "")
            {
                DrawerErrorLabel.Text = "Must select a value";
                return false;
            }
            else
            {
                DrawerErrorLabel.Text = "";
                return true;
            }
        }

        private bool checkMaterial()
        {
            if (MaterialCombo.Text == "")
            {
                MaterialErrorLabel.Text = "Must select a material";
                return false;
            }
            else
            {
                MaterialErrorLabel.Text = "";
                return true;
            }
        }

        private bool checkRush()
        {
            if (RushCombo.Text == "")
            {
                RushErrorLabel.Text = "Must select a rush order option";
                return false;
            }
            else
            {
                RushErrorLabel.Text = "";
                return true;
            }
        }

        private void HeightInputValidation(object sender, CancelEventArgs e)
        {
            string errorMessage;
            int height;

            try
            {
                height = System.Convert.ToInt32(HeightInput.Text);
            }
            catch (FormatException)
            {
                HeightInputErrorLabel.Text = "Not integer";
                height = 0;
            }
            catch (OverflowException)
            {
                HeightInputErrorLabel.Text = "Too big";
                height = 0;
            }

            if (height > Desk.MAX_HEIGHT)
            {
                errorMessage = "Height must be less than or equal to " + Desk.MAX_HEIGHT;
                HeightInputErrorLabel.Text = errorMessage;
                e.Cancel = true;
            }
            else if (height < Desk.MIN_HEIGHT)
            {
                errorMessage = "Height must be greater than or equal to " + Desk.MIN_HEIGHT;
                HeightInputErrorLabel.Text = errorMessage;
                e.Cancel = true;
            }
            else
            {
                HeightInputErrorLabel.Text = "";
            }
        }

        private void WidthValidation(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                WidthCheck(e.KeyChar);
            }
            else
            {
                WidthCheck(e.KeyChar);
                e.Handled = true;
            }

        }

        private void WidthCheck(char key)
        {
            string errorMessage;
            string convert = WidthInput.Text;
            int width;

            if (char.IsControl(key))
            {
                WidthInput.SelectionStart = WidthInput.Text.Length;
            }
            else if (char.IsDigit(key))
            {
                convert += key;
                WidthInput.Text = convert;
                WidthInput.SelectionStart = WidthInput.Text.Length;
            }

            try
            {
                width = System.Convert.ToInt32(WidthInput.Text);
            }
            catch (FormatException)
            {
                WidthInputErrorLabel.Text = "Not integer";
                width = 0;
            }
            catch (OverflowException)
            {
                WidthInputErrorLabel.Text = "Too big";
                width = 0;
            }

            if (width > Desk.MAX_WIDTH)
            {
                errorMessage = "Width must be less than or equal to " + Desk.MAX_WIDTH;
                WidthInputErrorLabel.Text = errorMessage;

            }
            else if (width < Desk.MIN_WIDTH)
            {
                errorMessage = "Width must be greater than or equal to " + Desk.MIN_WIDTH;
                WidthInputErrorLabel.Text = errorMessage;

            }
            else
            {
                WidthInputErrorLabel.Text = "";
            }
        }

        private void MaterialChanged(object sender, EventArgs e)
        {
            //MaterialCombo.Items.Remove("Select");
        }

        private void CheckValidation(object sender, EventArgs e)
        {
            bool nothing = validateFields();
        }
    }
}