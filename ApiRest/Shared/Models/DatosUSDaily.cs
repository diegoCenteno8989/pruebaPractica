﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRest.Shared.Models
{
    public class DatosUSDaily
    {
        public int? date
        {
            get; set;
        }
        public int states { get; set; }
        public int? positive { get; set; }
        public int? negative { get; set; }
        public int? pending { get; set; }
        public int? hospitalizedCurrently { get; set; }
        public int? hospitalizedCumulative { get; set; }
        public int? inIcuCurrently { get; set; }
        public int? inIcuCumulative { get; set; }
        public int? onVentilatorCurrently { get; set; }
        public int? onVentilatorCumulative { get; set; }
        public string dateChecked { get; set; }
        public int? death { get; set; }
        public int? hospitalized { get; set; }
        public int totalTestResults { get; set; }
        public string lastModified { get; set; }
        public object recovered { get; set; }
        public int total { get; set; }
        public int posNeg { get; set; }
        public int deathIncrease { get; set; }
        public int hospitalizedIncrease { get; set; }
        public int negativeIncrease { get; set; }
        public int positiveIncrease { get; set; }
        public int totalTestResultsIncrease { get; set; }
        public string hash { get; set; }
    }
}
