using System;
using Vega.USiteBuilder;
namespace AgencySite.DocumentTypes
{
    [DocumentType(IconUrl = "house.png", Description = "Blog Details Page", AllowAtRoot = false, DefaultTemplate = "AnthemBlogPage", AllowedTemplates = new string[] { "AnthemBlogPage" },
    AllowedChildNodeTypeOf = new Type[]
    {
        typeof(AnthemBlog)
    })]
    public class AnthemBlogDetails : Vega.USiteBuilder.DocumentTypeBase
    {
        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Title", Description = "Title.", Tab = TabNames.Content)]
        public string Title { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Tag", Description = "Tag.", Tab = TabNames.Content)]
        public string Tag { get; set; }


        [DocumentTypeProperty(UmbracoPropertyType.RichtextEditor, Name = "Content", Description = "Content.", Tab = TabNames.Content)]
        public string Content { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.RichtextEditor, Name = "ShortDescription", Description = "ShortDescription.", Tab = TabNames.Content)]
        public string ShortDescription { get; set; }
    }
}