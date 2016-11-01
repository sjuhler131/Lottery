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
    public partial class DrawingNumbersDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.BindDrawingNumbers();
        }

        private void BindDrawingNumbers()
        {
            int drawingNumbersId = Request.QueryString["DrawingNumbersId"].ToInt();

            if (drawingNumbersId > 0)
            {
                DrawingNumbers drawingNumbersLookup = DrawingNumbersDAL.GetItem(drawingNumbersId);

                if (drawingNumbersLookup != null)
                {
                    lblDrawingNumbersId.Text = drawingNumbersLookup.DrawingId.ToString();
                    lblBallTypeId.Text = drawingNumbersLookup.BallTypeId.ToString();
                    lblDrawingId.Text = drawingNumbersLookup.DrawingId.ToString();
                    lblNumber.Text = drawingNumbersLookup.Number.ToString();
                }

                else
                    lblMessage.Text = "Drawing Numbers could not be found.";
            }
            else
                lblMessage.Text = "Invalid ID. Drawing Numbers record could not be found.";
        }
    }
}