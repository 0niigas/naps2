﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NAPS2.Update
{
    public interface IUrlTextReader
    {
        string DownloadText(string url);
    }
}
