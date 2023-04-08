﻿

namespace HostSample
{
    public class MyClassSecurity : IMyClassSecurity
    {
        public int DoWithSecurity(User user)
        {
            return 1;
        }

        public Task<int> DoWithSecurityAsync(User user)
        {
            return Task.Factory.StartNew(() => { return 1; });
        }
    }
}