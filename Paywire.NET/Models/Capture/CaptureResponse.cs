﻿using System.Xml.Serialization;
using Paywire.NET.Models.Base;

namespace Paywire.NET.Models.Capture
{
 
    public class CaptureResponse : BasePaywireResponse
    {
        /// <summary>
        /// Unique identifier for the batch containing the transaction.
        /// </summary>
        public string BATCHID { get; set; }
        /// <summary>
        /// The account holder's name that was supplied.
        /// </summary>
        public string AHNAME { get; set; }
        /// <summary>
        /// Method of payment with which the transaction was processed: E for web ACH, C for Card.
        /// </summary>
        public string PAYMETH { get; set; }
        /// <summary>
        /// The unique ID assigned by Paywire associated with this transaction.
        /// </summary>
        public string PWUNIQUEID { get; set; }
        /// <summary>
        /// Amount of the transaction total including any adjustments and taxes. Maximum 7 digits, excluding decimals.
        /// </summary>
        public string AMOUNT { get; set; }
        /// <summary>
        /// Masked Card or Account number.
        /// </summary>
        public string MACCOUNT { get; set; }
        /// <summary>
        /// The card type used. This field is blank if PAYMETH is E.
        /// </summary>
        public string CCTYPE { get; set; }
    }
}
