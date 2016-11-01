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
    public partial class BallTypeDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.BindBallType();
        }

        private void BindBallType()
        {
            int ballTypeId = Request.QueryString["BallTypeId"].ToInt();

            if (ballTypeId > 0)
            {
                BallType ballTypeLookup = BallTypeDAL.GetItem(ballTypeId);

                if (ballTypeLookup != null)
                {
                    lblBallTypeId.Text = ballTypeLookup.BallTypeId.ToString();
                    lblBallTypeName.Text = ballTypeLookup.BallTypeName;
                    lblSequence.Text = ballTypeLookup.Sequence.ToString();
                }

                else
                    lblMessage.Text = "BallType could not be found.";
            }
            else
                lblMessage.Text = "Invalid ID. BallType record could not be found.";
        }
    }
}