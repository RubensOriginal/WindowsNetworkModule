using System;

namespace WifiModule
{
    public class NetworkData
    {
        private String name;
        private String password;
        private String securityType;

        public NetworkData(string name, string password, string securityType)
        {
            this.name = name;
            this.password = password;
            this.securityType = securityType;
        }

        public string Name
        {
            get => name;
            private set => name = value;
        }

        public string Password
        {
            get => password;
            private set => password = value;
        }

        public string SecurityType
        {
            get => securityType;
            private set => securityType = value;
        }
    }
}