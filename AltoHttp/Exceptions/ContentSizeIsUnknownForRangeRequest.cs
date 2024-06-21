﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltoHttp.Exceptions
{
    public class ContentSizeIsUnknownForRangeRequest :Exception
    {
        
        public ContentSizeIsUnknownForRangeRequest(string msg) : base(msg)
        {

        }

    }
}
