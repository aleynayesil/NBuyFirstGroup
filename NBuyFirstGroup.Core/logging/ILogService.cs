using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBuyFirstGroup.Core.logging
{
    public static class LogLevels
    {
        public const string Error = "Error";
        public const string Information = "Info";
        public const string Warning = "Warning";
        public const string Success = "Success";
    }
    //yapılan işlemlere ait kayıtları izleyebilmek için bu servisin log metodunu kullanacağız mesaj ve loglama kritikli seviyesi
    public interface ILogService
    {
        void Log(string message, string logLevel);
    }
}
