using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace Loren.Api.Extensions
{
    public class EmailTagHelper : TagHelper
    {
        public string EmailDomain { get; set; } = "loren";

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName= "a";
            var content = await output.GetChildContentAsync();
            var target = content.GetContent() + "@" + EmailDomain;
            output.Attributes.SetAttribute("Href", "mailto:" + target);
            output.Content.SetContent(target);


        }
    }
}
