using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    int a;
    int b;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        a = Convert.ToInt32(TextBox1.Text);
        b = Convert.ToInt32(TextBox2.Text);

        int res = a + b;
        Label1.Text = res.ToString();
            
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

    }
    protected void Button3_Click(object sender, EventArgs e)
    {

    }
    protected void Button4_Click(object sender, EventArgs e)
    {

    }
    protected void Button5_Click(object sender, EventArgs e)
    {

    }
    protected void Button2_Click1(object sender, EventArgs e)
    {
        a = Convert.ToInt32(TextBox1.Text);
        b = Convert.ToInt32(TextBox2.Text);

        int res = a - b;
        Label1.Text = res.ToString();
    }
    protected void Button3_Click1(object sender, EventArgs e)
    {
        a = Convert.ToInt32(TextBox1.Text);
        b = Convert.ToInt32(TextBox2.Text);

        int res = a * b;
        Label1.Text = res.ToString();
    }
    protected void Button4_Click1(object sender, EventArgs e)
    {
        a = Convert.ToInt32(TextBox1.Text);
        b = Convert.ToInt32(TextBox2.Text);

        int res = a / b;
        Label1.Text = res.ToString();
    }
    protected void Button5_Click1(object sender, EventArgs e)
    {
        decimal res = Math.Round(Convert.ToDecimal(TextBox1.Text),Convert.ToInt32(TextBox2.Text));
        Label1.Text = res.ToString();
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        double res = Math.Sqrt(Convert.ToDouble(TextBox1.Text));
        Label1.Text = res.ToString();
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        double res = Math.Sign(Convert.ToDouble(TextBox1.Text));
        Label1.Text = res.ToString();

    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        double res = Math.Tan(Convert.ToDouble(TextBox1.Text));
        Label1.Text = res.ToString();
    }
    protected void Button9_Click(object sender, EventArgs e)
    {
        double res = Math.Cos(Convert.ToDouble(TextBox1.Text));
        Label1.Text = res.ToString();
    }
    protected void Button10_Click(object sender, EventArgs e)
    {
      decimal res = Math.Max(Convert.ToDecimal(TextBox1.Text), Convert.ToDecimal(TextBox2.Text));
                Label1.Text = res.ToString();

    }
}