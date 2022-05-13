﻿using System.Text;
using System.Xml.Serialization;

namespace Paywire.NET.Models.Base;

public class TransactionHeader
{
    /// <summary>
    /// ID associated with merchant
    /// </summary>
    public string PWCLIENTID { get; set; }
    /// <summary>
    /// Authentication key provided by the administrator
    /// </summary>
    public string PWKEY { get; set; }
    /// <summary>
    /// Authentication username provided by the administrator
    /// </summary>
    public string PWUSER { get; set; }
    /// <summary>
    /// Authentication password provided by the administrator
    /// </summary>
    public string PWPASS { get; set; }
    /// <summary>
    /// The Authentication Token to be used when calling the OSBP.
    /// </summary>
    public string AUTHTOKEN { get; set; }
    /// <summary>
    /// The Paywire Gateway version number.
    /// </summary>
    public string PWVERSION { get; set; }
    /// <summary>
    /// Defines what transaction to process.
    /// </summary>
    public string PWTRANSACTIONTYPE { get; set; }
    /// <summary>
    /// Amount of original transaction -- must match.
    /// </summary>
    public double PWSALEAMOUNT { get; set; }
    /// <summary>
    /// The Merchant's unique invoice number submitted in the transaction request
    /// </summary>
    public string PWINVOICENUMBER { get; set; }
    /// <summary>
    /// FALSE if not a card transaction
    /// </summary>
    public string CARDPRESENT { get; set; }
    /// <summary>
    /// Show the search result in XML or escaped XML (TRUE or FALSE)
    /// </summary>
    public string XOPTION { get; set; }
    /// <summary>
    /// Periodic Plan ID
    /// </summary>
    public string RECURRINGID { get; set; }
    /// <summary>
    /// Unique transaction ID returned in the transaction response, associated with the transaction being voided
    /// </summary>
    public string PWUNIQUEID { get; set; }
    /// <summary>
    /// Used in conjunction with Token Sales to apply Convenience Fees or Cash Discount for periodic payments handled outside Paywire
    /// </summary>
    public string POSINDICATOR { get; set; }
    /// <summary>
    /// Adjustment amount. Used to set the Convenience Fee amount to be charged for this transaction. Allowed only when submitted with POSINDICATOR set to P. Submitting amounts larger than that configured for the merchant will be ignored.
    /// </summary>
    public string PWADJAMOUNT { get; set; }
    /// <summary>
    /// Type of currency used in the transaction (USD/CNY/EUR)
    /// </summary>>
    public string CURRENCY { get; set; }
    /// <summary>
    /// Returns a PWTOKEN in the response when set to TRUE
    /// </summary>
    public string REQUESTTOKEN { get; set; }
    /// <summary>
    /// A URL on the Merchant's website that the return XML data will be posted to if transaction is approved
    /// </summary>
    public string PWAPPROVALURL { get; set; }
    /// <summary>
    /// A URL on the merchant's website that the return XML data will be posted to if the transaction is declined or any error occurs
    /// </summary>
    public string PWDECLINEURL { get; set; }
    /// <summary>
    /// Processes an Authorization only when a value of TRUE is submitted
    /// </summary>
    public string AUTHONLY { get; set; }
    /// <summary>
    /// Must set to TRUE for China UnionPay transactions
    /// </summary>
    public string ISCUP { get; set; }
    /// <summary>
    /// Switch language for the CUP OSBP (CHS/ENG)
    /// </summary>
    public string LANGUAGE { get; set; }
    /// <summary>
    /// Available for PWCTRANSTYPE = 2 or 4, default is TRUE. Set to FALSE to allow the customer to decide save the token or not.
    /// </summary>
    public string FORCESAVETOKEN { get; set; }
    /// <summary>
    /// Only available for PWCTRANSTYPE = 1 or 4. The user must manage the customer token and the transaction ID of the first transaction. Set to TRUE if the client wants to process token sales as non-secureplus with no SMS code verification for subsequent transactions. Debit card not supported. When this is set to TRUE, user must provide the PWUNIQUEID of the first transaction in the subsequent transaction request.
    /// </summary>
    public string NONSECUREPLUS { get; set; }
    /// <summary>
    /// Sub-domain of the Paywire environment to which you want to process (local, dbstage1, dbtranz)
    /// </summary>
    public string URL { get; set; }
    /// <summary>
    /// Overrides applying a Convenience Fee or Cash Discount when set to TRUE, if configured. Note that Sales Tax will also be disabled.
    /// </summary>
    public string DISABLECF { get; set; }

}