// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Response from a list skillset request. If successful, it includes the full definitions of all skillsets. </summary>
    internal partial class ListSkillsetsResult
    {
        /// <summary> Initializes a new instance of <see cref="ListSkillsetsResult"/>. </summary>
        /// <param name="skillsets"> The skillsets defined in the Search service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="skillsets"/> is null. </exception>
        internal ListSkillsetsResult(IEnumerable<SearchIndexerSkillset> skillsets)
        {
            if (skillsets == null)
            {
                throw new ArgumentNullException(nameof(skillsets));
            }

            Skillsets = skillsets.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ListSkillsetsResult"/>. </summary>
        /// <param name="skillsets"> The skillsets defined in the Search service. </param>
        internal ListSkillsetsResult(IReadOnlyList<SearchIndexerSkillset> skillsets)
        {
            Skillsets = skillsets;
        }

        /// <summary> The skillsets defined in the Search service. </summary>
        public IReadOnlyList<SearchIndexerSkillset> Skillsets { get; }
    }
}
