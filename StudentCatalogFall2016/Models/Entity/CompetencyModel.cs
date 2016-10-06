using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentCatalogFall2016.Models.Entity
{
    public class CompetencyModel
    {
        public int CompetencyModelId { get; set; }
        public string Name { get; set; }

        public int CompetencyHeaderModelId { get; set; }
        public CompetencyHeaderModel CompetencyHeader { get; set; }
    }
}