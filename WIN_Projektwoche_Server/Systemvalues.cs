using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Management;
using System.Threading;

namespace WIN_Projektwoche
{
    class Systemvalues
    {
        PerformanceCounter CPU_Load = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        PerformanceCounter RAM_Max = new PerformanceCounter("Memory", "% Committed Bytes in Use");
        PerformanceCounter Disk_Write_Time = new PerformanceCounter("PhysicalDisk", "% Disk Write Time", "_Total");
        PerformanceCounter Disk_Read_Time = new PerformanceCounter("PhysicalDisk", "% Disk Read Time", "_Total");
        PerformanceCounter SystemUp_Time = new PerformanceCounter("System", "System Up Time");

        public string get_CPU_Load()
        {
            return Convert.ToString(Convert.ToInt32(CPU_Load.NextValue()));
        }

        public string get_Diskread_load()
        {
            return Convert.ToString(Convert.ToInt32(Disk_Read_Time.NextValue()));
        }

        public string get_Diskwrite_load()
        {
            return Convert.ToString(Convert.ToInt32(Disk_Write_Time.NextValue()));
        }

        public string get_RAM_load()
        {
            return Convert.ToString(Convert.ToInt32(RAM_Max.NextValue()));
        }

        public string get_Uptime()
        {
            double sec = SystemUp_Time.NextValue();
            string min = Convert.ToString((sec / 60) % 60);
            string stunden = Convert.ToString((sec / 60) / 60);
            String[] minspitted = min.Split(Convert.ToChar(","));
            String[] stundenspitted = stunden.Split(Convert.ToChar(","));
            return stundenspitted[0] + "h" + minspitted[0] + "min";
        }

        public string GetCPUProcessor()
        {
            int numberofprocessors = 0;

            foreach (var item in new System.Management.ManagementObjectSearcher("Select NumberOfProcessors from Win32_ComputerSystem").Get())
                numberofprocessors = int.Parse(item["NumberOfProcessors"].ToString());
                

            return Convert.ToString(numberofprocessors);

        }

        public string GetCPUMaxSpeed()
        {
            int MaxSpeed = 0;

            foreach (var item in new System.Management.ManagementObjectSearcher("Select MaxClockSpeed from Win32_Processor").Get())
                MaxSpeed = int.Parse(item["MaxClockSpeed"].ToString());


            return Convert.ToString(MaxSpeed);
        }

        public string GetCPUCores()
        {
            int Cores = 0;

            foreach (var item in new System.Management.ManagementObjectSearcher("Select NumberOfCores from Win32_Processor").Get())
                Cores = int.Parse(item["NumberOfCores"].ToString());


            return Convert.ToString(Cores);
        }

        public string GetThreads()
        {
            int Threads = 0;

            foreach (var item in new System.Management.ManagementObjectSearcher("Select NumberOfLogicalProcessors from Win32_Processor").Get())
                Threads = int.Parse(item["NumberOfLogicalProcessors"].ToString());


            return Convert.ToString(Threads);
        }

        public string GetCPUTemp()
        {
            string temperature = "";
            ManagementObjectSearcher searcher =
            new ManagementObjectSearcher("root\\WMI",
                                 "SELECT * FROM MSAcpi_ThermalZoneTemperature");

            ManagementObjectCollection collection =
                searcher.Get();

            foreach (ManagementBaseObject tempObject in collection)
            {
                double temp = Convert.ToDouble(tempObject["CurrentTemperature"]);
                temperature = Convert.ToString(Convert.ToInt32(((temp / 10) - 273.15)));
            }
            return temperature;
        }

        public void ShowNetworkTraffic()
        {
            PerformanceCounterCategory performanceCounterCategory = new PerformanceCounterCategory("Network Interface");
            string instance = performanceCounterCategory.GetInstanceNames()[0]; // 1st NIC !
            PerformanceCounter performanceCounterSent = new PerformanceCounter("Network Interface", "Bytes Sent/sec", instance);
            PerformanceCounter performanceCounterReceived = new PerformanceCounter("Network Interface", "Bytes Received/sec", instance);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("bytes sent: {0}k\tbytes received: {1}k", performanceCounterSent.NextValue() / 1024, performanceCounterReceived.NextValue() / 1024);
                Thread.Sleep(500);
            }
            
        }

    }
}
