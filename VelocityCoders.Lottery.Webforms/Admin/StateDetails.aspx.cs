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
    public partial class StateDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.BindState();
        }

        private void BindState()
        {
            int stateId = Request.QueryString["StateId"].ToInt();

            if (stateId > 0)
            {
                State stateLookup = StateDAL.GetItem(stateId);

                if (stateLookup != null)
                {
                    lblStateId.Text = stateLookup.StateId.ToString();
                    lblStateName.Text = stateLookup.StateName;
                    lblStateAbbreviation.Text = stateLookup.StateAbbreviation.ToString();
                }

                else
                    lblMessage.Text = "State could not be found.";
            }
            else
                lblMessage.Text = "Invalid ID. State record could not be found.";
        }
    }
}