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
    public partial class GameDetailDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.BindGameDetail();
        }

        private void BindGameDetail()
        {
            int gameDetailId = Request.QueryString["GameDetailId"].ToInt();

            if (gameDetailId > 0)
            {
                GameDetail gameDetailLookup = GameDetailDAL.GetItem(gameDetailId);

                if (gameDetailLookup != null)
                {
                    lblGameDetailId.Text = gameDetailLookup.GameDetailId.ToString();
                    lblGameId.Text = gameDetailLookup.GameId.ToString();
                    lblMatch.Text = gameDetailLookup.Match;
                    lblOdds.Text = gameDetailLookup.Odds;
                    lblPrize.Text = gameDetailLookup.Prize;
                }

                else
                    lblMessage.Text = "Game could not be found.";
            }
            else
                lblMessage.Text = "Invalid ID. Game record could not be found.";
        }
    }
}