namespace bgProjectCalc
{
    using Nancy;

    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = parameters =>
            {
                return View["index"];
            };

            Get["/resourceRate"] = parameters => getResourceRate(Request.Query.resourceType).ToString();
        }

        double getResourceRate(string resourceType)
        {
            switch (resourceType)
            {
                case "AccountManager" :
                    return 110.00;
                case "Designer" :
                    return 80.00;
                default:
                    return 0;
            }
        }
    }
}