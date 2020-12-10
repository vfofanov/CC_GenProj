using BusinessFramework.WebAPI.Contracts.Notifiers;

namespace NorthWind.WebAPI.Contracts
{
    /// <summary>
    ///     Notifiers' keys collection
    /// </summary>
    public static class Notifiers
    {   
        /// <summary>
        ///   Email notifier
        /// </summary>        
        public static NotifierInfo<EmailNotifierSettings> Default = new NotifierInfo<EmailNotifierSettings>(@"Default");
        public static NotifierInfo<EmailNotifierSettings> SystemNotifier
        {
            get { return Default; }
        }
    }
}