﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.Sitefinity.Localization;

namespace Telerik.Sitefinity.Frontend.Navigation.Mvc.StringResources
{
    /// <summary>
    /// Localizable strings for the Breadcrumb widget
    /// </summary>
    [ObjectInfo(typeof(BreadcrumbResources),
        ResourceClassId = "BreadcrumbResources",
        Title = "BreadcrumbResourcesTitle",
        Description = "BreadcrumbResourcesDescription")]
    public class BreadcrumbResources : Resource
    {
        /// <summary>
        /// Full path to the current page
        /// </summary>
        [ResourceEntry("BreadcrumbShowFullPath",
            Value = "Full path to the current page",
            Description = "Full path to the current page",
            LastModified = "2015/05/4")]
        public string BreadcrumbShowFullPath
        {
            get
            {
                return this["BreadcrumbShowFullPath"];
            }
        }

        /// <summary>
        /// Path starting from a specific page...
        /// </summary>
        [ResourceEntry("BreadcrumbSelectSpecificPage",
            Value = "Path starting from a specific page...",
            Description = "Path starting from a specific page...",
            LastModified = "2015/05/4")]
        public string BreadcrumbSelectSpecificPage
        {
            get
            {
                return this["BreadcrumbSelectSpecificPage"];
            }
        }

        /// <summary>
        /// Home page link
        /// </summary>
        [ResourceEntry("BreadcrumbParentPage",
            Value = "Home page link",
            Description = "Home page link",
            LastModified = "2012/02/14")]
        public string BreadcrumbParentPage
        {
            get
            {
                return this["BreadcrumbParentPage"];
            }
        }

        /// <summary>
        /// Show current page in the end of the breadcrumb
        /// </summary>
        [ResourceEntry("BreadcrumbShowCurrentPage",
            Value = "Current page in the end of the breadcrumb",
            Description = "Current page in the end of the breadcrumb",
            LastModified = "2012/02/14")]
        public string BreadcrumbShowCurrentPage
        {
            get
            {
                return this["BreadcrumbShowCurrentPage"];
            }
        }

        /// <summary>
        /// Group pages in the breadcrumb
        /// </summary>
        [ResourceEntry("BreadcrumbShowGroupPages",
            Value = "Group pages in the breadcrumb",
            Description = "Group pages in the breadcrumb",
            LastModified = "2012/02/23")]
        public string BreadcrumbShowGroupPages
        {
            get
            {
                return this["BreadcrumbShowGroupPages"];
            }
        }

        /// <summary>
        /// Gets word : Template
        /// </summary>
        [ResourceEntry("Template",
            Value = "Template",
            Description = "word : Template",
            LastModified = "2014/05/27")]
        public string Template
        {
            get
            {
                return this["Template"];
            }
        }

        /// <summary>
        /// What to include in the breadcrumb?
        /// </summary>
        [ResourceEntry("BreadcrumbIncludeOptions",
            Value = "What to include in the breadcrumb?",
            Description = "What to include in the breadcrumb?",
            LastModified = "2012/02/14")]
        public string BreadcrumbIncludeOptions
        {
            get
            {
                return this["BreadcrumbIncludeOptions"];
            }
        }

        /// <summary>
        /// The phrase Show...
        /// </summary>
        [ResourceEntry("Show",
            Value = "Show...",
            Description = "Show...",
            LastModified = "2012/02/14")]
        public string Show
        {
            get
            {
                return this["Show"];
            }
        }

        /// <summary>
        /// Gets phrase : More options
        /// </summary>
        [ResourceEntry("MoreOptions",
            Value = "More options",
            Description = "phrase : More options",
            LastModified = "2014/05/27")]
        public string MoreOptions
        {
            get
            {
                return this["MoreOptions"];
            }
        }

        /// <summary>
        /// Gets phrase : CSS classes
        /// </summary>
        [ResourceEntry("CssClasses",
            Value = "CSS classes",
            Description = "phrase : CSS classes",
            LastModified = "2014/05/27")]
        public string CssClasses
        {
            get
            {
                return this["CssClasses"];
            }
        }

        /// <summary>
        /// Breadcrumb is visible when you are on a particular page
        /// </summary>
        [ResourceEntry("BreadcrumbOnTemplateMessage",
            Value = "Breadcrumb is visible when you are on a particular page.",
            Description = "Breadcrumb is visible when you are on a particular page.",
            LastModified = "2012/02/21")]
        public string BreadcrumbOnTemplateMessage
        {
            get
            {
                return this["BreadcrumbOnTemplateMessage"];
            }
        }

        /// <summary>
        /// Classifications
        /// </summary>
        [ResourceEntry("Classifications",
            Value = "Classifications",
            Description = "Classifications",
            LastModified = "2012/02/21")]
        public string Classifications
        {
            get
            {
                return this["Classifications"];
            }
        }

        /// <summary>
        /// ClassificationsTagCategory
        /// </summary>
        [ResourceEntry("ClassificationsTagCategory",
            Value = "e.g. Categories, Tags",
            Description = "Phrase: e.g. Categories, Tags",
            LastModified = "2012/02/21")]
        public string ClassificationsTagCategory
        {
            get
            {
                return this["ClassificationsTagCategory"];
            }
        }
    }
}
