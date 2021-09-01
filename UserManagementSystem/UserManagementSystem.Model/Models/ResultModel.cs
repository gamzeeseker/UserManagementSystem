using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using UserManagementSystem.Model.Enum;

namespace UserManagementSystem.Model.Models
{
    public class ResultModel
    {
        public ResultStatus Status { get; set; }
        public string Message { get; set; }
    }

    public class ResultModelGeneic<T> where T : class
    {
        public ResultStatus Status { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
}
