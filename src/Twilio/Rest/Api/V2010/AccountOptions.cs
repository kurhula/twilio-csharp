using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Api.V2010 
{

    /// <summary>
    /// Create a new Twilio Subaccount from the account making the request
    /// </summary>
    public class CreateAccountOptions : IOptions<AccountResource> 
    {
        /// <summary>
        /// A human readable description of the account
        /// </summary>
        public string FriendlyName { get; set; }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            
            return p;
        }
    }

    /// <summary>
    /// Fetch the account specified by the provided Account Sid
    /// </summary>
    public class FetchAccountOptions : IOptions<AccountResource> 
    {
        /// <summary>
        /// Fetch by unique Account Sid
        /// </summary>
        public string Sid { get; set; }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// Retrieves a collection of Accounts belonging to the account used to make the request
    /// </summary>
    public class ReadAccountOptions : ReadOptions<AccountResource> 
    {
        /// <summary>
        /// FriendlyName to filter on
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// Status to filter on
        /// </summary>
        public AccountResource.StatusEnum Status { get; set; }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            
            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }
            
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            
            return p;
        }
    }

    /// <summary>
    /// Modify the properties of a given Account
    /// </summary>
    public class UpdateAccountOptions : IOptions<AccountResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string Sid { get; set; }
        /// <summary>
        /// FriendlyName to update
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// Status to update the Account with
        /// </summary>
        public AccountResource.StatusEnum Status { get; set; }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            
            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }
            
            return p;
        }
    }

}