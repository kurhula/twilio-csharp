/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Messaging.V1.Session
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// FetchMessageOptions
    /// </summary>
    public class FetchMessageOptions : IOptions<MessageResource>
    {
        /// <summary>
        /// The unique id of the Session for this message.
        /// </summary>
        public string PathSessionSid { get; }
        /// <summary>
        /// A 34 character string that uniquely identifies this resource.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchMessageOptions
        /// </summary>
        /// <param name="pathSessionSid"> The unique id of the Session for this message. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        public FetchMessageOptions(string pathSessionSid, string pathSid)
        {
            PathSessionSid = pathSessionSid;
            PathSid = pathSid;
        }

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
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// CreateMessageOptions
    /// </summary>
    public class CreateMessageOptions : IOptions<MessageResource>
    {
        /// <summary>
        /// The unique id of the Session for this message.
        /// </summary>
        public string PathSessionSid { get; }
        /// <summary>
        /// The identity of the message's author.
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// A string metadata field you can use to store any data you wish.
        /// </summary>
        public string Attributes { get; set; }
        /// <summary>
        /// The date that this resource was created.
        /// </summary>
        public DateTime? DateCreated { get; set; }
        /// <summary>
        /// The date that this resource was last updated.
        /// </summary>
        public DateTime? DateUpdated { get; set; }
        /// <summary>
        /// The contents of the message.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Construct a new CreateMessageOptions
        /// </summary>
        /// <param name="pathSessionSid"> The unique id of the Session for this message. </param>
        public CreateMessageOptions(string pathSessionSid)
        {
            PathSessionSid = pathSessionSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Author != null)
            {
                p.Add(new KeyValuePair<string, string>("Author", Author));
            }

            if (Attributes != null)
            {
                p.Add(new KeyValuePair<string, string>("Attributes", Attributes));
            }

            if (DateCreated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreated", Serializers.DateTimeIso8601(DateCreated)));
            }

            if (DateUpdated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateUpdated", Serializers.DateTimeIso8601(DateUpdated)));
            }

            if (Body != null)
            {
                p.Add(new KeyValuePair<string, string>("Body", Body));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// UpdateMessageOptions
    /// </summary>
    public class UpdateMessageOptions : IOptions<MessageResource>
    {
        /// <summary>
        /// The unique id of the Session for this message.
        /// </summary>
        public string PathSessionSid { get; }
        /// <summary>
        /// A 34 character string that uniquely identifies this resource.
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The identity of the message's author.
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// A string metadata field you can use to store any data you wish.
        /// </summary>
        public string Attributes { get; set; }
        /// <summary>
        /// The date that this resource was created.
        /// </summary>
        public DateTime? DateCreated { get; set; }
        /// <summary>
        /// The date that this resource was last updated.
        /// </summary>
        public DateTime? DateUpdated { get; set; }
        /// <summary>
        /// The contents of the message.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Construct a new UpdateMessageOptions
        /// </summary>
        /// <param name="pathSessionSid"> The unique id of the Session for this message. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        public UpdateMessageOptions(string pathSessionSid, string pathSid)
        {
            PathSessionSid = pathSessionSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Author != null)
            {
                p.Add(new KeyValuePair<string, string>("Author", Author));
            }

            if (Attributes != null)
            {
                p.Add(new KeyValuePair<string, string>("Attributes", Attributes));
            }

            if (DateCreated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreated", Serializers.DateTimeIso8601(DateCreated)));
            }

            if (DateUpdated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateUpdated", Serializers.DateTimeIso8601(DateUpdated)));
            }

            if (Body != null)
            {
                p.Add(new KeyValuePair<string, string>("Body", Body));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// ReadMessageOptions
    /// </summary>
    public class ReadMessageOptions : ReadOptions<MessageResource>
    {
        /// <summary>
        /// The unique id of the Session for this message.
        /// </summary>
        public string PathSessionSid { get; }

        /// <summary>
        /// Construct a new ReadMessageOptions
        /// </summary>
        /// <param name="pathSessionSid"> The unique id of the Session for this message. </param>
        public ReadMessageOptions(string pathSessionSid)
        {
            PathSessionSid = pathSessionSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// DeleteMessageOptions
    /// </summary>
    public class DeleteMessageOptions : IOptions<MessageResource>
    {
        /// <summary>
        /// The unique id of the Session for this message.
        /// </summary>
        public string PathSessionSid { get; }
        /// <summary>
        /// A 34 character string that uniquely identifies this resource.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteMessageOptions
        /// </summary>
        /// <param name="pathSessionSid"> The unique id of the Session for this message. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        public DeleteMessageOptions(string pathSessionSid, string pathSid)
        {
            PathSessionSid = pathSessionSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

}