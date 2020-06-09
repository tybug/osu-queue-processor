// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Diagnostics.CodeAnalysis;

namespace ManiaKeyRankingProcessor
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class QueueItem
    {
        public int score_id { get; set; }

        public bool high { get; set; }
    }
}
