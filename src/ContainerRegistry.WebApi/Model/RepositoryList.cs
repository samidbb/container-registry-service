using System.Collections.Generic;

namespace ContainerRegistry.WebApi.Model
{
    public class RepositoryList
    {
        public IEnumerable<Repository> Items { get; set; }
    }
}