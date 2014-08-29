﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Feather.Widgets.TestUI.Framework;
using FeatherWidgets.TestUI.TestCases;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FeatherWidgets.TestUI
{
    /// <summary>
    /// NavigationWidgetAllPagesType test class.
    /// </summary>
    [TestClass]
    public class NavigationWidgetAllPagesType_ : FeatherTestCase
    {
        /// <summary>
        /// UI test NavigationWidgetAllPagesType
        /// </summary>
        [TestMethod,
       Microsoft.VisualStudio.TestTools.UnitTesting.Owner("Feather team"),
       TestCategory(FeatherTestCategories.PagesAndContent)]
        public void NavigationWidgetAllPagesType()
        {
            BAT.Macros().NavigateTo().Pages();
            BAT.Wrappers().Backend().Pages().PagesWrapper().OpenPageZoneEditor(PageName);
            BATFeather.Wrappers().Backend().Pages().PageZoneEditorWrapper().AddWidget(WidgetName);
            BAT.Wrappers().Backend().Pages().PageZoneEditorWrapper().PublishPage();
            this.VerifyNavigationOnTheFrontend();
        }

        /// <summary>
        /// Verify navigation widget on the frontend
        /// </summary>
        public void VerifyNavigationOnTheFrontend()
        {
            string[] parentPages = new string[] 
                                    { 
                                        PageName, Page2Redirect, Page1Redirect, PageGroup
                                    };
            string[] childPages = new string[] 
                                    { 
                                        ChildPage1, ChildPage2, UnpublishPage, PageDraft, Page2Group
                                    };

            BAT.Macros().NavigateTo().CustomPage("~/" + PageName.ToLower());
            ActiveBrowser.WaitUntilReady();

            BAT.Wrappers().Frontend().Navigation().NavigationFrontendWrapper().VerifyPagesNotPresentFrontEndNavigation(NavTemplateClass, childPages);
            BATFeather.Wrappers().Frontend().Navigation().NavigationWrapper().VerifyNavigationOnThePageFrontend(NavTemplateClass, parentPages);
        }

        /// <summary>
        /// Performs Server Setup and prepare the system with needed data.
        /// </summary>
        protected override void ServerSetup()
        {
            BAT.Macros().User().EnsureAdminLoggedIn();
            BAT.Arrange(this.TestName).ExecuteSetUp();
        }

        /// <summary>
        /// Performs clean up and clears all data created by the test.
        /// </summary>
        protected override void ServerCleanup()
        {
            BAT.Arrange(this.TestName).ExecuteTearDown();
        }

        private const string WidgetName = "Navigation";
        private const string NavTemplateClass = "nav navbar-nav";
        private const string PageName = "ParentPage";
        private const string ChildPage1 = "ChildPage1";
        private const string ChildPage2 = "ChildPage2";
        private const string Page2Redirect = "Page2Redirect";
        private const string Page1Redirect = "Page1Redirect";
        private const string UnpublishPage = "UnpublishPage";
        private const string PageDraft = "PageDraft";
        private const string Page2Group = "Page2Group";
        private const string PageGroup = "PageGroup";
    }
}