using System.Collections.Generic;
using Customerly.SDK.Models;

namespace Customerly.SDK
{
    public interface ICustomerlyClient
    {
        List<User> GetUsers(int? page = null, int? perPage = null, string sort = null, string sortDirection = "asc");

        /// <summary>
        /// Gets the user.
        /// </summary>
        /// <returns>Users.</returns>
        User GetUserById(string userId);
        User GetUserByEmail(string email);
    }
}