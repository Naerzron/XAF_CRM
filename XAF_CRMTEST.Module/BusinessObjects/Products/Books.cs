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
using XAF_CRMTEST.Module.BusinessObjects.Orders;

namespace XAF_CRMTEST.Module.BusinessObjects.Products
{
    [DefaultClassOptions]
    [NavigationItem("Artículos")]
    [System.ComponentModel.DisplayName("Libros")]
    [ImageName("BO_Product")]
    
    public class Books : Article
    { 
        public Books(Session session)
            : base(session)
        {
        }

        #region Book's Properties

        private string _BookTitle;

        [XafDisplayName("Título"), ToolTip("Título del libro")]
        public string BookTitle
        {
            get { return _BookTitle; }
            set { SetPropertyValue(nameof(BookTitle), ref _BookTitle, value); }
        }

        private string _Sinopsys;

        [XafDisplayName("Sinopsis"), ToolTip("Sinopsis del libro")]
        [VisibleInListView(false)]
        [Size(500)]
        public string Sinopsys
        {
            get { return _Sinopsys; }
            set { SetPropertyValue(nameof(Sinopsys), ref _Sinopsys, value); }
        }

        private string _Author;
        [XafDisplayName("Autor"), ToolTip("Autor del libro")]
        public string Author
        {
            get { return _Author; }
            set { SetPropertyValue(nameof(Author), ref _Author, value); }
        }

        private string _Publisher;
        [XafDisplayName("Editorial"), ToolTip("Editorial del libro")]
        public string Publisher
        {
            get { return _Publisher; }
            set { SetPropertyValue(nameof(Publisher), ref _Publisher, value); }
        }

        #endregion

        #region Methods
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://docs.devexpress.com/eXpressAppFramework/112834/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/initialize-a-property-after-creating-an-object-xpo?v=22.1).
        }
        #endregion

        #region Associations
        [Association("Book-OrderDetails")]
        public XPCollection<OrderDetail> OrderDetails
        {
            get { return GetCollection<OrderDetail>(nameof(OrderDetails)); }
        }
        #endregion
    }
}