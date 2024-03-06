using System;
using System.Collections.Generic;

namespace SportsApp.Core.ServiceContracts.Infra {
    public interface IEntityExceptionService {
        public void IntExceptions<TRequest>(ref TRequest request);

        public void StringExceptions<TRequest>(ref TRequest request);

        public void BoolExceptions<TRequest>(ref TRequest request);
    }
}
