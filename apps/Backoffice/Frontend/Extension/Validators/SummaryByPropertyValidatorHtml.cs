namespace CodelyTv.Apps.Backoffice.Frontend.Extension.Validators
{
    using System.Text;
    using Microsoft.AspNetCore.Html;
    using Microsoft.AspNetCore.Mvc.ModelBinding;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public static class SummaryByPropertyValidatorHtml
    {
        public static IHtmlContent ValidationSummaryByProperty<TModel>(this IHtmlHelper<TModel> helper, ModelStateDictionary dictionary, string property, string className)
        {
            StringBuilder builder = new StringBuilder();
            
            if (dictionary[property] != null)
            {
                foreach (var modelState in dictionary[property].Errors)
                {
                    builder.Append($"<p class='{className}'>{modelState.ErrorMessage}</p>");
                }
            }

            return new HtmlString(builder.ToString());
        }
    }
}