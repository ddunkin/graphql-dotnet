﻿using System.Collections.Generic;

namespace GraphQL.Language
{
    public interface INode
    {
        IEnumerable<INode> Children { get; }

        SourceLocation SourceLocation { get; }

        bool IsEqualTo(INode node);
    }
}
