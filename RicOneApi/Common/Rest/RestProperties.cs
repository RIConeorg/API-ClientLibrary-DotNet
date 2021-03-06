﻿using RicOneApi.Common.Objects;
using System;

/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.6.3
 * Since       2018-08-15
 */
namespace RicOneApi.Common.Rest
{
    /// <summary>
    /// Accessor class used for building requests based on provided values. This includes base API url, servicepath, refid, 
    /// REST headers, and REST query parameters.
    /// </summary>
    class RestProperties
    {
        private String baseUrl;
        private ServicePath servicePath;
        private String refId;
        private RestHeader restHeader;
        private RestQueryParameter restQueryParameter;

        public RestProperties(string baseUrl, ServicePath servicePath, RestHeader restHeader, RestQueryParameter restQueryParameter)
        {
            this.BaseUrl = baseUrl;
            this.ServicePath = servicePath;
            this.RestHeader = restHeader;
            this.RestQueryParameter = restQueryParameter;
        }

        public RestProperties(string baseUrl, ServicePath servicePath, string refId, RestHeader restHeader, RestQueryParameter restQueryParameter)
        {
            this.BaseUrl = baseUrl;
            this.ServicePath = servicePath;
            this.RefId = refId;
            this.RestHeader = restHeader;
            this.RestQueryParameter = restQueryParameter;
        }

        public string BaseUrl { get => baseUrl; set => baseUrl = value; }
        public string RefId { get => refId; set => refId = value; }
        public ServicePath ServicePath { get => servicePath; set => servicePath = value; }
        internal RestHeader RestHeader { get => restHeader; set => restHeader = value; }
        internal RestQueryParameter RestQueryParameter { get => restQueryParameter; set => restQueryParameter = value; }

        internal bool HasRefId() { return !string.IsNullOrEmpty(refId); }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
