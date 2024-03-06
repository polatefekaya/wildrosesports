using Azure.Core;
using SportsApp.Core.ServiceContracts.Infra;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace SportsApp.Core.Services.Infra {
    public class EntityExceptionService : IEntityExceptionService {

        private enum HandleMode {
            Int,
            String,
            Bool
        };

        private enum HandleMessage {
            Null,
            EmptyString,
            BelowZero
        };

        private readonly string _nullMessage;
        private readonly string _emptyString;
        private readonly string _belowZero;

        public EntityExceptionService() {
            _nullMessage = " can not be null. ";
            _emptyString = " can not be an empty string. ";
            _belowZero = " can not be below zero or negative number. ";
        }
        public void IntExceptions<TRequest>(ref TRequest request) {
            NullOrNegative<TRequest>(ref request);
        }
        public void StringExceptions<TRequest>(ref TRequest request) {
            NullOrEmptyString<TRequest>(ref request);
        }
        public void BoolExceptions<TRequest>(ref TRequest request) {
            NullBool<TRequest>(ref request);
        }


        private void NullOrNegative<TRequest>(ref TRequest request) {
            ExceptionHandler<TRequest>(ref request, HandleMode.Int);
        }

        private void NullOrEmptyString<TRequest>(ref TRequest request) {
            ExceptionHandler<TRequest>(ref request, HandleMode.String);
        }

        private void NullBool<TRequest>(ref TRequest request) {
            ExceptionHandler<TRequest>(ref request, HandleMode.Bool);
        }

        private void ExceptionHandler<TRequest>(ref TRequest request, HandleMode mode) {
            _ = request ?? throw new ArgumentNullException(nameof(request));

            PropertyInfo[] properties = request.GetType().GetProperties();

            switch (mode) {
                case HandleMode.Int:
                    foreach (PropertyInfo property in properties) {
                        if (property.PropertyType == typeof(int?)) {
                            int? a = (int?)property.GetValue(request, null);

                            _ = a ?? throw ArgumentExceptionWithMessage(property, HandleMessage.Null);
                            if (a < 0) throw ArgumentExceptionWithMessage(property, HandleMessage.BelowZero);
                        }
                    }
                    break;
                case HandleMode.String:
                    foreach (PropertyInfo property in properties) {
                        if (property.PropertyType == typeof(string)) {
                            string? a = (string?)property.GetValue(request, null);
                    
                            _ = a ?? throw ArgumentExceptionWithMessage(property, HandleMessage.Null);
                            if (String.Equals(a, String.Empty)) throw ArgumentExceptionWithMessage(property, HandleMessage.EmptyString);
                        }
                    }
                    break;
                case HandleMode.Bool:
                    foreach (PropertyInfo property in properties) {
                        if (property.PropertyType == typeof(bool?)) {
                            bool? a = (bool?)property.GetValue(request, null);

                            _ = a ?? throw ArgumentExceptionWithMessage(property, HandleMessage.Null);
                        }
                    }
                break;
            }
        }

        private ArgumentException ArgumentExceptionWithMessage(PropertyInfo property, HandleMessage mode) {
            StringBuilder sb = new StringBuilder();
            sb.Append(property.Name);

            switch (mode) {
                case HandleMessage.Null:
                    sb.Append(_nullMessage);
                    break;
                case HandleMessage.EmptyString:
                    sb.Append(_emptyString);
                    break;
                case HandleMessage.BelowZero:
                    sb.Append(_belowZero);
                    break;
            }
            sb.Append(property.PropertyType);

            return new ArgumentException(sb.ToString());
        }
    }
}
