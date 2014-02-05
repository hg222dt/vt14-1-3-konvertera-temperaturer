using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConvertTemp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void konverteraKnapp_Click(object sender, EventArgs e)
        {
            //RequiredFieldValidator1.Visible = false;
            //RequiredFieldValidator2.Visible = false;
            //RequiredFieldValidator3.Visible = false;

            if(IsValid)
            {
                if (konvTyp1.Checked)
                {
                    TableHeaderCell1.Text = "Fahrenheit";
                    TableHeaderCell2.Text = "Celsius";
                }

                else if (konvTyp2.Checked)
                {
                    TableHeaderCell1.Text = "Celsius";
                    TableHeaderCell2.Text = "Fahrenheit";
                }

                for (int i = int.Parse(starttemp.Text); i <= int.Parse(sluttemp.Text); i = i + int.Parse(steg.Text))
                {
                    TableRow tRad = new TableRow();
                    resultattabell.Rows.Add(tRad);

                    TableCell tCell1 = new TableCell();
                    tRad.Cells.Add(tCell1);

                    TableCell tCell2 = new TableCell();
                    tRad.Cells.Add(tCell2);
                     
                    tCell1.Text = i.ToString();

                    if (konvTyp1.Checked)
                    {
                        tCell2.Text = Model.TemperatureConverter.FahrenheitToCelcius(i).ToString();
                    }

                    else if (konvTyp2.Checked)
                    {
                        tCell2.Text = Model.TemperatureConverter.CelsiusToFahrenheit(i).ToString();
                    }

                    resultattabell.Visible = true;
                }
            }
        }
    }
}

//KOlla upp så att du har viewstatemode rätt överallt
//Fixa till felmeddelandena
//ev fixa med defulfbutton focus och select.
//Ändra till dynamic på validatorerna

//ev fixa så att en ruta poppar upp med validation summary.