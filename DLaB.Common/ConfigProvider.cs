﻿using System.Collections.Specialized;
using System.Configuration;

namespace DLaB.Common
{
    /// <summary>
    /// Allows for Injection Custom Config provider.  Defaults to ConfigurationManager.AppSettings
    /// </summary>
    public class ConfigProvider
    {
        private static readonly object SingletonLock = new object();
        private static NameValueCollection _instance;
        
        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public static NameValueCollection Instance
        {
            get
            {
                if (_instance != null)
                {
                    return _instance;
                }
                lock (SingletonLock)
                {
                    if (_instance != null)
                    {
                        return _instance;
                    }

                    InitalizeProvider(ConfigurationManager.AppSettings); 
                    // TODO: Figure out why resharper is complaining
                    // ReSharper disable once ReadAccessInDoubleCheckLocking
                    return _instance;
                }
            }
        }

        private ConfigProvider() { }

        /// <summary>
        /// Initalizes the provider.
        /// </summary>
        /// <param name="appSettings">The application settings.</param>
        public static void InitalizeProvider(NameValueCollection appSettings)
        {
            _instance = appSettings;
        }
}
}
