﻿/*
 *  Copyright (c) Microsoft. All rights reserved. Licensed under the MIT license.
 *  See LICENSE in the source repository root for complete license information.
 */

using System.Collections.Generic;

namespace XamarinNativePropertyManager.Models
{
    public class NewConversationModel
    {
        public string Topic { get; set; }

        public List<NewPostModel> Posts { get; set; }
    }
}
