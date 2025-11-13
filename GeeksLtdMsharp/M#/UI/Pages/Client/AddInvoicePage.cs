using MSharp;

namespace Client
{
    class AddInvoicePage : SubPage<ClientPage>
    {
        public AddInvoicePage()
        {
            Add<Modules.InvoiceForm>();
        }
    }
}