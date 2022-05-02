using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASMXWebDemo
{
    public partial class Error : System.Web.UI.Page
    {
        protected string ErrorMessage;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.ErrorMessage = Request.QueryString["message"];
        }
    }
}