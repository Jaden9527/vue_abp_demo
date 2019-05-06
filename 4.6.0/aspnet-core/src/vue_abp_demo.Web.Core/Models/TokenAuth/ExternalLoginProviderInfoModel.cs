using Abp.AutoMapper;
using vue_abp_demo.Authentication.External;

namespace vue_abp_demo.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
