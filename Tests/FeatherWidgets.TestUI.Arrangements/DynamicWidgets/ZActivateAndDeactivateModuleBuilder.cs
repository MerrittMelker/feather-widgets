﻿using System;
using FeatherWidgets.TestUtilities.CommonOperations;
using Telerik.Sitefinity.Frontend.Navigation.Mvc.Controllers;
using Telerik.Sitefinity.Frontend.TestUtilities.CommonOperations;
using Telerik.Sitefinity.TestUI.Arrangements.Framework;
using Telerik.Sitefinity.TestUI.Arrangements.Framework.Attributes;
using Telerik.Sitefinity.TestUtilities.CommonOperations;

namespace FeatherWidgets.TestUI.Arrangements
{
    /// <summary>
    /// Test arrangements for ZActivateAndDeactivateModuleBuilder
    /// </summary>
    public class ZActivateAndDeactivateModuleBuilder : ITestArrangement
    {
        /// <summary>
        /// Server side set up.
        /// </summary>
        [ServerSetUp]
        public void SetUp()
        {
            ServerOperationsFeather.DynamicModules().EnsureModuleIsImported(ModuleName, ModuleResource);

            ServerOperationsFeather.DynamicModulePressArticle().CreatePressArticleItem(this.dynamicTitle, this.dynamicUrl);

            Guid pageId = ServerOperations.Pages().CreatePage(PageName);

            ServerOperations.News().CreatePublishedNewsItem(NewsTitleNew, NewsContentNew, NewsProvider);
            ServerOperationsFeather.Pages().AddNewsWidgetToPage(pageId);

            ServerOperationsFeather.Pages().AddContentBlockWidgetToPage(pageId, ContentBlockContent);
            FeatherServerOperations.Pages().AddMvcWidgetToPage(pageId, typeof(NavigationController).FullName, WidgetCaption, PlaceHolderId);

            ServerOperationsFeather.Pages().AddDynamicWidgetToPage(pageId, ResolveType, WidgetName, WidgetCaptionDynamicWidget);
        }

        /// <summary>
        /// Tears down.
        /// </summary>
        [ServerTearDown]
        public void TearDown()
        {
            ServerOperations.Pages().DeleteAllPages();
            ServerOperations.News().DeleteAllNews();
            ServerOperations.ModuleBuilder().DeleteAllModules(string.Empty, TransactionName);
        }

        private const string ModuleName = "Press Release";
        private const string ModuleResource = "FeatherWidgets.TestUtilities.Data.DynamicModules.PressReleaseWithCategoriesField.zip";
        private const string ResolveType = "Telerik.Sitefinity.DynamicTypes.Model.PressRelease.PressArticle";
        private const string WidgetName = "PressArticle";
        private const string WidgetCaptionDynamicWidget = "Press Articles MVC";
        private string dynamicTitle = "Angel";
        private string dynamicUrl = "AngelUrl";
        private const string PageName = "TestPage";
        private const string NewsContentNew = "News content new";
        private const string NewsTitleNew = "NewsTitleNew";
        private const string NewsProvider = "Default News";
        private const string ContentBlockContent = "Test content";
        private const string WidgetCaption = "Navigation";
        private const string PlaceHolderId = "Body";
        private const string TransactionName = "Module Installations";
    }
}
