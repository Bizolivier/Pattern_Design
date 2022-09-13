using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton {
    public class Logger {

        private static readonly Lazy<Logger> _lazyLogger
            = new Lazy<Logger>(() => new Logger());

        /// <summary>
        /// <see cref="Instance"/> 
        /// </summary>
        public static Logger Instance {
            get {
                return _lazyLogger.Value;
            }

        }
        protected Logger() {
        }

        public void Log(string message) {
            Console.WriteLine($"message to log {message}");
        }
    }
}
