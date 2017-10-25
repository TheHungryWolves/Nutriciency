using System;
using System.IO;
using System.Net;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class APImHavingFun : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Unnamed2_Click(object sender, EventArgs e)
    {
        Talking client = new Talking();
        client.endPoint = txt1.Text;

        string response = client.makeRequest();

        Label1.Text = response;

        //string url = ("https://api.nal.usda.gov/ndb/list?format=JSON&lt=f&sort=n&api_key=q8blQscG7a3EBdoUXqehUi2QEm5CZ0I23o6op2TB");

        //httpVerb httpVerb = new
        //    HttpClient client = new HttpClient();
        //client.DefaultRequestHeaders.Add("Accept", "application/json");

        //var jsonString = await client.GetStringAsync(zip);

        //JToken token = JToken.Parse(jsonString);

        //foreach (var item in token)
        //{

        //}
    }
}