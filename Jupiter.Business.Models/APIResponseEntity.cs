using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Business.Models
{
    public class APIResponseEntity<T> where T : class
    {
        public T Object { get; set; }

        public string Message { get; set; }

        public bool Success { get; set; }

        public string ReturnToUrl { get; set; }


        public List<string> ErrorMessages = new List<string>();
    }
}
