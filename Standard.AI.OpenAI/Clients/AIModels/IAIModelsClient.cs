// ---------------------------------------------------------------------------------- 
// Copyright (c) The Standard Organization, a coalition of the Good-Hearted Engineers 
// ----------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Threading.Tasks;
using Standard.AI.OpenAI.Models.Clients.AIModels.Exceptions;
using Standard.AI.OpenAI.Models.Services.Foundations.AIModels;

namespace Standard.AI.OpenAI.Clients.AIModels
{
    public interface IAIModelsClient
    {
        /// <exception cref="AIModelClientValidationException" />
        /// <exception cref="AIModelClientDependencyException" />
        /// <exception cref="AIModelClientServiceException" />
        ValueTask<IEnumerable<AIModel>> RetrieveAIModelsAsync();
    }
}
