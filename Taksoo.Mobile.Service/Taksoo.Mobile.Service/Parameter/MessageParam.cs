using System;
using System.Collections.Generic;

namespace Taksoo.Mobile.Service.Parameter
{
        public class MessageParam : EntityParamBase
        {
            public string Content { get; set; }
            public Guid? ParentId { get; set; }



            public TripParam Trip { get; set; }
        }
    }
