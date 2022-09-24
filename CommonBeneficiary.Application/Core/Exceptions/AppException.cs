using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBeneficiary.Application.Core.Exceptions
{
    public class AppException
    {
        public int StatusCode  { get; set; }
        public string Message { get; set; }
        public string Details  { get; set; }
        public void AddException(int statusCode, string Message, string Details = null)
        {
            this.StatusCode = statusCode;
            this.Message = Message;
            this.Details = Details;
        }
    }
}
