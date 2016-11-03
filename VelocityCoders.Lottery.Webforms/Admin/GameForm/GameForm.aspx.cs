using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace VelocityCoders.Lottery.Webforms.Admin.GameForm
{
    public partial class GameForm : System.Web.UI.Page
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

            string gameName = txtGameName.Text;
            string gameNameAbbreviation = txtGameNameAbbreviation.Text;
            string howtoPlay = txtHowtoPlay.Text;
            string description = txtDescription.Text;

            formValues.Append("Game Name: " + gameName);
            formValues.Append("<br>");
            formValues.Append("Game Abbreviation: " + gameNameAbbreviation);
            formValues.Append("<br>");
            formValues.Append("How to Play: " + howtoPlay);
            formValues.Append("<br>");
            formValues.Append("Description: " + description);

            lblDisplayMessage.Text = formValues.ToString();
        }
    }
}