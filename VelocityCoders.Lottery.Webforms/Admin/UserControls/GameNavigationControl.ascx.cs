using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VelocityCoders.Lottery.WebForms;

namespace VelocityCoders.Lottery.Webforms.Admin.UserControls
{
    public partial class GameNavigationControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.BindGameNavigation();
        }

        public GameNavigation CurrentNavigationLink { get; set; }

        public int GameId { get; set; }

        private void BindGameNavigation()
        {
            ListItemCollection navigationList = new ListItemCollection();

            Array navigationValues = Enum.GetValues(typeof(GameNavigation));

            string gameIdQueryString = "GameId=" + this.GameId.ToString();
            if (this.GameId > 0)
            {
                foreach (GameNavigation item in navigationValues)
                {
                    if (item != GameNavigation.None)
                    {
                        string displayValue = item.ToString();

                        if (item == this.CurrentNavigationLink)
                            navigationList.Add(new ListItem { Text = displayValue, Value = "", Enabled = false });
                        else
                            navigationList.Add(new ListItem
                            {
                                Text = displayValue,
                                Value = "/Admin/Game/" + item.ToString() + ".aspx?" + gameIdQueryString,
                                Enabled = true
                            });
                    }
                }
            }
            else
            {
                foreach (GameNavigation item in navigationValues)
                {
                    if (item != GameNavigation.None)
                    {
                        navigationList.Add(new ListItem
                        {
                            Text = item.ToString(),
                            Value = "/Admin/Game/" + item.ToString() + ".aspx?" + gameIdQueryString,
                            Enabled = false
                        });
                    }

                }
            }
            GameNavigationList.DataSource = navigationList;
            GameNavigationList.DataBind();
        }
    }
}