using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBeneficiary.Application.Core.Responses
{
    public class BaseResponse<T>
    {
        public long Id { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public List<String> Errors { get; set; } = new List<string>();
        public T Value { get; set; }
        public static BaseResponse<T> Success(string message = "", List<string> errors = null , T value = default(T))
        {
            BaseResponse<T> response = new BaseResponse<T>();
            response.IsSuccess = true;
            response.Message = message;
            response.Errors = errors;
            response.Value = value;
            return response;
        }

        public static BaseResponse<T> Failure(string message = "", List<string> errors = null, T value = default(T))
        {
            BaseResponse<T> response = new BaseResponse<T>();
            response.IsSuccess = false;
            response.Message = message;
            response.Errors = errors;
            response.Value = value;
            return response;
        }
    }
}
