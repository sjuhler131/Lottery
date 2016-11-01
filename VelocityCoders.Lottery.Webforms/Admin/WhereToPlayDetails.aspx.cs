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
    public partial class WhereToPlayDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.BindWhereToPlay();
        }

        private void BindWhereToPlay()
        {
            int whereToPlayId = Request.QueryString["WhereToPlayId"].ToInt();

            if (whereToPlayId > 0)
            {
                WhereToPlay whereToPlayLookup = WhereToPlayDAL.GetItem(whereToPlayId);

                if (whereToPlayLookup != null)
                {
                    lblWhereToPlayId.Text = whereToPlayLookup.WhereToPlayId.ToString();
                    lblGameId.Text = whereToPlayLookup.GameId.ToString();
                    lblStateId.Text = whereToPlayLookup.StateId.ToString();
                    lblCityId.Text = whereToPlayLookup.CityId.ToString();
                    lblAddressName.Text = whereToPlayLookup.AddressName;
                    lblAddressNumber.Text = whereToPlayLookup.AddressNumber.ToString();
                    lblStreet01.Text = whereToPlayLookup.Street01;
                    lblStreet02.Text = whereToPlayLookup.Street02;
                    lblZipCode.Text = whereToPlayLookup.ZipCode.ToString();
                    lblZipCodePlusFour.Text = whereToPlayLookup.ZipCodePlusFour.ToString();
                }

                else
                    lblMessage.Text = "Location could not be found.";
            }
            else
                lblMessage.Text = "Invalid ID. Location record could not be found.";
        }
    }
}