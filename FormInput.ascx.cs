using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FormInput : System.Web.UI.UserControl
{
    public string Text
    {
        get { return label.Text; }
        set { textBox.Text = value;  }
    }

    public string Value
    {
        get { return textBox.Text; }
        set { textBox.Text = value; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
}