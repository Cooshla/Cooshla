using System;
using Vega.USiteBuilder;

namespace AgencySite.DocumentTypes
{
    [DocumentType(IconUrl = "house.png", Description = "Generic content page", AllowAtRoot = false, DefaultTemplate = "AnthemGenericContentPage", AllowedTemplates = new string[] { "AnthemGenericContentPage" },
    AllowedChildNodeTypeOf = new Type[]
    {
        typeof(AnthemHome)
    })]

    
    public class AnthemGenericContent : Vega.USiteBuilder.DocumentTypeBase
    {
        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Heading", Description = "Heading.", Tab = TabNames.Content)]
        public string Header { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.RichtextEditor, Name = "Content", Description = "Content.", Tab = TabNames.Content)]
        public string Content { get; set; }
        

    }
}