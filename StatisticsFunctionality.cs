﻿// Chris Lund Schober
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_under_control
{
    class StatisticsFunctionality : DataFunction
    {
        protected override void log()
        {
            base.log();
        }

        List<object> GetStatGraph()
        {
            return new List<object>();
        }
        List<object> GetProductStat()
        {
            return new List<object>();
        }
        List<object> GetSupplierStat()
        {
            return new List<object>();
        }
    }
}