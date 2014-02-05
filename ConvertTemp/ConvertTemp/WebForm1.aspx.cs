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


                for (int i = int.Parse(starttemp.Text); i <= int.Parse(sluttemp.Text); i = i + int.Parse(steg.Text))
                {

                    if (konvTyp1.Checked)
                    {
                        Model.TemperatureConverter.FahrenheitToCelcius(i);
                    }

                    else if (konvTyp1.Checked)
                    {
                        Model.TemperatureConverter.CelsiusToFahrenheit(i);
                    }

                    
                }
                
            }
        }
    }
}