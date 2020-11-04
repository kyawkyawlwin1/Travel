using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Travel.view
{
    public partial class foodandbeverage : System.Web.UI.Page
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
                Food_Bev fb = new Food_Bev();
                Guid id = Guid.NewGuid();
                fb.Food_Bev_ID = id.ToString();
                fb.Food_Bev_Name = txtFnBName.Text.Trim();
                fb.Food_Bev_Desc = txtFnBDesc.Text.Trim();
                fb.Visit_Place_ID = ddlVisitPlaceName.SelectedValue;

                db.Food_Bevs.InsertOnSubmit(fb);
                db.SubmitChanges();
            }

        }
    }
}