public async void Button_Clicked(object sender, EventArgs e)
{
    var order = new Order()
    {
        Id = "412",
        Quantity = "98",
        Price = 7087
    };
    Dictionary<string, string> properties = new Dictionary<string, string>();
    properties.Add("Xamarin Key", "Custom Property Value");

    var orderJSON = JsonConvert.SerializeObject(order);
    var ctx = new StringContent(orderJSON, Encoding.UTF8, "application/json");
    HttpResponseMessage res = await client.PostAsync(url, ctx);
    App.telemetryClient.TrackEvent("Button Click!", properties);
}