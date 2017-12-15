using System;
using System.Collections.Generic;
using PersistentRetryTemplate.Retry.ExceptionClassifiers;

namespace PersistentRetryTemplate.Retry.RetryPolicies
{
    public class AlwaysRetryPolicy: IRetryPolicy {
        public bool CanRetry(Exception exception)
        {
            return false;
        }

        public void StartContext()
        {
        }
    }
}