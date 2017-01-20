
using System;
using Vega.USiteBuilder;

namespace AgencySite.DocumentTypes
{
    [DocumentType(IconUrl = "house.png", Description = "Portfolio Details Page", AllowAtRoot = false, DefaultTemplate = "AnthemPortfolioDetails", AllowedTemplates = new string[] { "AnthemPortfolioDetails" },
    AllowedChildNodeTypeOf = new Type[]
    {
        typeof(AnthemPortfolio)
    })]
    public class AnthemPortfolioDetails : Vega.USiteBuilder.DocumentTypeBase
    {
        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Title", Description = "Title.", Tab = TabNames.Content)]
        public string Title { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Tag", Description = "Tag.", Tab = TabNames.Content)]
        public string Tag { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Tag", Description = "Tag.", Tab = TabNames.Content)]
        public string Client { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Tag", Description = "Tag.", Tab = TabNames.Content)]
        public string Link { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.RichtextEditor, Name = "Content", Description = "Content.", Tab = TabNames.Content)]
        public string Content { get; set; }


        [DocumentTypeProperty(UmbracoPropertyType.RichtextEditor, Name = "ShortDescription", Description = "ShortDescription.", Tab = TabNames.Content)]
        public string ShortDescription { get; set; }
    }
}