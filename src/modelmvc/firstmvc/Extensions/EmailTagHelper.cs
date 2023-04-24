using System;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace firstmvc.Extensions
{
	public class EmailTagHelper : TagHelper
	{
        /// <summary>
        /// caso voce nao passe nada, a propriedade vai ter esse valor.
        /// </summary>
        public string EmailDomain { get; set; } = "bruna.simoes";
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            var content = await output.GetChildContentAsync();
            var target = content.GetContent() + "@" + EmailDomain;
            output.Attributes.SetAttribute("href", "mailto:" + target);
            output.Content.SetContent(target);
        }
    }
}

