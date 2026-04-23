using System;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace TicketApplicationSystem
{
    public partial class Form1 : Form
    {
        private readonly Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            LoadCategories();
            dtpTravelDate.MinDate = DateTime.Today;
            dtpTravelDate.Value = DateTime.Today;
            lblTicketRefValue.Text = GenerateTicketReference();
            rtbSummary.Text = "Ticket summary will appear here after calculation.";
        }

        private void LoadCategories()
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("One");
            cmbCategory.Items.Add("Two");
            cmbCategory.Items.Add("Three");
            cmbCategory.SelectedIndex = -1;
        }

        private string GenerateTicketReference()
        {
            return "TCK-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + random.Next(100, 999);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(out string passengerName, out int age, out double distance, out string gender, out string category))
            {
                return;
            }

            double ratePerKm = GetCategoryRate(category);
            double basePrice = ratePerKm * distance;
            double finalPrice = basePrice;

            string pricingNote = "No discount or surcharge applied.";

            if (age < 12)
            {
                finalPrice = 0;
                pricingNote = "FREE ticket applied because passenger is under 12 years old.";
            }
            else
            {
                if (gender.Equals("Female", StringComparison.OrdinalIgnoreCase))
                {
                    finalPrice *= 0.5;
                    pricingNote = "50% female discount applied.";
                }

                if (age >= 60)
                {
                    finalPrice *= 0.7;
                    pricingNote += Environment.NewLine + "30% senior citizen discount applied.";
                }

                if (chkPeakHour.Checked)
                {
                    finalPrice *= 1.10;
                    pricingNote += Environment.NewLine + "10% peak-hour surcharge applied.";
                }
            }

            string ticketReference = GenerateTicketReference();
            lblTicketRefValue.Text = ticketReference;

            StringBuilder summary = new StringBuilder();
            summary.AppendLine("TICKET SUMMARY");
            summary.AppendLine(new string('-', 40));
            summary.AppendLine("Ticket Ref: " + ticketReference);
            summary.AppendLine("Travel Date: " + dtpTravelDate.Value.ToString("dddd, dd MMMM yyyy"));
            summary.AppendLine("Passenger Name: " + passengerName);
            summary.AppendLine("Gender: " + gender);
            summary.AppendLine("Age: " + age);
            summary.AppendLine("Category: " + category);
            summary.AppendLine("Distance: " + distance.ToString("0.##") + " km");
            summary.AppendLine("Rate per km: R" + ratePerKm.ToString("0.00", CultureInfo.InvariantCulture));
            summary.AppendLine("Base Price: R" + basePrice.ToString("0.00", CultureInfo.InvariantCulture));
            summary.AppendLine("Peak Hour: " + (chkPeakHour.Checked ? "Yes" : "No"));
            summary.AppendLine("Pricing Notes:");
            summary.AppendLine(pricingNote);
            summary.AppendLine("Final Ticket Price: R" + finalPrice.ToString("0.00", CultureInfo.InvariantCulture));

            rtbSummary.Text = summary.ToString();

            MessageBox.Show(
                "Ticket calculated successfully." + Environment.NewLine +
                "Final Price: R" + finalPrice.ToString("0.00", CultureInfo.InvariantCulture),
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private bool ValidateInputs(out string passengerName, out int age, out double distance, out string gender, out string category)
        {
            passengerName = txtName.Text.Trim();
            age = 0;
            distance = 0;
            gender = string.Empty;
            category = string.Empty;

            if (string.IsNullOrWhiteSpace(passengerName))
            {
                MessageBox.Show("Please enter the passenger name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            if (!int.TryParse(txtAge.Text.Trim(), out age) || age < 0)
            {
                MessageBox.Show("Please enter a valid numeric age.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAge.Focus();
                txtAge.SelectAll();
                return false;
            }

            if (!double.TryParse(txtDistance.Text.Trim(), out distance) || distance < 0)
            {
                MessageBox.Show("Please enter a valid numeric distance.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDistance.Focus();
                txtDistance.SelectAll();
                return false;
            }

            if (!rdoMale.Checked && !rdoFemale.Checked)
            {
                MessageBox.Show("Please select a gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            gender = rdoMale.Checked ? "Male" : "Female";

            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategory.Focus();
                return false;
            }

            category = cmbCategory.SelectedItem.ToString();

            return true;
        }

        private double GetCategoryRate(string category)
        {
            switch (category)
            {
                case "One":
                    return 20;
                case "Two":
                    return 35;
                case "Three":
                    return 50;
                default:
                    return 0;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAge.Clear();
            txtDistance.Clear();
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            cmbCategory.SelectedIndex = -1;
            chkPeakHour.Checked = false;
            dtpTravelDate.Value = DateTime.Today;
            lblTicketRefValue.Text = GenerateTicketReference();
            rtbSummary.Text = "Ticket summary will appear here after calculation.";
            txtName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit the application?",
                "Exit Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDistance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains("."))
            {
                e.Handled = true;
            }
        }
    }
}