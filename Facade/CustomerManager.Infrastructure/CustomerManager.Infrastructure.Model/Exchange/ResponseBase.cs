using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomerManager.Infrastructure.Model.Exchange
{
    /// <summary>
    /// Used as response base object
    /// </summary>
    public class ResponseBase
    {
        public ResponseBase()
        {
            this.errors = new List<string>();
        }

        private List<string> errors { get; set; }

        /// <summary>
        /// List of errors
        /// </summary>
        public List<string> Errors
        {
            get
            {
                return this.errors;
            }
        }

        /// <summary>
        /// Response result
        /// </summary>
        public bool Success
        {
            get
            {
                return !this.Errors.Any();
            }
        }

        /// <summary>
        /// Add string error to error list.
        /// </summary>
        /// <param name="error"></param>
        public string AddError(string error)
        {
            this.errors.Add(error);
            return error;
        }

        /// <summary>
        /// Add a list of error to error list.
        /// </summary>
        /// <param name="errors"></param>
        public string AddError(List<string> errors)
        {
            this.errors.AddRange(errors);
            return string.Join('-', errors);
        }

        /// <summary>
        /// Add Exception.Message to error list.
        /// Concatenate Exception.Message, Exception.InnerException.Message and Exception.InnerException.InnerException.Message to return value.
        /// </summary>
        /// <param name="ex"></param>
        /// <returns></returns>
        public string AddError(Exception ex)
        {
            string externalExceptionMessage = (ex != null ? ex.Message : string.Empty);
            string internalExceptionMessage = externalExceptionMessage + (ex.InnerException != null ? " - InnerException " + ex.InnerException.Message + (ex.InnerException.InnerException != null ? " - InnerException.InnerException" + ex.InnerException.InnerException.Message : string.Empty) : string.Empty);

            this.AddError(externalExceptionMessage);

            return internalExceptionMessage;
        }

        /// <summary>
        /// Add ValidationResult.Errors to error list.
        /// </summary>
        /// <param name="result"></param>
        public string AddError(ValidationResult result)
        {
            return this.AddError(result.Errors.Select(x => x.ErrorMessage).ToList());
        }

        /// <summary>
        /// Add IDictionary (int, string) content (Key - Value) to error list.
        /// 
        /// </summary>
        /// <param name="values"></param>
        public string AddError(IDictionary<int, string> values)
        {
            return this.AddError(values.Select(x => $"{x.Key} - {x.Value}").ToList());
        }

        /// <summary>
        /// Add IDictionary (string, string) content (Key - Value) to error list.
        /// </summary>
        /// <param name="values"></param>
        public string AddError(IDictionary<string, string> values)
        {
            return this.AddError(values.Select(x => $"{x.Key} - {x.Value}").ToList());
        }

        /// <summary>
        /// Get list of errors aggregated on a single string.
        /// </summary>
        /// <returns></returns>
        public string GetJoinedErrors()
        {
            return this.GetJoinedErrors(" - ");
        }

        public string GetJoinedErrors(string separator)
        {
            return string.Join(separator, this.errors);
        }

        /// <summary>
        /// Clear the list of errors
        /// </summary>
        public void ClearErrors()
        {
            this.errors.Clear();
        }
    }
}
