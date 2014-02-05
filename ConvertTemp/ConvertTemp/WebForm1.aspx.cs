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
                //Rendewra ut tabellen här
                //Med hjälp av klasserna TableRow och TableCell
                //som läggs till i table-kontrollen

                //Räkna ut vilka c/f fu ska skicka med till klassen.

                TableRow tRadTop = new TableRow();
                resultattabell.Rows.Add(tRadTop);

                TableCell titleCell1 = new TableCell();
                tRadTop.Cells.Add(titleCell1);

                TableCell titleCell2 = new TableCell();
                tRadTop.Cells.Add(titleCell2);

                if (konvTyp1.Checked)
                {
                    titleCell1.Text = "Fahrenheit";
                    titleCell2.Text = "Celcius";
                }

                else if (konvTyp2.Checked)
                {
                    titleCell1.Text = "Celcius";
                    titleCell2.Text = "Fahrenheit";
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