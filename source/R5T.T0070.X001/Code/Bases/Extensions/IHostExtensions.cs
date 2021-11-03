using System;

using R5T.T0070;
using R5T.T0075;


namespace System
{
    public static class IHostExtensions
    {
        public static IHostBuilder NewBuilder(this IHost _)
        {
            var output = new HostBuilder();
            return output;
        }
    }
}