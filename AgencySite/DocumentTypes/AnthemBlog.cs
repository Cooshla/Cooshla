using System;
using Vega.USiteBuilder;

namespace AgencySite.DocumentTypes
{
    [DocumentType(IconUrl = "house.png", Description = "Blog Page", AllowAtRoot = false, DefaultTemplate = "AnthemBlogPage", AllowedTemplates = new string[] { "AnthemBlogPage" },
    AllowedChildNodeTypeOf = new Type[]
    {
        typeof(AnthemHome)
    })]
    public class AnthemBlog : Vega.USiteBuilder.DocumentTypeBase
    {

        [DocumentTypeProperty(UmbracoPropertyType.ContentPicker, Name = "Blogs", Description = "Blogs.", Tab = TabNames.Content)]
        public string Blogs { get; set; }
    }
}