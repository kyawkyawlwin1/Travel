using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Travel.view
{
    public partial class souvenir_shop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Visit_Place> lpy = new List<Visit_Place>();
                using (DataClassesDataContext db = new DataClassesDataContext())
                {
                    lpy = db.Visit_Places.ToList();
                }
                ddlVisitPlaceName.DataSource = lpy;
                ddlVisitPlaceName.DataTextField = "Visit_Place_Name";
                ddlVisitPlaceName.DataValueField = "Visit_Place_ID";
                ddlVisitPlaceName.DataBind();
                ddlVisitPlaceName.Items.Insert(0, "--Select Visit Place--");
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            using(DataClassesDataContext db = new DataClassesDataContext())
            {
                Souvenir_Shop ss = new Souvenir_Shop();
                Guid id = Guid.NewGuid();
                ss.Souvenir_Shop_ID = id.ToString();
                ss.Souvenir_Shop_Name = txtSouvenirShopName.Text.Trim();
                ss.Souvenir_Shop_Desc = txtSouvenirShopDesc.Text.Trim();
                ss.Visit_Place_ID = ddlVisitPlaceName.SelectedValue;

                db.Souvenir_Shops.InsertOnSubmit(ss);
                db.SubmitChanges();
            }
        }
    }
}