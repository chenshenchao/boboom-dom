using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Boboom.Js;

namespace Boboom.Dom;

public class BoDom
{
    public BoJsModule Anchor { get; init; }
    public BoDom(IJSRuntime jsRuntime)
    {
        var assembly = typeof(BoDom).Assembly;
        Anchor = new BoJsModule(jsRuntime, assembly, "anchor.js");
    }

    public async ValueTask<BoDomPosition> GetPosition(IJSObjectReference element)
    {
        return await Anchor.InvokeAsync<BoDomPosition>("getPosition", element);
    }

    public async ValueTask<BoDomPosition> GetPosition(ElementReference element)
    {
        return await Anchor.InvokeAsync<BoDomPosition>("getPosition", element);
    }

    public async ValueTask SetPosition(IJSObjectReference element, BoDomPosition position)
    {
        await Anchor.InvokeVoidAsync("setPosition", element, position);
    }

    public async ValueTask SetPosition(ElementReference element, BoDomPosition position)
    {
        await Anchor.InvokeVoidAsync("setPosition", element, position);
    }

    public async ValueTask<BoDomSize> GetSize(IJSObjectReference element)
    {
        return await Anchor.InvokeAsync<BoDomSize>("getSize", element);
    }

    public async ValueTask<BoDomSize> GetSize(ElementReference element)
    {
        return await Anchor.InvokeAsync<BoDomSize>("getSize", element);
    }

    public async ValueTask SetSize(IJSObjectReference element, BoDomSize size)
    {
        await Anchor.InvokeVoidAsync("setSize", element, size);
    }

    public async ValueTask SetSize(ElementReference element, BoDomSize size)
    {
        await Anchor.InvokeVoidAsync("setSize", element, size);
    }

    public async ValueTask<BoDomSize> GetContentSize(ElementReference element)
    {
        return await Anchor.InvokeAsync<BoDomSize>("getContentSize", element);
    }

    public async ValueTask<BoDomSize> GetContentPosition(ElementReference element)
    {
        return await Anchor.InvokeAsync<BoDomSize>("getContentPosition", element);
    }
}
