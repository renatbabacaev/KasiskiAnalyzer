﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasiskiAnalyzer
{
    public partial class TextHandler
    {
        public void SetDecodedText()
        {
            decodedText = DecodeCrypted();
        }
    }
}
