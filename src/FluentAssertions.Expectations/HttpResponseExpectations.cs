using FluentAssertions.Primitives;
using System.Net.Http;

namespace FluentAssertions.Expectations;

public static partial class Expectation
{
    /// <summary>Create an expectation about a <see cref="HttpResponseMessage"/> subject</summary>
    public static Expectation<HttpResponseMessage> Expect(HttpResponseMessage actual) => new(actual);

}

/// <summary>Extensions to <see cref="Expectation{T}"/> about <see cref="HttpResponseMessage"/></summary>
[DebuggerNonUserCode]
public static class HttpResponseMessageExpectationExtensions
{
    /// <summary>Compose assertions about the <see cref="HttpResponseMessage"/> subject</summary>
    public static HttpResponseMessageAssertions To(this Expectation<HttpResponseMessage> expectation)
        => expectation.Subject.Should();
}
