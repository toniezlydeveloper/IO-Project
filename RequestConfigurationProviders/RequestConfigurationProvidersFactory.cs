using System;
using System.Collections.Generic;

namespace IO_Project.IO
{
    static class RequestConfigurationProvidersFactory
    {
        private static Dictionary<RequestType, IRequestConfigurationProvider> providersByType =
            new Dictionary<RequestType, IRequestConfigurationProvider>();

        public static void RegisterConfigurationProvider(IRequestConfigurationProvider configurationProvider)
        {
            if (providersByType.ContainsKey(configurationProvider.HandledRequestType))
            {
                return;
            }

            providersByType.Add(configurationProvider.HandledRequestType, configurationProvider);
        }

        public static IRequestConfigurationProvider ConfigurationProviderByType(RequestType requestType)
        {
            if (providersByType.TryGetValue(requestType, out var modifier))
            {
                return modifier;
            }

            return default;
        }
    }
}
