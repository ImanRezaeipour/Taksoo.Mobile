﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taksoo.Mobile.Service.Enum;

namespace Taksoo.ViewModel
{
    public class TripActionViewModel : EntityViewModelBase
    {
        public TripStatusType Status { get; set; }

    }
}
