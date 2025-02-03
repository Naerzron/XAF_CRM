using XAF_CRMTEST.Module.BusinessObjects;
using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.PermissionPolicy;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;

namespace XAF_CRMTEST.Module.BusinessObjects.Orders;

[DefaultClassOptions]
[NavigationItem("Pedidos")]
[System.ComponentModel.DisplayName("Pedidos")]
[ImageName("BO_Order")]
public class Order : XPObject
{
    public Order(Session session) : base(session) { }

    private ApplicationUser user;
    private DateTime orderDate;

    [Association("User-Orders")]
    public ApplicationUser User
    {
        get { return user; }
        set { SetPropertyValue(nameof(User), ref user, value); }
    }

    public DateTime OrderDate
    {
        get { return orderDate; }
        set { SetPropertyValue(nameof(OrderDate), ref orderDate, value); }
    }

    [Association("Order-OrderDetails")]
    public XPCollection<OrderDetail> OrderDetails
    {
        get { return GetCollection<OrderDetail>(nameof(OrderDetails)); }
    }
}
