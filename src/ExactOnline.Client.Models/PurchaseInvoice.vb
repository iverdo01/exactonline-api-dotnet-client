
Namespace PurchaseInvoice

    <SupportedActionsSDK(True, True, True, True)>
    <DataServiceKey("ID")>
    Public Class [PurchaseInvoice]
        '''<![CDATA[Primary key]]>
        Public Property [ID] As Guid
        '''<![CDATA[The date on which the supplier entered the invoice.]]>
        Public Property [InvoiceDate] As DateTime?
        '''<![CDATA[The journal code. Every invoice should be linked to a sales journal]]>
        Public Property [Journal] As String
        '''<![CDATA[Collection of lines]]>
        Public Property [PurchaseInvoiceLines] As IEnumerable(Of Models.PurchaseInvoice.PurchaseInvoiceLine)
        '''<![CDATA[Guid that identifies the supplier.]]>
        Public Property [Supplier] As Guid?
        '''<![CDATA[Indicates the type of the purchase invoice. 8030 Direct purchase invoice, 8031 Direct purchase invoice (Credit), 8033 Purchase invoice, 8034 Purchase invoice (Credit)]]>
        Public Property [Type] As Int16?
        '''<![CDATA[The invoice number provided by the supplier.]]>
        Public Property [YourRef] As String
    End Class

    <SupportedActionsSDK(True, True, True, True)>
    <DataServiceKey("ID")>
    Public Class [PurchaseInvoiceLine]
        '''<![CDATA[The Amount of the line in the currency of the invoice. Amount = Quantity * NetPrice.]]>
        <SDKFieldType(FieldType.ReadOnly)>
        Public Property [Amount] As Double?
        '''<![CDATA[Description of the invoice line.]]>
        Public Property [Description] As String
        '''<![CDATA[Primary key]]>
        Public Property [ID] As Guid
        '''<![CDATA[Guid that identifies the purchase item. When doing a POST either the Item or the PurchaseOrderLine has to be supplied.]]>
        Public Property [Item] As Guid?
        '''<![CDATA[The number of items that is purchased in units. For divisible items this can be a fractional number, otherwise it is an integer.]]>
        Public Property [Quantity] As Double?
        '''<![CDATA[Price per unit]]>
        Public Property [UnitPrice] As Double?
        '''<![CDATA[The VAT amount of the invoice line. It has to be specified together with VATCode.]]>
        Public Property [VATAmount] As Double?
        '''<![CDATA[The VAT code used for the invoice line. It has to be specified together with VATAmount. VATCode will not get a default value.]]>
        Public Property [VATCode] As String
    End Class

End Namespace