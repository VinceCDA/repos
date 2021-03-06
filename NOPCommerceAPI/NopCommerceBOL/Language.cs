using System;
using System.Collections.Generic;

#nullable disable

namespace NopCommerceBOL
{
    public partial class Language
    {
        public Language()
        {
            LocaleStringResources = new HashSet<LocaleStringResource>();
            LocalizedProperties = new HashSet<LocalizedProperty>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LanguageCulture { get; set; }
        public string UniqueSeoCode { get; set; }
        public string FlagImageFileName { get; set; }
        public bool Rtl { get; set; }
        public bool LimitedToStores { get; set; }
        public int DefaultCurrencyId { get; set; }
        public bool Published { get; set; }
        public int DisplayOrder { get; set; }

        public virtual ICollection<LocaleStringResource> LocaleStringResources { get; set; }
        public virtual ICollection<LocalizedProperty> LocalizedProperties { get; set; }
    }
}
