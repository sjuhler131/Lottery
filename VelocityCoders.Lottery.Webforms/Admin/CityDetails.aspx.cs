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
    public partial class CityDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.BindCity();
        }

        private void BindCity()
        {
            int cityId = Request.QueryString["CityId"].ToInt();

            if (cityId > 0)
            {
                City cityLookup = CityDAL.GetItem(cityId);

                if (cityLookup != null)
                {
                    lblCityId.Text = cityLookup.CityId.ToString();
                    lblCityName.Text = cityLookup.CityName;
                }

                else
                    lblMessage.Text = "Game could not be found.";
            }
            else
                lblMessage.Text = "Invalid ID. Game record could not be found.";
        }
    }
}