/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
///
/// ServiceResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Notify.V1
{

    public class ServiceResource : Resource
    {
        private static Request BuildCreateRequest(CreateServiceOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Notify,
                "/v1/Services",
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns>
        public static ServiceResource Create(CreateServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns>
        public static async System.Threading.Tasks.Task<ServiceResource> CreateAsync(CreateServiceOptions options,
                                                                                     ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// create
        /// </summary>
        /// <param name="friendlyName"> A string to describe the resource </param>
        /// <param name="apnCredentialSid"> The SID of the Credential to use for APN Bindings </param>
        /// <param name="gcmCredentialSid"> The SID of the Credential to use for GCM Bindings </param>
        /// <param name="messagingServiceSid"> The SID of the Messaging Service to use for SMS Bindings </param>
        /// <param name="facebookMessengerPageId"> Deprecated </param>
        /// <param name="defaultApnNotificationProtocolVersion"> The protocol version to use for sending APNS notifications
        ///                                             </param>
        /// <param name="defaultGcmNotificationProtocolVersion"> The protocol version to use for sending GCM notifications
        ///                                             </param>
        /// <param name="fcmCredentialSid"> The SID of the Credential to use for FCM Bindings </param>
        /// <param name="defaultFcmNotificationProtocolVersion"> The protocol version to use for sending FCM notifications
        ///                                             </param>
        /// <param name="logEnabled"> Whether to log notifications </param>
        /// <param name="alexaSkillId"> Deprecated </param>
        /// <param name="defaultAlexaNotificationProtocolVersion"> Deprecated </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns>
        public static ServiceResource Create(string friendlyName = null,
                                             string apnCredentialSid = null,
                                             string gcmCredentialSid = null,
                                             string messagingServiceSid = null,
                                             string facebookMessengerPageId = null,
                                             string defaultApnNotificationProtocolVersion = null,
                                             string defaultGcmNotificationProtocolVersion = null,
                                             string fcmCredentialSid = null,
                                             string defaultFcmNotificationProtocolVersion = null,
                                             bool? logEnabled = null,
                                             string alexaSkillId = null,
                                             string defaultAlexaNotificationProtocolVersion = null,
                                             ITwilioRestClient client = null)
        {
            var options = new CreateServiceOptions(){FriendlyName = friendlyName, ApnCredentialSid = apnCredentialSid, GcmCredentialSid = gcmCredentialSid, MessagingServiceSid = messagingServiceSid, FacebookMessengerPageId = facebookMessengerPageId, DefaultApnNotificationProtocolVersion = defaultApnNotificationProtocolVersion, DefaultGcmNotificationProtocolVersion = defaultGcmNotificationProtocolVersion, FcmCredentialSid = fcmCredentialSid, DefaultFcmNotificationProtocolVersion = defaultFcmNotificationProtocolVersion, LogEnabled = logEnabled, AlexaSkillId = alexaSkillId, DefaultAlexaNotificationProtocolVersion = defaultAlexaNotificationProtocolVersion};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="friendlyName"> A string to describe the resource </param>
        /// <param name="apnCredentialSid"> The SID of the Credential to use for APN Bindings </param>
        /// <param name="gcmCredentialSid"> The SID of the Credential to use for GCM Bindings </param>
        /// <param name="messagingServiceSid"> The SID of the Messaging Service to use for SMS Bindings </param>
        /// <param name="facebookMessengerPageId"> Deprecated </param>
        /// <param name="defaultApnNotificationProtocolVersion"> The protocol version to use for sending APNS notifications
        ///                                             </param>
        /// <param name="defaultGcmNotificationProtocolVersion"> The protocol version to use for sending GCM notifications
        ///                                             </param>
        /// <param name="fcmCredentialSid"> The SID of the Credential to use for FCM Bindings </param>
        /// <param name="defaultFcmNotificationProtocolVersion"> The protocol version to use for sending FCM notifications
        ///                                             </param>
        /// <param name="logEnabled"> Whether to log notifications </param>
        /// <param name="alexaSkillId"> Deprecated </param>
        /// <param name="defaultAlexaNotificationProtocolVersion"> Deprecated </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns>
        public static async System.Threading.Tasks.Task<ServiceResource> CreateAsync(string friendlyName = null,
                                                                                     string apnCredentialSid = null,
                                                                                     string gcmCredentialSid = null,
                                                                                     string messagingServiceSid = null,
                                                                                     string facebookMessengerPageId = null,
                                                                                     string defaultApnNotificationProtocolVersion = null,
                                                                                     string defaultGcmNotificationProtocolVersion = null,
                                                                                     string fcmCredentialSid = null,
                                                                                     string defaultFcmNotificationProtocolVersion = null,
                                                                                     bool? logEnabled = null,
                                                                                     string alexaSkillId = null,
                                                                                     string defaultAlexaNotificationProtocolVersion = null,
                                                                                     ITwilioRestClient client = null)
        {
            var options = new CreateServiceOptions(){FriendlyName = friendlyName, ApnCredentialSid = apnCredentialSid, GcmCredentialSid = gcmCredentialSid, MessagingServiceSid = messagingServiceSid, FacebookMessengerPageId = facebookMessengerPageId, DefaultApnNotificationProtocolVersion = defaultApnNotificationProtocolVersion, DefaultGcmNotificationProtocolVersion = defaultGcmNotificationProtocolVersion, FcmCredentialSid = fcmCredentialSid, DefaultFcmNotificationProtocolVersion = defaultFcmNotificationProtocolVersion, LogEnabled = logEnabled, AlexaSkillId = alexaSkillId, DefaultAlexaNotificationProtocolVersion = defaultAlexaNotificationProtocolVersion};
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteServiceOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Notify,
                "/v1/Services/" + options.PathSid + "",
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns>
        public static bool Delete(DeleteServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteServiceOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns>
        public static bool Delete(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteServiceOptions(pathSid);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteServiceOptions(pathSid);
            return await DeleteAsync(options, client);
        }
        #endif

        private static Request BuildFetchRequest(FetchServiceOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Notify,
                "/v1/Services/" + options.PathSid + "",
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns>
        public static ServiceResource Fetch(FetchServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns>
        public static async System.Threading.Tasks.Task<ServiceResource> FetchAsync(FetchServiceOptions options,
                                                                                    ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns>
        public static ServiceResource Fetch(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchServiceOptions(pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns>
        public static async System.Threading.Tasks.Task<ServiceResource> FetchAsync(string pathSid,
                                                                                    ITwilioRestClient client = null)
        {
            var options = new FetchServiceOptions(pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadServiceOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Notify,
                "/v1/Services",
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns>
        public static ResourceSet<ServiceResource> Read(ReadServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<ServiceResource>.FromJson("services", response.Content);
            return new ResourceSet<ServiceResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<ServiceResource>> ReadAsync(ReadServiceOptions options,
                                                                                                ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<ServiceResource>.FromJson("services", response.Content);
            return new ResourceSet<ServiceResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        /// <param name="friendlyName"> The string that identifies the Service resources to read </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns>
        public static ResourceSet<ServiceResource> Read(string friendlyName = null,
                                                        int? pageSize = null,
                                                        long? limit = null,
                                                        ITwilioRestClient client = null)
        {
            var options = new ReadServiceOptions(){FriendlyName = friendlyName, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="friendlyName"> The string that identifies the Service resources to read </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<ServiceResource>> ReadAsync(string friendlyName = null,
                                                                                                int? pageSize = null,
                                                                                                long? limit = null,
                                                                                                ITwilioRestClient client = null)
        {
            var options = new ReadServiceOptions(){FriendlyName = friendlyName, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<ServiceResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<ServiceResource>.FromJson("services", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<ServiceResource> NextPage(Page<ServiceResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Notify)
            );

            var response = client.Request(request);
            return Page<ServiceResource>.FromJson("services", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<ServiceResource> PreviousPage(Page<ServiceResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Notify)
            );

            var response = client.Request(request);
            return Page<ServiceResource>.FromJson("services", response.Content);
        }

        private static Request BuildUpdateRequest(UpdateServiceOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Notify,
                "/v1/Services/" + options.PathSid + "",
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns>
        public static ServiceResource Update(UpdateServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns>
        public static async System.Threading.Tasks.Task<ServiceResource> UpdateAsync(UpdateServiceOptions options,
                                                                                     ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="friendlyName"> A string to describe the resource </param>
        /// <param name="apnCredentialSid"> The SID of the Credential to use for APN Bindings </param>
        /// <param name="gcmCredentialSid"> The SID of the Credential to use for GCM Bindings </param>
        /// <param name="messagingServiceSid"> The SID of the Messaging Service to use for SMS Bindings </param>
        /// <param name="facebookMessengerPageId"> Deprecated </param>
        /// <param name="defaultApnNotificationProtocolVersion"> The protocol version to use for sending APNS notifications
        ///                                             </param>
        /// <param name="defaultGcmNotificationProtocolVersion"> The protocol version to use for sending GCM notifications
        ///                                             </param>
        /// <param name="fcmCredentialSid"> The SID of the Credential to use for FCM Bindings </param>
        /// <param name="defaultFcmNotificationProtocolVersion"> The protocol version to use for sending FCM notifications
        ///                                             </param>
        /// <param name="logEnabled"> Whether to log notifications </param>
        /// <param name="alexaSkillId"> Deprecated </param>
        /// <param name="defaultAlexaNotificationProtocolVersion"> Deprecated </param>
        /// <param name="deliveryCallbackUrl"> Webhook URL </param>
        /// <param name="deliveryCallbackEnabled"> Enable delivery callbacks </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns>
        public static ServiceResource Update(string pathSid,
                                             string friendlyName = null,
                                             string apnCredentialSid = null,
                                             string gcmCredentialSid = null,
                                             string messagingServiceSid = null,
                                             string facebookMessengerPageId = null,
                                             string defaultApnNotificationProtocolVersion = null,
                                             string defaultGcmNotificationProtocolVersion = null,
                                             string fcmCredentialSid = null,
                                             string defaultFcmNotificationProtocolVersion = null,
                                             bool? logEnabled = null,
                                             string alexaSkillId = null,
                                             string defaultAlexaNotificationProtocolVersion = null,
                                             string deliveryCallbackUrl = null,
                                             bool? deliveryCallbackEnabled = null,
                                             ITwilioRestClient client = null)
        {
            var options = new UpdateServiceOptions(pathSid){FriendlyName = friendlyName, ApnCredentialSid = apnCredentialSid, GcmCredentialSid = gcmCredentialSid, MessagingServiceSid = messagingServiceSid, FacebookMessengerPageId = facebookMessengerPageId, DefaultApnNotificationProtocolVersion = defaultApnNotificationProtocolVersion, DefaultGcmNotificationProtocolVersion = defaultGcmNotificationProtocolVersion, FcmCredentialSid = fcmCredentialSid, DefaultFcmNotificationProtocolVersion = defaultFcmNotificationProtocolVersion, LogEnabled = logEnabled, AlexaSkillId = alexaSkillId, DefaultAlexaNotificationProtocolVersion = defaultAlexaNotificationProtocolVersion, DeliveryCallbackUrl = deliveryCallbackUrl, DeliveryCallbackEnabled = deliveryCallbackEnabled};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="friendlyName"> A string to describe the resource </param>
        /// <param name="apnCredentialSid"> The SID of the Credential to use for APN Bindings </param>
        /// <param name="gcmCredentialSid"> The SID of the Credential to use for GCM Bindings </param>
        /// <param name="messagingServiceSid"> The SID of the Messaging Service to use for SMS Bindings </param>
        /// <param name="facebookMessengerPageId"> Deprecated </param>
        /// <param name="defaultApnNotificationProtocolVersion"> The protocol version to use for sending APNS notifications
        ///                                             </param>
        /// <param name="defaultGcmNotificationProtocolVersion"> The protocol version to use for sending GCM notifications
        ///                                             </param>
        /// <param name="fcmCredentialSid"> The SID of the Credential to use for FCM Bindings </param>
        /// <param name="defaultFcmNotificationProtocolVersion"> The protocol version to use for sending FCM notifications
        ///                                             </param>
        /// <param name="logEnabled"> Whether to log notifications </param>
        /// <param name="alexaSkillId"> Deprecated </param>
        /// <param name="defaultAlexaNotificationProtocolVersion"> Deprecated </param>
        /// <param name="deliveryCallbackUrl"> Webhook URL </param>
        /// <param name="deliveryCallbackEnabled"> Enable delivery callbacks </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns>
        public static async System.Threading.Tasks.Task<ServiceResource> UpdateAsync(string pathSid,
                                                                                     string friendlyName = null,
                                                                                     string apnCredentialSid = null,
                                                                                     string gcmCredentialSid = null,
                                                                                     string messagingServiceSid = null,
                                                                                     string facebookMessengerPageId = null,
                                                                                     string defaultApnNotificationProtocolVersion = null,
                                                                                     string defaultGcmNotificationProtocolVersion = null,
                                                                                     string fcmCredentialSid = null,
                                                                                     string defaultFcmNotificationProtocolVersion = null,
                                                                                     bool? logEnabled = null,
                                                                                     string alexaSkillId = null,
                                                                                     string defaultAlexaNotificationProtocolVersion = null,
                                                                                     string deliveryCallbackUrl = null,
                                                                                     bool? deliveryCallbackEnabled = null,
                                                                                     ITwilioRestClient client = null)
        {
            var options = new UpdateServiceOptions(pathSid){FriendlyName = friendlyName, ApnCredentialSid = apnCredentialSid, GcmCredentialSid = gcmCredentialSid, MessagingServiceSid = messagingServiceSid, FacebookMessengerPageId = facebookMessengerPageId, DefaultApnNotificationProtocolVersion = defaultApnNotificationProtocolVersion, DefaultGcmNotificationProtocolVersion = defaultGcmNotificationProtocolVersion, FcmCredentialSid = fcmCredentialSid, DefaultFcmNotificationProtocolVersion = defaultFcmNotificationProtocolVersion, LogEnabled = logEnabled, AlexaSkillId = alexaSkillId, DefaultAlexaNotificationProtocolVersion = defaultAlexaNotificationProtocolVersion, DeliveryCallbackUrl = deliveryCallbackUrl, DeliveryCallbackEnabled = deliveryCallbackEnabled};
            return await UpdateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a ServiceResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ServiceResource object represented by the provided JSON </returns>
        public static ServiceResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<ServiceResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The SID of the Account that created the resource
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The string that you assigned to describe the resource
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// The RFC 2822 date and time in GMT when the resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The RFC 2822 date and time in GMT when the resource was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The SID of the Credential to use for APN Bindings
        /// </summary>
        [JsonProperty("apn_credential_sid")]
        public string ApnCredentialSid { get; private set; }
        /// <summary>
        /// The SID of the Credential to use for GCM Bindings
        /// </summary>
        [JsonProperty("gcm_credential_sid")]
        public string GcmCredentialSid { get; private set; }
        /// <summary>
        /// The SID of the Credential to use for FCM Bindings
        /// </summary>
        [JsonProperty("fcm_credential_sid")]
        public string FcmCredentialSid { get; private set; }
        /// <summary>
        /// The SID of the Messaging Service to use for SMS Bindings
        /// </summary>
        [JsonProperty("messaging_service_sid")]
        public string MessagingServiceSid { get; private set; }
        /// <summary>
        /// Deprecated
        /// </summary>
        [JsonProperty("facebook_messenger_page_id")]
        public string FacebookMessengerPageId { get; private set; }
        /// <summary>
        /// The protocol version to use for sending APNS notifications
        /// </summary>
        [JsonProperty("default_apn_notification_protocol_version")]
        public string DefaultApnNotificationProtocolVersion { get; private set; }
        /// <summary>
        /// The protocol version to use for sending GCM notifications
        /// </summary>
        [JsonProperty("default_gcm_notification_protocol_version")]
        public string DefaultGcmNotificationProtocolVersion { get; private set; }
        /// <summary>
        /// The protocol version to use for sending FCM notifications
        /// </summary>
        [JsonProperty("default_fcm_notification_protocol_version")]
        public string DefaultFcmNotificationProtocolVersion { get; private set; }
        /// <summary>
        /// Whether to log notifications
        /// </summary>
        [JsonProperty("log_enabled")]
        public bool? LogEnabled { get; private set; }
        /// <summary>
        /// The absolute URL of the Service resource
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// The URLs of the resources related to the service
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }
        /// <summary>
        /// Deprecated
        /// </summary>
        [JsonProperty("alexa_skill_id")]
        public string AlexaSkillId { get; private set; }
        /// <summary>
        /// Deprecated
        /// </summary>
        [JsonProperty("default_alexa_notification_protocol_version")]
        public string DefaultAlexaNotificationProtocolVersion { get; private set; }

        private ServiceResource()
        {

        }
    }

}