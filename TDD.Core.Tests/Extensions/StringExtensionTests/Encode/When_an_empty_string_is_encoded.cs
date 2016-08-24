using Machine.Specifications;
using TDD.Core.Extensions;

namespace TDD.Core.Tests.Extensions.StringExtensionTests.Encode
{
    [Subject(typeof(StringExtensions), "Encode")]
    public class When_an_empty_string_is_encoded
    {
        private static string wordToEncode;
        private static string expectedEncodedWord;
        private static string actualEncodedWord;

        Establish context = () =>
        {
            wordToEncode = string.Empty;
            expectedEncodedWord = string.Empty;
        };

        Because of = () =>
            actualEncodedWord = wordToEncode.Encode();

        It Should_encode_word_as_a = () =>
            actualEncodedWord.ShouldEqual(expectedEncodedWord);
    }
}
