﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRest.Shared.Models
{
    public class DatosStatesDaily
    {
        public int date { get; set; }
        public string state { get; set; }
        public int? positive { get; set; }
        public int? probableCases { get; set; }
        public int? negative { get; set; }
        public int? pending { get; set; }
        public string? totalTestResultsSource { get; set; }
        public int? totalTestResults { get; set; }
        public int? hospitalizedCurrently { get; set; }
        public int? hospitalizedCumulative { get; set; }
        public object inIcuCurrently { get; set; }
        public object inIcuCumulative { get; set; }
        public int? onVentilatorCurrently { get; set; }
        public int? onVentilatorCumulative { get; set; }
        public object recovered { get; set; }
        public string lastUpdateEt { get; set; }
        public string dateModified { get; set; }
        public string checkTimeEt { get; set; }
        public int? death { get; set; }
        public int? hospitalized { get; set; }
        public object hospitalizedDischarged { get; set; }
        public string dateChecked { get; set; }
        public int? totalTestsViral { get; set; }
        public int? positiveTestsViral { get; set; }
        public int? negativeTestsViral { get; set; }
        public int? positiveCasesViral { get; set; }
        public object deathConfirmed { get; set; }
        public object deathProbable { get; set; }
        public int? totalTestEncountersViral { get; set; }
        public int? totalTestsPeopleViral { get; set; }
        public int? totalTestsAntibody { get; set; }
        public int? positiveTestsAntibody { get; set; }
        public int? negativeTestsAntibody { get; set; }
        public int? totalTestsPeopleAntibody { get; set; }
        public int? positiveTestsPeopleAntibody { get; set; }
        public int? negativeTestsPeopleAntibody { get; set; }
        public int? totalTestsPeopleAntigen { get; set; }
        public int? positiveTestsPeopleAntigen { get; set; }
        public int? totalTestsAntigen { get; set; }
        public int? positiveTestsAntigen { get; set; }
        public string fips { get; set; }
        public int positiveIncrease { get; set; }
        public int negativeIncrease { get; set; }
        public int total { get; set; }
        public int totalTestResultsIncrease { get; set; }
        public int posNeg { get; set; }
        public object dataQualityGrade { get; set; }
        public int deathIncrease { get; set; }
        public int hospitalizedIncrease { get; set; }
        public string hash { get; set; }
        public int commercialScore { get; set; }
        public int negativeRegularScore { get; set; }
        public int negativeScore { get; set; }
        public int positiveScore { get; set; }
        public int score { get; set; }
        public string grade { get; set; }
    }
}
