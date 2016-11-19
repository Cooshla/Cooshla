using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Web.Http;
using Umbraco.Web.WebApi;

namespace AgencySite.Controllers
{
    public class ProjectPlanController : UmbracoApiController
    {


        public string Get()
        {
            return "working";
        }
        // POST api/<controller>
        public void Post([FromBody]dynamic JSONData)
        {


            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Name: "+ JSONData.name);
            sb.AppendLine("Email: " + JSONData.email);
            sb.AppendLine("Phone: " + JSONData.phone);
            sb.AppendLine("Company: " + JSONData.company);
            sb.AppendLine("Url: " + JSONData.url);
            sb.AppendLine("");
            sb.AppendLine("Project Details: " + JSONData.details);
            sb.AppendLine("Branding Guidelines: " + JSONData.branding);
            sb.AppendLine("");
            sb.AppendLine("Budget: " + JSONData.budget);
            sb.AppendLine("Timeline: " + JSONData.time);

            
            
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("noreply@cooshla.com");
            mail.To.Add("info@cooshla.com");
            mail.CC.Add("stephen.shaw85@gmail.com");

            mail.Subject = "Enquiry Form From Cooshla.com";
            mail.Body = sb.ToString();

            SmtpClient smtp = new SmtpClient("relay-hosting.secureserver.net", 25);
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("info@cooshla.com", "horror1902");

            smtp.Send(mail);
        }
        
    }
}