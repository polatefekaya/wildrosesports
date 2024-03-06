using System;
using System.Collections.Generic;

namespace SportsApp.Core.Services {
    public class OpenAIService : IOpenAIService {
        private readonly IOpenAIServiceHelper _serviceHelper;

        public OpenAIService(IOpenAIServiceHelper serviceHelper) { 
            _serviceHelper = serviceHelper;
        }
        public Task<Completions?> AskChatGPT(string question, float temperature = 0.7F) {
            return _serviceHelper.CompletionsHttpPostRequest<Completions?>("");
        }
    }
}
