﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace WcfTestBridgeCommon
{
    public interface IResource
    {
        object Put(ResourceRequestContext context);

        object Get(ResourceRequestContext context);
    }
}
