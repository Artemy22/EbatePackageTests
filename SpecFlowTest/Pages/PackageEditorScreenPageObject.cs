using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowTest
{
    class PackageEditorScreenPageObject
    {
        private IWebDriver _webDriver;

        public readonly By _BreadCrumbsHomeBtn = By.XPath("//*[@id=\"linkHome\"]");
        public readonly By _BreadCrumbPackageBtn = By.XPath("//*[@id=\"linkPackage\"]");
        public readonly By _editPackageBtn = By.XPath("/html/body/app-home/div/div/div[2]/app-package/app-package-detail/section[2]/div/div/div/div[1]/div/button");
        public readonly By _tabsAgreements = By.XPath("//*[@id=\"k - tabstrip - tab - 0\"]");
        public readonly By _tabsCriteria = By.XPath("//*[@id=\"k - tabstrip - tab - 1\"]");
        public readonly By _tabsDocuments = By.XPath("//*[@id=\"k - tabstrip - tab - 2\"]");
        public readonly By _tabsNotes = By.XPath("//*[@id=\"k - tabstrip - tab - 3\"]");
        public readonly By _tabsAudit = By.XPath("//*[@id=\"k - tabstrip - tab - 4\"]");
        public readonly By _tabsAgreementsSearchInput = By.XPath("//*[@id=\"filterText\"]");
        public readonly By _tabsAgreementsAddNewBtn = By.XPath("//*[@id=\"addPackage\"]");
        public readonly By _tabsAgreementsChooseFirstRow = By.XPath("//*[@id=\"gridAgreement\"]/div/div[2]/kendo-grid/div/kendo-grid-list/div/div[1]/table/tbody/tr[1]/td[2]/label");
        public readonly By _tabsAgreementsOrderById = By.XPath("//*[@id=\"gridAgreement\"]/div/div[2]/kendo-grid/div/div/div/table/thead/tr/th[3]/a");
        public readonly By _tabsAgreementsOpenRebatesDropDownOfFirstRow = By.XPath("//*[@id=\"gridAgreement\"]/div/div[2]/kendo-grid/div/kendo-grid-list/div/div[1]/table/tbody/tr[1]/td[1]/a");
        public readonly By _tabsAgreementsRebatesDropDownOfFirstRowChooseFirstRebate = By.XPath("//*[@id=\"gridAgreement\"]/div/div[2]/kendo-grid/div/kendo-grid-list/div/div[1]/table/tbody/tr[2]/td[2]/kendo-grid/div/kendo-grid-list/div/div[1]/table/tbody/tr[1]/td[1]/label");
        public readonly By _tabsAgreementsActionEdit = By.XPath("//*[@id=\"gridAgreement\"]/div/div[2]/div/div[2]");
        public readonly By _tabsAgreementsActionView = By.XPath("//*[@id=\"gridAgreement\"]/div/div[2]/div/div[3]");
        public readonly By _tabsAgreementsActionCopy = By.XPath("//*[@id=\"gridAgreement\"]/div/div[2]/div/div[4]");
        public readonly By _tabsAgreementsActionDelete = By.XPath("//*[@id=\"gridAgreement\"]/div/div[2]/div/div[5]");
        public readonly By _tabsCriteriaCompany = By.XPath("//*[@id=\"k - tabstrip - tabpanel - 1\"]/app-criteria-component/div/div/div/div[2]/app-criteria-item/kendo-treeview/ul/li[1]/div/span");
        public readonly By _tabsCriteriaProduct = By.XPath("//*[@id=\"k - tabstrip - tabpanel - 1\"]/app-criteria-component/div/div/div/div[2]/app-criteria-item/kendo-treeview/ul/li[2]/div/span");
        public readonly By _tabsCriteriaPrject = By.XPath("//*[@id=\"k - tabstrip - tabpanel - 1\"]/app-criteria-component/div/div/div/div[2]/app-criteria-item/kendo-treeview/ul/li[3]/div/span");
        public readonly By _tabsCriteriaAddNewBtnPlusSign = By.XPath("//*[@id=\"btnNew\"]");
        public readonly By _tabsCriteriaDeleteBtn = By.XPath("//*[@id=\"btnDelete\"]");
        public readonly By _tabsDocumentsGenerateTradeAgreementBtn = By.XPath("//*[@id=\"gridAgreementFiles\"]/div/div[2]/div/div[2]");
        public readonly By _tabsDocumentsUploadtNewDocumentBtn = By.XPath("//*[@id=\"action0\"]");
        public readonly By _tabsDocumentsDeleteDocumentBtn = By.XPath("//*[@id=\"action32\"]");
        public readonly By _tabsNotesAddNewNoteBtn = By.XPath("//*[@id=\"action0\"]");


        public PackageEditorScreenPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public PackageEditorScreenPageObject ClickBreadCrumbsHomeBtn()
        {         
            _webDriver.FindElement(_BreadCrumbsHomeBtn).Click();
            return new PackageEditorScreenPageObject(_webDriver);
        }
        public PackageEditorScreenPageObject ClickBreadCrumbPackageBtn()
        {
            _webDriver.FindElement(_BreadCrumbPackageBtn).Click();
            return new PackageEditorScreenPageObject(_webDriver);
        }
        public PackageEditorScreenPageObject ClickEditPackageBtn()
        {
            _webDriver.FindElement(_editPackageBtn).Click();
            return new PackageEditorScreenPageObject(_webDriver);
        }
        public PackageEditorScreenPageObject ClickTabsAgreements()
        {
            _webDriver.FindElement(_tabsAgreements).Click();
            return new PackageEditorScreenPageObject(_webDriver);
        }
        public PackageEditorScreenPageObject ClickTabsAgreementsSearchInput()
        {
            _webDriver.FindElement(_tabsAgreementsSearchInput).Click();
            return new PackageEditorScreenPageObject(_webDriver);
        }
        public PackageEditorScreenPageObject ClickTabsAgreementsAddNewBtn()
        {
            _webDriver.FindElement(_tabsAgreementsAddNewBtn).Click();
            return new PackageEditorScreenPageObject(_webDriver);
        }
        public PackageEditorScreenPageObject ClickTabsAgreementsChooseFirstRow()
        {
            _webDriver.FindElement(_tabsAgreementsChooseFirstRow).Click();
            return new PackageEditorScreenPageObject(_webDriver);
        }
        public PackageEditorScreenPageObject ClickTabsAgreementsOrderById()
        {
            _webDriver.FindElement(_tabsAgreementsOrderById).Click();
            return new PackageEditorScreenPageObject(_webDriver);
        }
        public PackageEditorScreenPageObject ClickTabsAgreementsOpenRebatesDropDownOfFirstRow()
        {
            _webDriver.FindElement(_tabsAgreementsOpenRebatesDropDownOfFirstRow).Click();
            return new PackageEditorScreenPageObject(_webDriver);
        }
        public PackageEditorScreenPageObject ClickTabsAgreementsRebatesDropDownOfFirstRowChooseFirstRebate()
        {
            _webDriver.FindElement(_tabsAgreementsRebatesDropDownOfFirstRowChooseFirstRebate).Click();
            return new PackageEditorScreenPageObject(_webDriver);
        }
        public PackageEditorScreenPageObject ClickTabsAgreementsActionEdit()
        {
            _webDriver.FindElement(_tabsAgreementsActionEdit).Click();
            return new PackageEditorScreenPageObject(_webDriver);
        }
        public PackageEditorScreenPageObject ClickTabsAgreementsActionView()
        {
            _webDriver.FindElement(_tabsAgreementsActionView).Click();
            return new PackageEditorScreenPageObject(_webDriver);
        }
        public PackageEditorScreenPageObject ClickTabsAgreementsActionCopy()
        {
            _webDriver.FindElement(_tabsAgreementsActionCopy).Click();
            return new PackageEditorScreenPageObject(_webDriver);
        }
        public PackageEditorScreenPageObject ClickTabsAgreementsActionDelete()
        {
            _webDriver.FindElement(_tabsAgreementsActionDelete).Click();
            return new PackageEditorScreenPageObject(_webDriver);
        }
        public PackageEditorScreenPageObject ClickTabsCriteria()
        {
            _webDriver.FindElement(_tabsCriteria).Click();
            return new PackageEditorScreenPageObject(_webDriver);
        }
        public PackageEditorScreenPageObject ClickTabsCriteriaCompany()
        {
            _webDriver.FindElement(_tabsCriteriaCompany).Click();
            return new PackageEditorScreenPageObject(_webDriver);
        }
        public PackageEditorScreenPageObject ClickTabsCriteriaProduct()
        {
            _webDriver.FindElement(_tabsCriteriaProduct).Click();
            return new PackageEditorScreenPageObject(_webDriver);
        }
        public PackageEditorScreenPageObject ClickTabsCriteriaPrject()
        {
            _webDriver.FindElement(_tabsCriteriaPrject).Click();
            return new PackageEditorScreenPageObject(_webDriver);
        }
        public PackageEditorScreenPageObject ClickTabsCriteriaAddNewBtnPlusSign()
        {
            _webDriver.FindElement(_tabsCriteriaAddNewBtnPlusSign).Click();
            return new PackageEditorScreenPageObject(_webDriver);
        }
        public PackageEditorScreenPageObject ClickTabsCriteriaDeleteBtn()
        {
            _webDriver.FindElement(_tabsCriteriaDeleteBtn).Click();
            return new PackageEditorScreenPageObject(_webDriver);
        }
        public PackageEditorScreenPageObject ClickTabsDocuments()
        {
            _webDriver.FindElement(_tabsDocuments).Click();
            return new PackageEditorScreenPageObject(_webDriver);
        }
        public PackageEditorScreenPageObject ClickTabsDocumentsGenerateTradeAgreementBtns()
        {
            _webDriver.FindElement(_tabsDocumentsGenerateTradeAgreementBtn).Click();
            return new PackageEditorScreenPageObject(_webDriver);
        }
        public PackageEditorScreenPageObject ClickTabsDocumentsUploadtNewDocumentBtn()
        {
            _webDriver.FindElement(_tabsDocumentsUploadtNewDocumentBtn).Click();
            return new PackageEditorScreenPageObject(_webDriver);
        }
        public PackageEditorScreenPageObject ClickTabsDocumentsDeleteDocumentBtn()
        {
            _webDriver.FindElement(_tabsDocumentsDeleteDocumentBtn).Click();
            return new PackageEditorScreenPageObject(_webDriver);
        }
        public PackageEditorScreenPageObject ClickTabsNotes()
        {
            _webDriver.FindElement(_tabsNotes).Click();
            return new PackageEditorScreenPageObject(_webDriver);
        }
        public PackageEditorScreenPageObject ClickTabsAudit()
        {
            _webDriver.FindElement(_tabsAudit).Click();
            return new PackageEditorScreenPageObject(_webDriver);
        }
        public PackageEditorScreenPageObject ClickTabsNotesAddNewNoteBtn()
        {
            _webDriver.FindElement(_tabsNotesAddNewNoteBtn).Click();
            return new PackageEditorScreenPageObject(_webDriver);
        }
    }

}
