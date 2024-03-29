using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace NEAproject.Models
{
    public class homemodel
    {
        public string selectcomplexity
        {
            get;
            set;
        }

        public int valueofn
        {
            get;
            set;
        }

        public static List<SelectListItem> getcomplexity()
        {
            List<SelectListItem> result = new List<SelectListItem>();
            result.Add(new SelectListItem{ Text = "O(n)", Value = "getLineardatapoints"});
            result.Add(new SelectListItem{ Text = "O(n^2)", Value = "getNtothe2points"});
            result.Add(new SelectListItem{ Text = "O(2^n)", Value = "get2totheNpoints"});
           
            return result;
        }
    }
}