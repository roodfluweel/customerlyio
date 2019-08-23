using LitmosApi.ExtentionMethods;

namespace Customerly.SDK
{
    public class CustomerlyConfiguration : ICustomerlyConfiguration
    {
        private string _source = "CustomerlyDotNetSdk";

        /// <summary>
        /// Free text description of your app. Usually a company or product name.
        /// </summary>
        /// <value>The source.</value>
        public string Source
        {
            get => _source;
            set => _source = value.Truncate(50);
        }

        public string ApiToken { get; set; }
    }
}