using System;
using System.Collections.Generic;
using IO_Project.IO;

namespace IO_Project.Core
{
    static class JournalModifiersFactory
    {
        private static Dictionary<RequestType, IJournalModifier> modifiersByType = 
            new Dictionary<RequestType, IJournalModifier>();

        public static void RegisterJournalModifier(IJournalModifier journalModifier)
        {
            if (modifiersByType.ContainsKey(journalModifier.HandledRequestType))
            {
                return;
            }

            modifiersByType.Add(journalModifier.HandledRequestType, journalModifier);
        }

        public static IJournalModifier JournalModifierByType(RequestType requestType)
        {
            if (modifiersByType.TryGetValue(requestType, out var modifier))
            {
                return modifier;
            }

            return default;
        }
    }
}
