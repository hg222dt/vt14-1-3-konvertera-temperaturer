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
            //Kollar så att data har blivit validerat och godkänt
            if(IsValid)
            {
                //Fahrenheit till Celsius-omvandling
                if (konvTyp1.Checked)
                {
                    TableHeaderCell1.Text = "Fahrenheit";
                    TableHeaderCell2.Text = "Celsius";
                }

                //Celsius till Fahrenheit-omvandling
                else if (konvTyp2.Checked)
                {
                    TableHeaderCell1.Text = "Celsius";
                    TableHeaderCell2.Text = "Fahrenheit";
                }

                //Loop som kör så många varv som det ska skrivas ut temperaturrader i tabellen.
                for (int i = int.Parse(starttemp.Text); i <= int.Parse(sluttemp.Text); i = i + int.Parse(steg.Text))
                {
                    //Tabellrad skapas och adderas till vår tidigare skapade tabell.
                    TableRow tRad = new TableRow();
                    resultattabell.Rows.Add(tRad);

                    //Två tabellceller skapas och adderas
                    TableCell tCell1 = new TableCell();
                    tRad.Cells.Add(tCell1);

                    TableCell tCell2 = new TableCell();
                    tRad.Cells.Add(tCell2);
                    
                    //Första cellen på raden sätts till antal grader på den raden.
                    tCell1.Text = i.ToString();

                    //Itteration som infaller om omvandlingen gäller Fahrenheit till Celsius.
                    if (konvTyp1.Checked)
                    {
                        //Metod i Reciept-klassen anropas för att räkna ut omvandlingen i temp
                        tCell2.Text = Model.TemperatureConverter.FahrenheitToCelcius(i).ToString();
                    }

                    //Itteration Celsius till Fahrenheit
                    else if (konvTyp2.Checked)
                    {
                        //Metod i Reciept-klassen anropas för att räkna ut omvandlingen i temp
                        tCell2.Text = Model.TemperatureConverter.CelsiusToFahrenheit(i).ToString();
                    }

                    //Tabellen sätts till synlig
                    resultattabell.Visible = true;
                }
            }
        }
    }
}