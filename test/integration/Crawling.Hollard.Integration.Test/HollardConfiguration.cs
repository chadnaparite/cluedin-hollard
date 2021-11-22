using System.Collections.Generic;
using CluedIn.Crawling.Hollard.Core;

namespace CluedIn.Crawling.Hollard.Integration.Test
{
  public static class HollardConfiguration
  {
    public static Dictionary<string, object> Create()
    {
      return new Dictionary<string, object>
            {
                { HollardConstants.KeyName.ApiKey, "demo" }
            };
    }
  }
}
