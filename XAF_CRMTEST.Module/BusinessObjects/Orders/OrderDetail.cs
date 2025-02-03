using XAF_CRMTEST.Module.BusinessObjects.Products;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;

namespace XAF_CRMTEST.Module.BusinessObjects.Orders;
public class OrderDetail : XPObject
{
    public OrderDetail(Session session) : base(session) { }

    private Order order;
    private Books book;
    private int quantity;

    [Association("Order-OrderDetails")]
    public Order Order
    {
        get { return order; }
        set { SetPropertyValue(nameof(Order), ref order, value); }
    }

    [Association("Book-OrderDetails")]
    public Books Book
    {
        get { return book; }
        set { SetPropertyValue(nameof(Book), ref book, value); }
    }

    public int Quantity
    {
        get { return quantity; }
        set { SetPropertyValue(nameof(Quantity), ref quantity, value); }
    }
}
