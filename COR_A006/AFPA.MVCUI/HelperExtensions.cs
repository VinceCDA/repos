using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace System.Web.Mvc
{
    public static class HelperExtensions
    {
        public static HtmlString BeginFieldset(
             this HtmlHelper html,
             string legend = "",
             string id = "",
             string cssClass = "",
             IDictionary<string, object> htmlFieldSetAttributes = null,
            string legendCssClass="",
            IDictionary<string, object> htmlLegendAttributes = null)
        {
            string balise = string.Empty;
            TagBuilder tagFieldSet = new TagBuilder("fieldset");

            if (!string.IsNullOrEmpty(id))
            {
                tagFieldSet.GenerateId(id);
            }
            if (!string.IsNullOrEmpty(cssClass))
            {
                tagFieldSet.AddCssClass(cssClass);
            }
            if (htmlFieldSetAttributes != null)
            {
                tagFieldSet.MergeAttributes<string, object>(htmlFieldSetAttributes);
            }
            // écriture de la balise
            balise = tagFieldSet.ToString(TagRenderMode.StartTag);
            // écriture de la légende
            if (!string.IsNullOrEmpty(legend))
            {
                TagBuilder tagLegend = new TagBuilder("legend");
                if (!string.IsNullOrEmpty(legendCssClass))
                {
                    tagLegend.AddCssClass(legendCssClass);
                }
                if (htmlLegendAttributes != null)
                {
                    tagLegend.MergeAttributes<string, object>(htmlLegendAttributes);
                }
                balise += tagLegend.ToString(TagRenderMode.StartTag);
                balise += legend;
                balise += tagLegend.ToString(TagRenderMode.EndTag);

            }

            return new HtmlString(balise);
        }

        public static HtmlString EndFieldset(this HtmlHelper html)
        {
            return new HtmlString("</fieldset>");
        }

    }
}