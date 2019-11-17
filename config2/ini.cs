using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace config2
{
    class ini
    {
        private String path;
        private String serialNumber;
        private String type;
        private String newFileName;

        public ini(String path)
        {
            INIFile ini = new INIFile(this.path);
            this.serialNumber = ini.IniReadValue("Microscope", "SerialNumber");
            this.type = ini.IniReadValue("Microscope", "MicroscopeType");
            //this.newFileName = "MicroscopeConfiguration-" + this.serialNumber + ".ini";
        }
    }
}
