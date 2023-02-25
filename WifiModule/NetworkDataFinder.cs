using System.Collections.Generic;
using System.Diagnostics;
using System.Data;
using System;

namespace WifiModule
{
    public class NetworkDataFinder
    {
        public String GetCurrentNetworkName()
        {
            Process process = CreateProcess("wlan show interfaces");
            process.Start();

            String line;
            String ssid = null;
            
            while((line = process.StandardOutput.ReadLine()) != null)
            {
                if (line.Trim().StartsWith("SSID"))
                {
                    ssid = line.Split(':')[1].Trim();
                    break;
                }
            }

            process.WaitForExit();

            if (ssid == null)
                throw new DataException("Invalid Network");

            return ssid;
        }

        public NetworkData GetNetworkData(String ssid)
        {
            Process process = CreateProcess("wlan show profile name=\"" + ssid +"\" key=clear");

            List<String> data = ProcessToList(process);
            
            if (data.Count < 5)
                throw new DataException("Invalid Network");

            String password = data[32].Split(':')[1].Trim();
            String securityType = data[27].Split(':')[1].Trim();
                
                
            return new NetworkData(ssid, password, securityType);
        }

        private Process CreateProcess(String args)
        {
            Process process = new Process();

            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.FileName = "netsh";

            process.StartInfo.Arguments = args;

            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            
            process.Start();

            return process;
        }

        private List<String> ProcessToList(Process process)
        {
            List<String> list = new List<string>();

            string line;

            while ((line = process.StandardOutput.ReadLine()) != null)
            {
                list.Add(line);
            }
            
            return list;
        }
    }
}