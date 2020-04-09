﻿// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.DotNet.Interactive.App
{
    public class KernelSpecInstallResults
    {
        public bool Succeeded { get;  }

        public string Message { get; }

        public KernelSpecInstallResults(bool succeeded, string message = null)
        {
            Succeeded = succeeded;
            Message = message;
        }

    }
}