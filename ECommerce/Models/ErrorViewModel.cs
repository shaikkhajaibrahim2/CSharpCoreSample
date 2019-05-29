using System;

namespace ECommerce.Models
{
    /// <summary>
    /// More Changes
    /// </summary>
    public class ErrorViewModel
    {

        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}