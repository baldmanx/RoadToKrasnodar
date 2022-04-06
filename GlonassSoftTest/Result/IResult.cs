using System;
using System.Collections.Generic;

namespace GlonassSoftTest.Result
{
    public interface IResult
    {
        ResultStatus Status { get; }
        List<Error> Errors { get; }
        Type ValueType { get; }
    }
}
