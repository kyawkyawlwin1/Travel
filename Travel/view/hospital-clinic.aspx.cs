using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Travel.view
{
    public partial class hospital_clinic : System.Web.UI.Page
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
                Hospital_Clinic hc = new Hospital_Clinic();
                Guid id = Guid.NewGuid();
                hc.Hospital_Clinic_ID = id.ToString();
                hc.Hospital_Clinic_Name = txtHorCName.Text.Trim();
                hc.Hospital_Clinic_Desc = txtHorCDesc.Text.Trim();
                hc.Visit_Place_ID = ddlVisitPlaceName.SelectedValue;

                db.Hospital_Clinics.InsertOnSubmit(hc);
                db.SubmitChanges();
            }
        }
    }
}