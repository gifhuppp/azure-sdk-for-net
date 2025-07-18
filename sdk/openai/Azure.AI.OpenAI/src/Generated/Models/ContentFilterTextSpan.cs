// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI
{
    /// <summary> A representation of a span of completion text as used by Azure OpenAI content filter results. </summary>
    public partial class ContentFilterTextSpan
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        /// <summary> Initializes a new instance of <see cref="ContentFilterTextSpan"/>. </summary>
        /// <param name="completionStartOffset"> Offset of the UTF32 code point which begins the span. </param>
        /// <param name="completionEndOffset"> Offset of the first UTF32 code point which is excluded from the span. This field is always equal to completion_start_offset for empty spans. This field is always larger than completion_start_offset for non-empty spans. </param>
        internal ContentFilterTextSpan(int completionStartOffset, int completionEndOffset)
        {
            CompletionStartOffset = completionStartOffset;
            CompletionEndOffset = completionEndOffset;
        }

        /// <summary> Initializes a new instance of <see cref="ContentFilterTextSpan"/>. </summary>
        /// <param name="completionStartOffset"> Offset of the UTF32 code point which begins the span. </param>
        /// <param name="completionEndOffset"> Offset of the first UTF32 code point which is excluded from the span. This field is always equal to completion_start_offset for empty spans. This field is always larger than completion_start_offset for non-empty spans. </param>
        /// <param name="additionalBinaryDataProperties"> Keeps track of any properties unknown to the library. </param>
        internal ContentFilterTextSpan(int completionStartOffset, int completionEndOffset, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            CompletionStartOffset = completionStartOffset;
            CompletionEndOffset = completionEndOffset;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        /// <summary> Offset of the UTF32 code point which begins the span. </summary>
        public int CompletionStartOffset { get; }

        /// <summary> Offset of the first UTF32 code point which is excluded from the span. This field is always equal to completion_start_offset for empty spans. This field is always larger than completion_start_offset for non-empty spans. </summary>
        public int CompletionEndOffset { get; }

        /// <summary></summary>
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
