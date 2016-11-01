using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VelocityCoders.Lottery.Models;
using VelocityCoders.Lottery.Models.Collections;
using VelocityCoders.Lottery.DAL;
using Uhler.Common;

namespace VelocityCoders.Lottery.Webforms.Admin
{
    public partial class DrawingList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.BindDrawingList();
        }

        private void BindDrawingList()
        {
            DrawingCollection drawingList = new DrawingCollection();

            drawingList = DrawingDAL.GetCollection();

            rptDrawingList.DataSource = drawingList;
            rptDrawingList.DataBind();
        }
    }
}