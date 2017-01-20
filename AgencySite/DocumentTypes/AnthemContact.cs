using System;
using Vega.USiteBuilder;

namespace AgencySite.DocumentTypes
{
    [DocumentType(IconUrl = "house.png", Description = "Contact us page", AllowAtRoot = false, DefaultTemplate = "AnthemContactUs", AllowedTemplates = new string[] { "AnthemContactUs" },
    AllowedChildNodeTypeOf = new Type[]
    {
        typeof(AnthemHome)
    })]
    public class AnthemContact : Vega.USiteBuilder.DocumentTypeBase
    {
        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Heading", Description = "Heading.", Tab = TabNames.Content)]
        public string Header { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Greeting", Description = "Greeting.", Tab = TabNames.Content)]
        public string Greeting { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Address", Description = "Address.", Tab = TabNames.Content)]
        public string Address { get; set; }


        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Phone", Description = "Phone.", Tab = TabNames.Content)]
        public string Phone { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Email", Description = "Email.", Tab = TabNames.Content)]
        public string Email { get; set; }

    }
}