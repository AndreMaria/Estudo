﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TutorialAPIEntity.Core.Model
{
    public class Labels
    {
        public long Id { get; set; }
        public String Title { get; set; }
        public long IdSubjectMatter { get; set; }
        public SubjectMatters SubjectMatter { get; set; }
    }
}