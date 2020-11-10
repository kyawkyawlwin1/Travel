using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Travel.view
{
    public partial class famous_place_image : System.Web.UI.Page
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
                tbFPimg fpi = new tbFPimg();
                Guid id = Guid.NewGuid();
                fpi.Famous_Place_Image_ID = id.ToString();
                fpi.image = imgFamousPlace.FileBytes;
                fpi.Visit_Place_ID = ddlVisitPlaceName.SelectedValue;

                db.tbFPimgs.InsertOnSubmit(fpi);
                db.SubmitChanges();

                
            }
        }
    }
}