using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Uhler.Common.Extensions;
using VelocityCoders.Lottery.DAL;
using VelocityCoders.Lottery.Models;

namespace VelocityCoders.Lottery.Webforms.Admin
{
    public partial class CostDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.BindCost();
        }

        private void BindCost()
        {
            int costId = Request.QueryString["CostId"].ToInt();

            if (costId > 0)
            {
                Cost costLookup = CostDAL.GetItem(costId);

                if (costLookup != null)
                {
                    lblCostId.Text = costLookup.CostId.ToString();
                    lblGameId.Text = costLookup.GameId.ToString();
                    lblCostAmount.Text = costLookup.CostAmount.ToString();
                }

                else
                    lblMessage.Text = "Cost could not be found.";
            }
            else
                lblMessage.Text = "Invalid ID. Cost record could not be found.";
        }
    }
}