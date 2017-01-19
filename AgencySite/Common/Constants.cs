using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgencySite.Common
{

    public static class Constants
    {
        #region [NodeIDs]

        /// <summary>
        /// Contains node IDs.
        /// </summary>
        public static class NodeIDs
        {
            /// <summary>
            /// Node ID of Settings node.
            /// </summary>
            public const int SettingsNodeId = 1049;
        }

        #endregion [NodeIDs]

        #region [Default Values]

        /// <summary>
        /// Default values.
        /// </summary>
        public static class DefaultValues
        {
            public const string SiteName = "Empty Website";

            #region [UTC]

            /// <summary>
            /// UTC Date format.
            /// </summary>
            public const string UTCDateFormat = "yyyyMMdd";

            /// <summary>
            /// UTC Hours format.
            /// </summary>
            public const string UTCHourFormat = "HHmmss";

            #endregion [UTC]

        }

        #endregion [Default Values]

        public static class DocumentTypes

        {
        }

        #region [RequestParameters]

        /// <summary>
        /// Contains names of query string parameter.
        /// </summary>
        public static class RequestParameters
        {
            public const string CurrentPage = "page";
            public const string SearchTerm = "q";
        }

        #endregion [RequestParameters]

        #region [Custom Data Types]

        /// <summary>
        /// Contains custom document types names.
        /// </summary>
        public static class CustomDataTypes
        {
            #region [Common Data Types]

            public const string MediaPicker = "Media Picker";

            public const string MultipleTextbox = "Multiple Textbox";

            public const string DropdownOrientation = "Dropdown Orientation";

            public const string DropdownPeopleDetailStatus = "Dropdown People Detail Status";

            public const string ImageCropper = "Image Cropper";

            public const string MultiMediaPicker = "Multi Media Picker";

            public const string URLPicker = "URL Picker";

            public const string MultinodeTreepicker = "MultiNodeTreePicker";

            public const string DropdownWorkDimension = "Dropdown Work Dimension";

            public const string DropdownPersonDimension = "Dropdown Person Dimension";

            public const string ColorPicker = "Color Picker";

            #endregion [Common Data Types]
        }

        #endregion [Custom Data Types]

        #region [Document Type Properties]

        public static class DocumentTypeProperties
        {
            public const string Title = "title";
        }

        #endregion [Document Type Properties]

        #region [Description for Data Types]

        /// <summary>
        /// This class represents constants for description.
        /// </summary>
        public static class DescriptionDataTypes
        {
            /// <summary>
            /// Description for related links with media
            /// </summary>
            public const string DescriptionRelatedLinkWithMedia = "For image selecting use 'Add Media Link'.";
        }

        #endregion [Description for Data Types]

        #region [RegularExpression]

        /// <summary>
        /// Contains names of regular expresion parameters.
        /// </summary>
        public static class RegExpresion
        {
            /// <summary>
            /// Regular expresion for email address.
            /// </summary>
            public const string RegEmailExpresion = @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
                                                     + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				                                                [0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
                                                     + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				                                                [0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
                                                     + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";
        }

        #endregion [RegularExpression]

        #region [EmailMarkers]

        /// <summary>
        /// Contains markers from e-mail templates.
        /// </summary>
        public static class EmailMarkers
        {
        }

        #endregion [EmailMarkers]

        #region [AppSettingsKeys]

        /// <summary>
        /// Application settings keys.
        /// </summary>
        public static class AppSettingsKeys
        {
            /// <summary>
            /// AllowCaching application settings key.
            /// </summary>
            public const string AllowCaching = "AllowCaching";
        }

        #endregion [AppSettingsKeys]

        #region [Markers]

        /// <summary>
        /// Marker constants
        /// </summary>
        public static class Markers
        {
            /// <summary>
            /// Marks begining of user control html
            /// </summary>
            public const string UserControlStart = "<!-- START USERCONTROL -->";

            /// <summary>
            /// Marks end of user control html
            /// </summary>
            public const string UserControlEnd = "<!-- END USERCONTROL -->";
        }

        #endregion [Markers]

        #region [Link Target]

        /// <summary>
        /// The link target.
        /// </summary>
        public static class LinkTarget
        {
            /// <summary>
            /// The new window target.
            /// </summary>
            public const string NewWindow = "_blank";

            /// <summary>
            /// The same window target.
            /// </summary>
            public const string SameWindow = "_self";
        }

        #endregion [Link Target]

        #region[Html Attributes]

        /// <summary>
        /// Maximum number of characters in intro text on Home page for news item.
        /// </summary>
        public static class HtmlAttributes
        {
            /// <summary>
            /// Top inline style text
            /// </summary>
            public const string Top = "top";

            /// <summary>
            /// Left inline style text
            /// </summary>
            public const string Left = "left";

            /// <summary>
            /// Style text
            /// </summary>
            public const string Style = "style";

            /// <summary>
            /// Name attribute text
            /// </summary>
            public const string Name = "name";

            /// <summary>
            /// Background color text
            /// </summary>
            public const string BackgroundColor = "background-color";

            /// <summary>
            /// Color text
            /// </summary>
            public const string Color = "color";

            /// <summary>
            /// Href's text
            /// </summary>
            public const string Href = "href";

            /// <summary>
            /// Class text
            /// </summary>
            public const string Class = "class";

            // HTML 5 attributes

            /// <summary>
            /// placeholder text.
            /// </summary>
            public const string Placeholder = "placeholder";
        }

        #endregion

        #region [Cache]

        /// <summary>
        /// Cache constants.
        /// </summary>
        public static class Cache
        {
            /// <summary>
            /// Page output caching in minutes.
            /// </summary>
            public const int OutputCachingMinutes = 10;
        }

        public static class Crops
        {
            /// <summary>
            /// The work half wide
            /// </summary>
            public const string BoxHalfWide = "Box Half Wide";

            /// <summary>
            /// The work small
            /// </summary>
            public const string BoxSmall = "Box Small";

            /// <summary>
            /// The work tall
            /// </summary>
            public const string BoxTall = "Box Tall";

            /// <summary>
            /// The work2 boxes wide
            /// </summary>
            public const string Box2BoxesWide = "Box 2 Boxes Wide";

            /// <summary>
            /// The banner desktop
            /// </summary>
            public const string BannerDesktop = "Banner Desktop";

            /// <summary>
            /// The banner mobile
            /// </summary>
            public const string BannerMobile = "Banner Mobile";

            /// <summary>
            /// The news box wide
            /// </summary>
            public const string NewsBoxWide = "News Box Wide";

            /// <summary>
            /// The person small
            /// </summary>
            public const string PersonSmall = "Person Small";

            /// <summary>
            /// The person tall
            /// </summary>
            public const string PersonTall = "Person Tall";

            /// <summary>
            /// The person2 boxes wide
            /// </summary>
            public const string Person2BoxesWide = "Person 2 Boxes Wide";
        }

        /// <summary>
        /// Contains cache keys.
        /// </summary>
        public static class CacheKeys
        {
            /// <summary>
            /// Media url cache key
            /// </summary>
            public const string MediaUrl = "CACHE_MEDIA_URL_{0}";

            public const string Settings = "CACHE_SETTINGS";

            public const string NewsFeed = "NEWS_FEED";

            public const string DocumentItems = "DOCUMENT_ITEMS";

            public const string EventItems = "EVENT_ITEMS";

            public const string MagazineItems = "MAGAZINE_ITEMS";

            public const string VacancyItems = "VACANCY_ITEMS";

            public const string LocationItems = "LOCATION_ITEMS";

            public const string JobTypeItems = "JOBTYPE_ITEMS";

            public const string TwitterItems = "TwitterItems";

            public const string NewsItems = "NewsItems";

            public const string People = "People";
        }

        #endregion

        #region [Media]

        public static class Media
        {
            public static class Properties
            {
                public const string AlternateText = "alternateText";

                public const string Url = "umbracoFile";

                public const string Size = "umbracoBytes";

                public const string FileDate = "fileDate";

                public const string Description = "description";

                public const string Title = "title";

                public const string Type = "type";

                public const string Height = "umbracoHeight";

                public const string Width = "umbracoWidth";

                public const string Name = "nodeName";

                public const string Subtitle = "subtitle";

                public const string Extension = "umbracoExtension";
            }

            public static class ContentTypes
            {
                public const string Folder = "Folder";
                public const string Image = "Image";
                public const string File = "File";
            }

            public static class CropUpAliases
            {
                public const string Thumbnail = "thumbnail";
            }
        }

        #endregion

        #region [Cookies]

        public class Cookies
        {
        }

        #endregion

        #region [Search]

        /// <summary>
        /// Search providers.
        /// </summary>
        public static class Search
        {
            /// <summary>
            /// Number of letters in search results
            /// </summary>
            public const int CustomSearchResultTextLength = 300;

            /// <summary>
            /// General searcher.
            /// </summary>
            public const string GeneralSearcher = "GeneralSearcher";

            /// <summary>
            /// Folder that contains indexes.
            /// </summary>
            public const string GeneralIndex = "General";

            /// <summary>
            /// Intems per page on the Search result page
            /// </summary>
            public const int SearchItemsPerPage = 10;
        }

        #endregion

        #region [RSS]

        /// <summary>
        /// RSS specific constants.
        /// </summary>
        public static class RSS
        {
            /// <summary>
            /// Node name.
            /// </summary>
            public const string RSSFeedNodeName = "item";

            /// <summary>
            /// Title tag name.
            /// </summary>
            public const string TitleTagName = "title";

            /// <summary>
            /// Updated Tag Name.
            /// </summary>
            public const string UpdatedTagName = "updated";

            /// <summary>
            /// Published tag name.
            /// </summary>
            public const string PubDateTagName = "pubDate";

            /// <summary>
            /// Link tag name.
            /// </summary>
            public const string LinkTagName = "link";

            /// <summary>
            /// Href tag name.
            /// </summary>
            public const string HrefTagName = "href";
        }

        #endregion
    }
}