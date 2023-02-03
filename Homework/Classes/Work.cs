using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQXBY9.Classes
{
    public class Work
    {
        private string? service;
        private string? expectedTime;
        private string? materialCost;
        public override string ToString()
        {
            return $"Service : {service} , Time : {expectedTime},Cost : {materialCost}";
        }

        public Work(string? service, string? expectedTime, string? materialCost)
        {
            this.service = service;
            this.expectedTime = expectedTime;
            this.materialCost = materialCost;
        }
        public string serviceName()
        {
            return service;
        }
        public string timeInMinutes()
        {
            return expectedTime;
        }
        public string materialcost()
        {
            return materialCost;
        }

        private int? timeHours
        {
            get
            {
                return int.Parse(expectedTime) / 60;
            }
        }
        private int? timeMinutes
        {
            get
            {
                return int.Parse(expectedTime) % 60;
            }
        }


    }
}
