﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentCatalogFall2016.Models.Entity
{
    public class CompetencyHeaderModel
    {
        public int CompetencyHeaderModelId { get; set; }
        public string Name { get; set; }

        public ICollection<CompetencyModel> Competencies { get; set; }
        
    }
}