﻿using CefFlashBrowser.Utils;
using System;
using System.Collections.Generic;

namespace CefFlashBrowser.Models
{
    public static class EnumDescriptions
    {
        public static IEnumerable<EnumDescription<SearchEngine>> GetSearchEngines()
        {
            yield return new EnumDescription<SearchEngine>(SearchEngine.Baidu, LanguageManager.GetString("baidu"));
            yield return new EnumDescription<SearchEngine>(SearchEngine.Google, LanguageManager.GetString("google"));
            yield return new EnumDescription<SearchEngine>(SearchEngine.Bing, LanguageManager.GetString("bing"));
            yield return new EnumDescription<SearchEngine>(SearchEngine.Sogou, LanguageManager.GetString("sogou"));
            yield return new EnumDescription<SearchEngine>(SearchEngine.So360, LanguageManager.GetString("so360"));
        }

        public static IEnumerable<EnumDescription<NavigationType>> GetNavigationTypes()
        {
            yield return new EnumDescription<NavigationType>(NavigationType.Automatic, LanguageManager.GetString("navigationType_auto"));
            yield return new EnumDescription<NavigationType>(NavigationType.SearchOnly, LanguageManager.GetString("navigationType_searchOnly"));
            yield return new EnumDescription<NavigationType>(NavigationType.NavigateOnly, LanguageManager.GetString("navigationType_navigateOnly"));
        }

        public static IEnumerable<EnumDescription<NewPageBehavior>> GetNewPageBehaviors()
        {
            yield return new EnumDescription<NewPageBehavior>(NewPageBehavior.OriginalWindow, LanguageManager.GetString("newPageBehavior_originalWindow"));
            yield return new EnumDescription<NewPageBehavior>(NewPageBehavior.NewWindow, LanguageManager.GetString("newPageBehavior_newWindow"));
        }

        public static int GetIndex<T>(IEnumerable<EnumDescription<T>> enumDescriptions, T val) where T : Enum
        {
            int index = -1;
            foreach (var desc in enumDescriptions)
            {
                ++index;
                if (desc.Value.Equals(val))
                    return index;
            }
            return -1;
        }
    }
}
