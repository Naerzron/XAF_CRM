using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;

namespace XAF_CRMTEST.Module.BusinessObjects.Products
{
    public class Article : XPObject
    { 
        public Article(Session session)
            : base(session)
        {
        }
        #region Properties

        private double _Price;

        [XafDisplayName("Precio"), ToolTip("Precio del artículo")]
        [VisibleInListView(true)]
        public double Price
        {
            get { return _Price; }
            set { SetPropertyValue(nameof(Price), ref _Price, value); }
        }

        private double _Cost;
        [XafDisplayName("Coste"), ToolTip("Coste del producto")]
        [VisibleInListView(true)]
        public double Cost
        {
            get { return _Cost; }
            set { SetPropertyValue(nameof(Cost), ref _Cost, value); }
        }

        private int _Stock;
        [XafDisplayName("Stock"), ToolTip("Stock del producto")]
        [VisibleInListView(true)]
        public int Stock
        {
            get { return _Stock; }
            set { SetPropertyValue(nameof(Stock), ref _Stock, value); }
        }

        private bool _Visible;
        [XafDisplayName("Visible")]
        [VisibleInListView(true)]
        public bool Visible
        {
            get { return _Visible; }
            set { SetPropertyValue(nameof(Visible), ref _Visible, value); }
        }

        private string _ProductCod;
        [XafDisplayName("Código Producto")]
        [VisibleInListView(true)]
        [RuleUniqueValue("UniqueProductCod", DefaultContexts.Save, "El código del producto debe ser único.")]
        public string ProductCod
        {
            get { return _ProductCod; }
            set { SetPropertyValue(nameof(ProductCod), ref _ProductCod, value); }
        }

        #endregion

        #region Actions
        [Action(Caption = "Visible/Invisible", AutoCommit = true)]
        public void Visibility()
        {
            this.Visible = !this.Visible;
        }
        #endregion

        #region Methods
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://docs.devexpress.com/eXpressAppFramework/112834/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/initialize-a-property-after-creating-an-object-xpo?v=22.1).
        }
        #endregion

    }
}