using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Travel.model;

namespace Travel.view
{
    public partial class pyongyang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            using(DataClassesDataContext db = new DataClassesDataContext())
            {
                Visit_Place vp = new Visit_Place();
                Guid id = Guid.NewGuid();
                vp.Visit_Place_ID = id.ToString();
                vp.Visit_Place_Name = txtVisitPlaceName.Text.Trim();
                vp.Visit_Place_Desc = txtVisitPlaceDesc.Text.Trim();

                db.Visit_Places.InsertOnSubmit(vp);
                db.SubmitChanges();
            }
        }
    }
}