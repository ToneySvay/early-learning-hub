﻿using System;
using System.Collections.Generic;

namespace EarlyLearningHub.Models
{
    public partial class Option
    {
        public Option()
        {
            ProviderLevel = new HashSet<ProviderLevel>();
        }

        public int OptId { get; set; }
        public string OptValue { get; set; }

        public ICollection<ProviderLevel> ProviderLevel { get; set; }
    }
}
