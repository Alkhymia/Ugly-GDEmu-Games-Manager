﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GDEmuSdCardManager.DTO
{
    public class GameOnPc : BaseGame
    {
        public string IsInSdCard { get; set; }
        public string SdFolder { get; set; }
    }
}