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
    public partial class GameDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.BindGame();
        }

        private void BindGame()
        {
            int gameId = Request.QueryString["GameId"].ToInt();

            if (gameId > 0)
            {
                Game gameLookup = GameDAL.GetItem(gameId);

                if (gameLookup != null)
                {
                    lblGameId.Text = gameLookup.GameId.ToString();
                    lblGameName.Text = gameLookup.GameName;
                    lblDescription.Text = gameLookup.Description;
                    lblHowToPlay.Text = gameLookup.HowToPlay;
                }

                else
                    lblMessage.Text = "Game could not be found.";
            }
            else
                lblMessage.Text = "Invalid ID. Game record could not be found.";
        }
    }
}