﻿namespace Microsoft.Azure.Devices.Client
{
    /// <summary>
    /// Retry Strategy types supported by DeviceClient
    /// </summary>
    [System.Obsolete("This has been renamed to RetryStrategyType.")]
    public enum RetryPolicyType
    {
        /// <summary>
        /// No retry.  A single attempt of operation.
        /// </summary>
        No_Retry = 0,

        /// <summary>
        /// A retry strategy which exponentially augments the retry delay and adds a random value to the delay at each retry.
        /// This is the DEFAULT policy to use
        /// </summary>
        Exponential_Backoff_With_Jitter = 1,
    }
}
