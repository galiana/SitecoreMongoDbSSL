namespace Sitecore.MongoProviderConfigurator
{
    using System;
    using Sitecore.Analytics.Pipelines.UpdateMongoDriverSettings;
    using MongoDB.Driver;
    using System.Security.Authentication;

    // TODO: \App_Config\include\MongoDriverConfigurer.config created automatically when creating MongoDriverConfigurer class.

    public class MongoDriverConfigurer : Analytics.Pipelines.UpdateMongoDriverSettings.UpdateMongoDriverSettingsProcessor
    {
        public override void UpdateSettings(UpdateMongoDriverSettingsArgs args)
        {
            args.MongoSettings.UseSsl = true;
            args.MongoSettings.VerifySslCertificate = false;
            args.MongoSettings.SslSettings = new SslSettings();
            args.MongoSettings.SslSettings.EnabledSslProtocols = SslProtocols.Tls12;

        }
    }
}