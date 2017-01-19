//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.2.93
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

[assembly: PureLiveAssembly, System.Reflection.AssemblyVersion("0.0.0.1")]

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>AnthemHome</summary>
	[PublishedContentModel("AnthemHome")]
	public partial class AnthemHome : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "AnthemHome";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public AnthemHome(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<AnthemHome, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Blog posts: Blog posts.
		///</summary>
		[ImplementPropertyType("blogPosts")]
		public object BlogPosts
		{
			get { return this.GetPropertyValue("blogPosts"); }
		}

		///<summary>
		/// Projects: Projects.
		///</summary>
		[ImplementPropertyType("projects")]
		public object Projects
		{
			get { return this.GetPropertyValue("projects"); }
		}

		///<summary>
		/// Section 2 Description: Section 2 Description.
		///</summary>
		[ImplementPropertyType("section2Description")]
		public string Section2Description
		{
			get { return this.GetPropertyValue<string>("section2Description"); }
		}

		///<summary>
		/// Section 2 Folio Text: Section 2 Folio Text.
		///</summary>
		[ImplementPropertyType("section2FolioText")]
		public string Section2FolioText
		{
			get { return this.GetPropertyValue<string>("section2FolioText"); }
		}

		///<summary>
		/// Section 2 Header: Section 2 Header.
		///</summary>
		[ImplementPropertyType("section2Header")]
		public string Section2Header
		{
			get { return this.GetPropertyValue<string>("section2Header"); }
		}

		///<summary>
		/// Section 2 Subheading: Section 2 Subheading.
		///</summary>
		[ImplementPropertyType("section2Subheader")]
		public string Section2Subheader
		{
			get { return this.GetPropertyValue<string>("section2Subheader"); }
		}

		///<summary>
		/// Service 1 Content: Service 1 Content.
		///</summary>
		[ImplementPropertyType("service1Content")]
		public string Service1Content
		{
			get { return this.GetPropertyValue<string>("service1Content"); }
		}

		///<summary>
		/// Service 1 Header: Service 1 Header.
		///</summary>
		[ImplementPropertyType("service1Header")]
		public string Service1Header
		{
			get { return this.GetPropertyValue<string>("service1Header"); }
		}

		///<summary>
		/// Service 2 Content: Service 2 Content.
		///</summary>
		[ImplementPropertyType("service2Content")]
		public string Service2Content
		{
			get { return this.GetPropertyValue<string>("service2Content"); }
		}

		///<summary>
		/// Service 2 Header: Service 2 Header.
		///</summary>
		[ImplementPropertyType("service2Header")]
		public string Service2Header
		{
			get { return this.GetPropertyValue<string>("service2Header"); }
		}

		///<summary>
		/// Service 3 Content: Service 3 Content.
		///</summary>
		[ImplementPropertyType("service3Content")]
		public string Service3Content
		{
			get { return this.GetPropertyValue<string>("service3Content"); }
		}

		///<summary>
		/// Service 3 Header: Service 3 Header.
		///</summary>
		[ImplementPropertyType("service3Header")]
		public string Service3Header
		{
			get { return this.GetPropertyValue<string>("service3Header"); }
		}

		///<summary>
		/// Slide 1: Slide 1.
		///</summary>
		[ImplementPropertyType("slide1")]
		public object Slide1
		{
			get { return this.GetPropertyValue("slide1"); }
		}

		///<summary>
		/// Slide 1 Heading: Slide 1 Heading.
		///</summary>
		[ImplementPropertyType("slide1Heading")]
		public string Slide1Heading
		{
			get { return this.GetPropertyValue<string>("slide1Heading"); }
		}

		///<summary>
		/// Slide 1 Subheading: Slide 1 Subheading.
		///</summary>
		[ImplementPropertyType("slide1Subheading")]
		public string Slide1Subheading
		{
			get { return this.GetPropertyValue<string>("slide1Subheading"); }
		}

		///<summary>
		/// Slide 2: Slide 2.
		///</summary>
		[ImplementPropertyType("slide2")]
		public object Slide2
		{
			get { return this.GetPropertyValue("slide2"); }
		}

		///<summary>
		/// Slide 2 Heading: Slide 2 Heading.
		///</summary>
		[ImplementPropertyType("slide2Heading")]
		public string Slide2Heading
		{
			get { return this.GetPropertyValue<string>("slide2Heading"); }
		}

		///<summary>
		/// Slide 2 Subheading: Slide 2 Subheading.
		///</summary>
		[ImplementPropertyType("slide2Subheading")]
		public string Slide2Subheading
		{
			get { return this.GetPropertyValue<string>("slide2Subheading"); }
		}

		///<summary>
		/// Slide 3: Slide 3.
		///</summary>
		[ImplementPropertyType("slide3")]
		public object Slide3
		{
			get { return this.GetPropertyValue("slide3"); }
		}

		///<summary>
		/// Slide 3 Heading: Slide 3Heading.
		///</summary>
		[ImplementPropertyType("slide3Heading")]
		public string Slide3Heading
		{
			get { return this.GetPropertyValue<string>("slide3Heading"); }
		}

		///<summary>
		/// Slide 3 Subheading: Slide 3 Subheading.
		///</summary>
		[ImplementPropertyType("slide3Subheading")]
		public string Slide3Subheading
		{
			get { return this.GetPropertyValue<string>("slide3Subheading"); }
		}
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public object UmbracoFile
		{
			get { return this.GetPropertyValue("umbracoFile"); }
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}
