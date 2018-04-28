﻿using Roadkill.Text.Text.Menu;
using Roadkill.Text.Text.Plugins;

namespace Roadkill.Text.Text.TextMiddleware
{
    public class TextPluginAfterParseMiddleware : Middleware
    {
        private readonly TextPluginRunner _textPluginRunner;

        public TextPluginAfterParseMiddleware(TextPluginRunner textPluginRunner)
        {
            _textPluginRunner = textPluginRunner;
        }

        public override PageHtml Invoke(PageHtml pageHtml)
        {
            pageHtml.Html = _textPluginRunner.AfterParse(pageHtml.Html);
            pageHtml.PreContainerHtml = _textPluginRunner.PreContainerHtml();
            pageHtml.PostContainerHtml = _textPluginRunner.PostContainerHtml();
            pageHtml.IsCacheable = _textPluginRunner.IsCacheable;

            return pageHtml;
        }
    }
}