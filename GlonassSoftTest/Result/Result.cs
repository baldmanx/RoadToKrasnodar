using System;
using System.Collections.Generic;

namespace GlonassSoftTest.Result
{
    public class Result<T> : IResult
    {
        public Result(T value)
        {
            Value = value;
            if (Value != null)
            {
                ValueType = Value.GetType();
            }
        }
        private Result(ResultStatus status)
        {
            Status = status;
        }

        #region Value

        /// <summary>
        ///     Хранит результат заданного типа
        /// </summary>
        public T Value { get; set; }
        public Type ValueType { get; private set; }

        #endregion

        #region Error

        public List<Error> Errors { get; private set; } = new List<Error>();
        public static Result<T> Error(params string[] errorMessages)
        {
            var validationErrors = new List<Error>();
            foreach (var error in errorMessages)
            {
                validationErrors.Add(new Error()
                {
                    Message = error
                });
            }
            return new Result<T>(ResultStatus.Error) { Errors = validationErrors };
        }
        public static Result<T> Error(List<Error> errors)
        {
            return new Result<T>(ResultStatus.Error) { Errors = errors };
        }

        #endregion

        public ResultStatus Status { get; private set; } = ResultStatus.Ok;
    }
}
