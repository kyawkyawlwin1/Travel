using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Travel.view
{
    public partial class hotel : System.Web.UI.Page
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
                Hotel ht = new Hotel();
                Guid id = Guid.NewGuid();
                ht.Hotel_ID = id.ToString();
                ht.Hotel_Name = txtHotelName.Text.Trim();
                ht.Hotel_Desc = txtHotelDesc.Text.Trim();
                ht.Visit_Place_ID = ddlVisitPlaceName.Text.Trim();

                db.Hotels.InsertOnSubmit(ht);
                db.SubmitChanges();
            }
        }
    }
}