using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IGSDeveloperTest.Datamodel;

namespace IGSDeveloperTest.Models
{
    public class AdministrationViewModels
    {
        public AdministrationViewModels()
        {
            this.CompanyList = new List<Company>();
            this.GenderList = new List<Gender>();
            this.TitleList = new List<Title>();
        }

        public List<Company> CompanyList { get; set; }
        public List<Gender> GenderList { get; set; }
        public List<Title> TitleList { get; set; }
    }
}