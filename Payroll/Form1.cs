using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 Anthony Griego
 FINAL PROJECT
*/


namespace Payroll
{
    public partial class frmMain : Form
    {

        int empCounter = 1;
        double hourlyRate, hoursWorked;
        Dictionary<int, Employee> empDictionary = new Dictionary<int, Employee>(); // dictionary will store each Employee object

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtHourlyRate.Text != "0" && txtHoursWorked.Text != "0") // if inputs still have values, then submit to the dictionary
            {
                if (Double.TryParse(txtHourlyRate.Text, out hourlyRate) == false | Double.TryParse(txtHoursWorked.Text, out hoursWorked) == false)
                {
                    MessageBox.Show("INVALID INPUT - please try again", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                empDictionary.Add(empCounter, new Employee(txtName.Text, hourlyRate, hoursWorked)); // add new dictionary entry
                txtName.Clear();
                txtHourlyRate.Text = "0";
                txtHoursWorked.Text = "0";
            }

            double totalGross, totalNet, totalSS, totalMed, totalState, totalFed;
            totalGross = totalNet = totalSS = totalMed = totalState = totalFed = 0;

            for (int x = 1; x < empDictionary.Count + 1; x++)
            {
                empDictionary[x].calcPayroll();
                totalGross += empDictionary[x].GrossPay;
                totalNet += empDictionary[x].NetPay;
                totalSS += empDictionary[x].SS;
                totalMed += empDictionary[x].Medicare;
                totalState += empDictionary[x].State;
                totalFed += empDictionary[x].Federal;
            }

            lblGross.Text = String.Format("{0:C2}", totalGross);
            lblNet.Text = String.Format("{0:C2}", totalNet);
            lblSS.Text = String.Format("{0:C2}", totalSS);
            lblMed.Text = String.Format("{0:C2}", totalMed);
            lblStateTax.Text = String.Format("{0:C2}", totalState);
            lblFedTax.Text = String.Format("{0:C2}", totalFed);

            lblOutput.Text = DictionaryToString(empDictionary);

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtHourlyRate.Text, out hourlyRate) == false | Double.TryParse(txtHoursWorked.Text, out hoursWorked) == false)
            {
                MessageBox.Show("INVALID INPUT - please try again", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            empDictionary.Add(empCounter, new Employee(txtName.Text, hourlyRate, hoursWorked)); // add new dictionary entry
            empCounter++;
            txtName.Clear();
            txtHourlyRate.Text = "0";
            txtHoursWorked.Text = "0";
            lblEmpNumber.Text = "Emp #" + empCounter.ToString();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblEmpNumber.Text = "Emp #" + empCounter.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtHourlyRate.Text = "0";
            txtHoursWorked.Text = "0";
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtHourlyRate.Text = "0";
            txtHoursWorked.Text = "0";
            lblOutput.Text = "";
            empCounter = 1;
            empDictionary.Clear();
            lblGross.Text = "";
            lblNet.Text = "";
            lblSS.Text = "";
            lblMed.Text = "";
            lblStateTax.Text = "";
            lblFedTax.Text = "";
            lblEmpNumber.Text = "Emp #" + empCounter.ToString();
        }

        public static string DictionaryToString(Dictionary<int, Employee> dict)
        {
            var str = new StringBuilder();
            str.Append("EMP # -- NAME -- GROSS PAY -- SS WITHHELD -- MED WITHHELD -- STATE TAX -- FED TAX : NET PAY\n");
            for (int x = 1; x < dict.Count + 1; x++)
            {
                str.Append(String.Format(" {0} -- {1} -- {2:C2} -- {3:C2} -- {4:C2} -- {5:C2} -- {6:C2} : {7:C2}\n", x, dict[x].Name, dict[x].GrossPay, dict[x].SS, dict[x].Medicare, dict[x].State, dict[x].Federal, dict[x].NetPay));
            }
            return str.ToString();
        }


    }

    public class Employee
    {
        public const double SOCIAL_SECURITY_RATE = .062;
        public const double MEDICARE_RATE = .0145;
        public String Name { get; set; }
        public Double HourlyRate { get; set; }
        public Double HoursWorked { get; set; }

        public Double GrossPay { get; set; }
        public Double SS { get; set; }
        public Double Medicare { get; set; }
        public Double State { get; set; }
        public Double Federal { get; set; }
        public Double NetPay { get; set; }

        public Employee(string f, double r, double w)
        {
            Name = f;
            HourlyRate = r;
            HoursWorked = w;
        }

        public void calcPayroll()
        {
            double stateTaxRate = 0;
            double fedTaxRate = 0;
            GrossPay = HourlyRate * HoursWorked;
            SS = GrossPay * SOCIAL_SECURITY_RATE;
            Medicare = GrossPay * MEDICARE_RATE;

            if (GrossPay >= 0 && GrossPay < 500)
            {
                stateTaxRate = .02;
                fedTaxRate = .05;
            }
            else if (GrossPay >= 500 && GrossPay <= 999.99)
            {
                stateTaxRate = .04;
                fedTaxRate = .1;
            }
            else if (GrossPay >= 1000 && GrossPay <= 1499.99)
            {
                stateTaxRate = .06;
                fedTaxRate = .15;
            }
            else if (GrossPay >= 1500 && GrossPay <= 1999.99)
            {
                stateTaxRate = .06;
                fedTaxRate = .2;
            }
            else if (GrossPay >= 2000 && GrossPay <= 2999.99)
            {
                stateTaxRate = .06;
                fedTaxRate = .25;
            }
            else if (GrossPay >= 3000)
            {
                stateTaxRate = .06;
                fedTaxRate = .3;
            }

            State = GrossPay * stateTaxRate;
            Federal = GrossPay * fedTaxRate;
            NetPay = GrossPay - SS - Medicare - State - Federal;

        }
    }




}
