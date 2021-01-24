﻿using Ders_5_Odev_5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_5_Odev_5.Abstract
{
    public interface ISalesManager
    {
        void Buy(Player player);
        void AddCampaign(Campaign campaign);
    }
}
