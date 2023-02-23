using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    public static class ParseUrl
    {

        public static void Urlparser(string url, out string protocol, out string server, out string resource)
        {
            protocol = "";
            resource = "";

            int protocolIndex = url.IndexOf("://");
            int serverIndex = url.IndexOf("/", protocolIndex + 3);

            if (protocolIndex != -1)
            {
                protocol = url.Substring(0, protocolIndex);
            }

            if (serverIndex == -1)
            {
                serverIndex = url.Length;
            }

            server = url.Substring(protocolIndex + 3, serverIndex - protocolIndex - 3);
            resource = url.Substring(serverIndex);
        }
    }
}
