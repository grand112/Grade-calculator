using System;
using System.Drawing;
using System.Windows.Forms;
using SredniaForm.SredniaServiceReference;

namespace SredniaForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOblicz_Click(object sender, EventArgs e)
        {
            SredniaServiceClient loClient = new SredniaServiceClient();

            txtPoprawne.Visible = true;
            double ocena1,ocena2,ocena3,ocena4,ocena5,ocena6;
            double srednia;
            double parsedValue;

            if (txtOcena4.Visible == false)
            {
                if (!double.TryParse(txtOcena1.Text, out parsedValue) || !double.TryParse(txtOcena2.Text, out parsedValue) || !double.TryParse(txtOcena3.Text, out parsedValue))
                {
                    txtPoprawne.Visible = false;
                    MessageBox.Show("Możesz wpisać tylko liczby! Nie pozostawiaj pustych pól.");
                    return;
                }
            }
            else
            {
                if (!double.TryParse(txtOcena1.Text, out parsedValue) || !double.TryParse(txtOcena2.Text, out parsedValue) || !double.TryParse(txtOcena3.Text, out parsedValue) || !double.TryParse(txtOcena4.Text, out parsedValue) || !double.TryParse(txtOcena5.Text, out parsedValue) || !double.TryParse(txtOcena6.Text, out parsedValue))
                {
                    txtPoprawne.Visible = false;
                    MessageBox.Show("Możesz wpisać tylko liczby! Nie pozostawiaj pustych pól.");
                    return;
                }
            }

            if(txtOcena4.Visible == false)
            {
                ocena1 = Convert.ToDouble(txtOcena1.Text.Trim());
                ocena2 = Convert.ToDouble(txtOcena2.Text.Trim());
                ocena3 = Convert.ToDouble(txtOcena3.Text.Trim());

                double[] oceny = { ocena1, ocena2, ocena3 };

                srednia = loClient.ObliczSrednia(oceny);

                txtSrednia.Text = srednia.ToString();

                txtPoprawne.Text = loClient.CzyPoprawna(oceny);
            }
            else
            {
                ocena1 = Convert.ToDouble(txtOcena1.Text.Trim());
                ocena2 = Convert.ToDouble(txtOcena2.Text.Trim());
                ocena3 = Convert.ToDouble(txtOcena3.Text.Trim());
                ocena4 = Convert.ToDouble(txtOcena4.Text.Trim());
                ocena5 = Convert.ToDouble(txtOcena5.Text.Trim());
                ocena6 = Convert.ToDouble(txtOcena6.Text.Trim());

                double[] oceny = { ocena1, ocena2, ocena3, ocena4, ocena5, ocena6 };

                srednia = loClient.ObliczSrednia(oceny);

                txtSrednia.Text = srednia.ToString();

                txtPoprawne.Text = loClient.CzyPoprawna(oceny);
            }
            

            if (txtPoprawne.Text == "Prawidłowo wprowadzono oceny")
            {
                txtPoprawne.BackColor = Color.LightGreen;
                txtZdane.Visible = true;
                txtSrednia.Visible = true;
                SredniaNapis.Visible = true;
                txtSrednia.Text = srednia.ToString();
                txtZdane.Text = loClient.CzyZdane(srednia);
            }else
            {
                txtPoprawne.BackColor = Color.Red;
                txtZdane.Visible = false;
                txtSrednia.Visible = false;
                SredniaNapis.Visible = false;
            }
            
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            OcenaNapis4.Visible = true;
            txtOcena4.Visible = true;
            OcenaNapis5.Visible = true;
            txtOcena5.Visible = true;
            OcenaNapis6.Visible = true;
            txtOcena6.Visible = true;
            btnDodaj.Visible = false;
        }

        private void btnWyczysc_Click(object sender, EventArgs e)
        {
                if (txtOcena4.Visible == true)
                {
                    txtOcena1.Text = String.Empty;
                    txtOcena2.Text = String.Empty;
                    txtOcena3.Text = String.Empty;
                    txtOcena4.Text = String.Empty;
                    txtOcena5.Text = String.Empty;
                    txtOcena6.Text = String.Empty;
                }
                else
                {
                    txtOcena1.Text = String.Empty;
                    txtOcena2.Text = String.Empty;
                    txtOcena3.Text = String.Empty;
                }
        }
    }
}
