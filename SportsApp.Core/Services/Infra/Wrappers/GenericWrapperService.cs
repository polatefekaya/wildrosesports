using System;
using System.Collections.Generic;
using System.Reflection;

namespace SportsApp.Core.Services.Infra.Wrappers {
    public class GenericWrapperService {
        //Interface Not Implemented
        private void Deneme<TRef, TReq>(TRef players, ref TReq addRequest) {
            PropertyInfo[] modelProperties = players.GetType().GetProperties();
            PropertyInfo[] requestProperties = addRequest.GetType().GetProperties();

            //Compare with names, make dict with names as keys

            for (int i = 0; i < requestProperties.Length; i++) {
                requestProperties[i].SetValue(requestProperties[i], modelProperties[i].GetValue(modelProperties[i]));
            }

        }
    }
}
