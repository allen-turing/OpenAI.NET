﻿// --------------------------------------------------------------- 
// Copyright (c) Coalition of the Good-Hearted Engineers 
// ---------------------------------------------------------------

using System;
using Xeptions;

namespace OpenAI.NET.Models.Completions.Exceptions
{
    internal class FailedCompletionServiceException : Xeption
    {
        public FailedCompletionServiceException(Exception innerException)
            : base(message: "Failed completion error occurred contact support.", innerException)
        { }
    }
}