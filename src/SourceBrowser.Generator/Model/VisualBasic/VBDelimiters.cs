﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceBrowser.Generator.Model.VisualBasic
{
    /// <summary>
    /// Fully qualified names do not contain enough information to differentiate
    /// between some symbols. Occasionally we must extend VB's fully qualified names
    /// to refer to certain symbols.
    /// 
    /// Examples: Local variables, parameters, static constructors etc.
    /// </summary>
    public static class VBDelimiters
    {
        public const string LOCAL_VARIABLE = "::";
        public const string PARAMETER = "::";
    }
    
}
