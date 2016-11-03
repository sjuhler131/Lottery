using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VelocityCoders.Lottery.Webforms.ViewStateTests
{
    public partial class ViewStateOn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Save_Click(object sender, EventArgs e)
        {
            lblPageMessage.Text = txtEnterSomeNumbers.Text.ToString();
        }
    }
}