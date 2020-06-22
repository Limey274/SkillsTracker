using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.FileProviders.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace SkillsTracker.Controllers
{
    [Microsoft.AspNetCore.Components.Route("/skills")]
    public class SkillsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method= 'post' action = '/skills'>" +
                "<h1> Skills Tracker</h1>"+
            "<h2> Programming Languages</h2>"+
            "<ol>" +
            "<li>C#</li>" +
            "<li>JavaScript</li>"+
            "<li> Python</li>";
                

                return Content(html, "text/html");
        }
        [HttpGet]
         public IActionResult Form()
        {
            string html =
                "<form method = 'post' action = '/form'>" +
                "<label for = 'start'> Start Date: </label>" +
                "<input type = 'date' id = 'start' name = 'date' value = '2020-03-29' min = '2020-01-01' max = '2020-12-31'>" +
                    "<br><label for= 'C'> C#: </label>" +
                        "<select name = 'cValue'> " +
                            "<option value = ': Learning Basics' > Learning Basics </option>" +
                            "<option value = ': Doing Ok'> Doing Ok</option>" +
                            "<option value = ': Pretty Good'> Pretty Good</option> " +
                            "<option value = ': Great'> Great!</option>" +
                            "</select>" +
                   "<br><label for= 'javaScript'> JavaScript: </label>" +
                        "<select name = 'javaValue'> " +
                            "<option value = ': Learning Basics' > Learning Basics </option>" +
                            "<option value = ': Doing Ok'> Doing Ok</option>" +
                            "<option value = ': Pretty Good'> Pretty Good</option> " +
                            "<option value = ': Great'> Great!</option>" +
                            "</select>" +
                  "<br><label for= 'python'> Python: </label>" +
                        "<select name = 'pythonValue'> " +
                            "<option value = ': Learning Basics' > Learning Basics </option>" +
                            "<option value = ': Doing Ok'> Doing Ok</option>" +
                            "<option value = ': Pretty Good'> Pretty Good</option> " +
                            "<option value = ': Great'> Great!</option>" +
                            "</select>" +
                            "<input type = 'submit' value = 'Submit'/>" +
                           "</form>";


            return Content(html, "text/html");

          }
            [HttpPost("/form")]
             public IActionResult Data(string date, string cValue, string javaValue, string pythonValue)
             {
            string html =
             "<h1>" + date + "</h1>" +
             "<h2></h2>" +
             "<h2> C#" + cValue + "</h2>" +
            "<h2></h2>" +
            "<h2> JavaScript" + javaValue + "</h2>" +
            "<h2></h2>" +
            "<h2> Python" + pythonValue + "<h2>";


            return Content(html, "text/html");
        }
        
    }
    
    
}
