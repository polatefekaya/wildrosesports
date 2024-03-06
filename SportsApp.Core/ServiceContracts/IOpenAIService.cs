using System;
using System.Collections.Generic;

namespace SportsApp.Core.ServiceContracts {
    public interface IOpenAIService {
        Task<Completions?> AskChatGPT(string question, float temperature = 0.7f);
    }
}
