using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DotNetNuke.Common.Utilities;
using DotNetNuke.Data;

namespace DriversWebshop.Dnn.Dnn.DriversWebshop.HardwareScore.Controllers
{
    public class CpuController : Controller
    {
        // GET: Cpu
        public IList<Task> GetTasks(string name)
        {
            return CBO.FillCollection<Task>(DataProvider.Instance().ExecuteReader("Cpu_GetPercentage", name));
        }
    }
}