using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace VelocityCoders.Lottery.Webforms.Admin.DrawingForm
{
    public partial class DrawingForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Save_Click(object sender, EventArgs e)
        {
            this.ProcessForm();
        }

        private void ProcessForm()
        {
            StringBuilder formValues = new StringBuilder();

            string gameName = drpGameName.SelectedItem.Text;
            string drawingDate = txtDrawingDate.Text;
            string jackpotAmount = txtJackpotAmount.Text;
            string cashOptionAmount = txtCashOptionAmount.Text;
            string multiplier = txtMultiplier.Text;

            formValues.Append("Game Name: " + gameName);
            formValues.Append("<br>");
            formValues.Append("Drawing Date: " + drawingDate);
            formValues.Append("<br>");
            formValues.Append("Jackpot: " + jackpotAmount);
            formValues.Append("<br>");
            formValues.Append("Cash Option Amount: " + cashOptionAmount);
            formValues.Append("<br>");
            formValues.Append("Multiplier: " + multiplier);

            lblDisplayMessage.Text = formValues.ToString();
        }
    }
}