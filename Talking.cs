using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Net;
using System.Text;

/// <summary>
/// Summary description for Talking
/// </summary>
/// 
public enum httpVerb
{
    GET,
    POST,
    PUT,
    DELETE
}
public class Talking
{
    public String endPoint { get; set; }
    public httpVerb httpMethod { get; set; }

    public Talking()
    {
        endPoint = string.Empty;
        httpMethod = httpVerb.GET;
    }

    public string makeRequest()
    {
        string strResponseValue = string.Empty;
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);

        request.Method = httpMethod.ToString();

        using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
        {
            if (response.StatusCode == HttpStatusCode.OK)
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();
                        }
                    }
                }
            }

            return strResponseValue;
        }
    }



}