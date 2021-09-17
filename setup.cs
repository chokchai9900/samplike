protected override void OnStart()
{
    TelemetryConfiguration configuration = TelemetryConfiguration.CreateDefault();
    configuration.InstrumentationKey = "aa4128c2-524d-4dd4-8a86-2a5951706585";

    TelemetryConfiguration.Active.TelemetryChannel.DeveloperMode = true;

    telemetryClient = new TelemetryClient(configuration);
}