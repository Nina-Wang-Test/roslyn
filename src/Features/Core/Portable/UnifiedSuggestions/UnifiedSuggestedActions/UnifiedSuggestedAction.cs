﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable enable

using Microsoft.CodeAnalysis.CodeActions;

namespace Microsoft.CodeAnalysis.UnifiedSuggestions
{
    /// <summary>
    /// Similar to UnifiedSuggestedAction, but in a location that can be used by
    /// both local Roslyn and LSP.
    /// </summary>
    internal class UnifiedSuggestedAction : IUnifiedSuggestedAction
    {
        public Workspace Workspace { get; }

        public CodeAction CodeAction { get; }

        public UnifiedSuggestedAction(Workspace workspace, CodeAction codeAction)
        {
            Workspace = workspace;
            CodeAction = codeAction;
        }

        internal virtual CodeActionPriority Priority => CodeAction.Priority;
    }
}
