using System;

namespace WebApplicationForm
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;

            TextBox1.Text = "Post this";

            Literal1.Text += "<code>";
            Literal1.Text += Request.ServerVariables["ALL_RAW"].Replace("\n", "<br>");
            Literal1.Text += "............................<br>";
            Literal1.Text += Request.Url.Authority + "<br>";
            Literal1.Text += "............................<br>";
            Literal1.Text += Request.Url.AbsoluteUri + "<br>";
            Literal1.Text += "</code>";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox2.Text = $"Posted: {TextBox1.Text}";
        }
    }
}