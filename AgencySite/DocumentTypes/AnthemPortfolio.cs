
using System;
using Vega.USiteBuilder;

namespace AgencySite.DocumentTypes
{
    [DocumentType(IconUrl = "house.png", Description = "Portfolio Page", AllowAtRoot = false, DefaultTemplate = "AnthemPortfolioPage", AllowedTemplates = new string[] { "AnthemPortfolioPage" },
    AllowedChildNodeTypeOf = new Type[]
    {
        typeof(AnthemHome)
    })]
    public class AnthemPortfolio : Vega.USiteBuilder.DocumentTypeBase
    {

        [DocumentTypeProperty(UmbracoPropertyType.ContentPicker, Name = "Portfolio", Description = "Portfolio.", Tab = TabNames.Content)]
        public string Portfolio { get; set; }
    }
}