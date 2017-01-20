using System.Collections.Generic;
using Vega.USiteBuilder;

namespace AgencySite.DocumentTypes
{
    [DocumentType(IconUrl = "house.png", Description = "Home page document type.", AllowAtRoot = true, DefaultTemplate ="AnthemHomePage", AllowedTemplates = new string[] { "AnthemHomePage" })]
    public class AnthemHome : Vega.USiteBuilder.DocumentTypeBase
    {
        public AnthemHome() 
        {
        }


        [DocumentTypeProperty(UmbracoPropertyType.MediaPicker,  Name = "Slide 1",  Description = "Slide 1.", Tab = TabNames.Content)]
        public int? Slide1 { get; set; }
        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Slide 1 Heading", Description = "Slide 1 Heading.", Tab = TabNames.Content)]
        public string Slide1Heading { get; set; }
        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Slide 1 Subheading", Description = "Slide 1 Subheading.", Tab = TabNames.Content)]
        public string Slide1Subheading { get; set; }




        [DocumentTypeProperty(UmbracoPropertyType.MediaPicker, Name = "Slide 2", Description = "Slide 2.", Tab = TabNames.Content)]
        public string Slide2 { get; set; }
        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Slide 2 Heading", Description = "Slide 2 Heading.", Tab = TabNames.Content)]
        public string Slide2Heading { get; set; }
        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Slide 2 Subheading", Description = "Slide 2 Subheading.", Tab = TabNames.Content)]
        public string Slide2Subheading { get; set; }


        [DocumentTypeProperty(UmbracoPropertyType.MediaPicker, Name = "Slide 3", Description = "Slide 3.", Tab = TabNames.Content)]
        public string Slide3 { get; set; }
        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Slide 3 Heading", Description = "Slide 3Heading.", Tab = TabNames.Content)]
        public string Slide3Heading { get; set; }
        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Slide 3 Subheading", Description = "Slide 3 Subheading.", Tab = TabNames.Content)]
        public string Slide3Subheading { get; set; }



        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Section 2 Header", Description = "Section 2 Header.", Tab = TabNames.Content)]
        public string section2Header { get; set; }
        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Section 2 Subheading", Description = "Section 2 Subheading.", Tab = TabNames.Content)]
        public string section2Subheader { get; set; }
        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Section 2 Description", Description = "Section 2 Description.", Tab = TabNames.Content)]
        public string section2Description { get; set; }

        
        [DocumentTypeProperty(UmbracoPropertyType.MediaPicker,
                      Name = "Projects",
                      Description = "Projects.",
                      Tab = TabNames.Content)]
        public List<int> projects { get; set; }



        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Section 2 Folio Text", Description = "Section 2 Folio Text.", Tab = TabNames.Content)]
        public string section2FolioText { get; set; }



        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Service 1 Header", Description = "Service 1 Header.", Tab = TabNames.Content)]
        public string Service1Header { get; set; }
        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Service 1 Content", Description = "Service 1 Content.", Tab = TabNames.Content)]
        public string Service1Content { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Service 2 Header", Description = "Service 2 Header.", Tab = TabNames.Content)]
        public string Service2Header { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Service 2 Content", Description = "Service 2 Content.", Tab = TabNames.Content)]
        public string Service2Content { get; set; }

        

        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Service 3 Header", Description = "Service 3 Header.", Tab = TabNames.Content)]
        public string Service3Header { get; set; }
        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Service 3 Content", Description = "Service 3 Content.", Tab = TabNames.Content)]
        public string Service3Content { get; set; }




        [DocumentTypeProperty(UmbracoPropertyType.MediaPicker,
                      Name = "Blog posts",
                      Description = "Blog posts.",
                      Tab = TabNames.Content)]
        public List<int> blogPosts { get; set; }
    }
}