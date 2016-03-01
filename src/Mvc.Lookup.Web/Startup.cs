using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.AspNet.Razor.TagHelpers;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace NonFactors.Mvc.Lookup.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();
            app.UseIISPlatformHandler();
            app.UseStaticFiles();

            app.UseMvcWithDefaultRoute();
        }
    }
    [HtmlTargetElement("input", Attributes = "mvc-lookup-for")]
    public class MvcLookupTagHelper : TagHelper
    {
        [HtmlAttributeName("mvc-lookup-for")]
        public ModelExpression For { get; set; }

        [HtmlAttributeName("mvc-lookup")]
        public AbstractLookup Lookup { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            TagBuilder inputGroup = new TagBuilder("div");
            inputGroup.AddCssClass("input-group");

            output.Attributes["class"] = output.Attributes["class"] + " form-control mvc-lookup-input".Trim();
            output.Attributes.Add("data-mvc-lookup-filters", String.Join(",", Lookup.AdditionalFilters));
            output.Attributes.Add("data-mvc-lookup-for", TagBuilder.CreateSanitizedId(For.Name, "_"));
            output.Attributes.Add("data-mvc-lookup-records-per-page", Lookup.DefaultRecordsPerPage);
            output.Attributes.Add("data-mvc-lookup-sort-column", Lookup.DefaultSortColumn);
            output.Attributes.Add("data-mvc-lookup-sort-order", Lookup.DefaultSortOrder);
            output.Attributes.Add("data-mvc-lookup-dialog-title", Lookup.DialogTitle);
            output.Attributes.Add("data-mvc-lookup-url", Lookup.LookupUrl);
            output.Attributes.Add("data-mvc-lookup-term", "");
            output.Attributes.Add("data-mvc-lookup-page", 0);

            TagBuilder outerSpan = new TagBuilder("span");
            TagBuilder innerSpan = new TagBuilder("span");

            outerSpan.AddCssClass("mvc-lookup-open-span input-group-addon");
            innerSpan.AddCssClass("mvc-lookup-open-icon glyphicon");
            outerSpan.InnerHtml.Append(innerSpan);

            output.PostElement.Append(outerSpan);
        }
    }
}
