using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Customerly.SDK.Models;
using RestSharp;

namespace Customerly.SDK
{
    public partial class CustomerlyClient
    {
        private readonly CustomerlyConfiguration _configuration;
        public const string BaseUrl = "https://api.customerly.io/v1";

        public CustomerlyClient(string apiKey)
            : this(new CustomerlyConfiguration() { ApiToken = apiKey })
        {
        }

        public CustomerlyClient(CustomerlyConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected T Get<T>(RestRequest request) where T : new()
        {

            var client = new RestClient
            {
                BaseUrl = new System.Uri(BaseUrl)
            };

            request.AddHeader("AccessToken", _configuration.ApiToken);
            request.AddHeader("Client", _configuration.Source);

            var response = client.Get<T>(request);

            if (response.ErrorException != null)
            {
                const string message = "Error retrieving response.  Check inner details for more info.";
                throw new ApplicationException(message, response.ErrorException);
            }
            return response.Data;
        }
    }

    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public partial class CustomerlyClient : ICustomerlyClient
    {
        /// <summary>
        /// Returns all users with a matching username, first name, last name, email address, or company name.
        /// AccessLevel: Administrators Only
        /// </summary>
        /// <param name="search">Username, First/Last Name, Email, or Company Name.</param>
        /// <param name="limit">Limit the number of results</param>
        /// <param name="showInactive"></param>
        /// <returns>List&lt;User&gt;.</returns>
        [SuppressMessage("ReSharper", "UnusedMember.Global")]
        public List<User> GetUsers(int? page = null, int? perPage = null, string sort = null, string sortDirection = "asc")
        {
            var request = new RestRequest(Method.GET)
            {
                Resource = "users/list"
            };
            if (page != null)
            {
                request.AddParameter("page", page, ParameterType.QueryString);
            }

            if (perPage <= 100)
            {
                request.AddParameter("perPage", perPage, ParameterType.QueryString);
            }

            if (string.IsNullOrWhiteSpace(sort) == false)
            {
                request.AddParameter("sort", sort, ParameterType.QueryString);
            }

            if (string.IsNullOrWhiteSpace(sortDirection) == false)
            {
                request.AddParameter("sortDirection", sortDirection, ParameterType.QueryString);
            }

            return Get<List<User>>(request);
        }

        /// <summary>
        /// Gets the user.
        /// </summary>
        /// <returns>Users.</returns>
        public User GetUserById(string userId)
        {
            if (string.IsNullOrWhiteSpace(userId))
            {
                throw new ArgumentOutOfRangeException(nameof(userId), "Argument can not be empty");
            }
            var request = new RestRequest(Method.GET)
            {
                Resource = "users"
            };
            request.AddParameter("userId", userId, ParameterType.QueryString);

            return Get<User>(request);
        }

        public User GetUserByEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new ArgumentOutOfRangeException(nameof(email), "Argument can not be empty");
            }
            var request = new RestRequest(Method.GET)
            {
                Resource = "users"
            };
            request.AddParameter("email", email, ParameterType.QueryString);

            return Get<User>(request);
        }
    }
}