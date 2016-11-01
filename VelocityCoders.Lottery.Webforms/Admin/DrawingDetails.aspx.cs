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
    public partial class DrawingDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.BindDrawing();
        }

        private void BindDrawing()
        {
            int drawingId = Request.QueryString["DrawingId"].ToInt();

            if (drawingId > 0)
            {
                Drawing drawingLookup = DrawingDAL.GetItem(drawingId);

                if (drawingLookup != null)
                {
                    lblDrawingId.Text = drawingLookup.DrawingId.ToString();
                    lblGameId.Text = drawingLookup.GameId.ToString();
                    lblDrawingDate.Text = drawingLookup.DrawingDate.ToString();
                    lblJackpot.Text = drawingLookup.Jackpot.ToString();
                    lblMultiplier.Text = drawingLookup.Multiplier.ToString();
                }

                else
                    lblMessage.Text = "Drawing could not be found.";
            }
            else
                lblMessage.Text = "Invalid ID. Drawing record could not be found.";
        }
    }
}