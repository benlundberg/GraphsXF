﻿using GraphsXF.Core;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace GraphsXF
{
    public class TranslateHelper : ITranslateHelper
    {
        public TranslateHelper(ILocalizeHelper localizeHelper)
        {
            ci = localizeHelper.GetCurrentCultureInfo();
        }

        public string Translate(string key)
        {
            ResourceManager rm = new ResourceManager("GraphsXF.Resources.Strings", typeof(TranslateHelper).GetTypeInfo().Assembly);

            string result = rm.GetString(key, ci);

            if (result == null)
            {
                Debug.WriteLine("Translation Error: Could not find translation for key '" + key + "'");
                result = key;
            }

            return result;
        }

        private CultureInfo ci;
    }
}
