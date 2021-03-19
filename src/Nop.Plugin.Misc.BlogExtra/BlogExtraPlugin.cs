using System;
using System.Collections.Generic;
using System.Text;
using Nop.Core;
using Nop.Core.Infrastructure;
using Nop.Services.Cms;
using Nop.Services.Configuration;
using Nop.Services.Localization;
using Nop.Services.Media;
using Nop.Services.Plugins;
using Nop.Web.Framework.Infrastructure;

namespace Nop.Plugin.Misc.BlogExtra
{
    class BlogExtraPlugin : BasePlugin, IWidgetPlugin
    {
        
        private readonly ILocalizationService _localizationService;
        private readonly IPictureService _pictureService;
        private readonly ISettingService _settingService;
        private readonly IWebHelper _webHelper;
        private readonly INopFileProvider _fileProvider;

        public BlogExtraPlugin(ILocalizationService localizationService,
            IPictureService pictureService,
            ISettingService settingService,
            IWebHelper webHelper,
            INopFileProvider fileProvider)
        {
            _localizationService = localizationService;
            _pictureService = pictureService;
            _settingService = settingService;
            _webHelper = webHelper;
            _fileProvider = fileProvider;
        }

        public string GetWidgetViewComponentName(string widgetZone)
        {
            return "HomepageBlogs";
        }

        public IList<string> GetWidgetZones()
        {
            return new List<string> { PublicWidgetZones.HomepageTop };
        }
        public override void Install()
        {
            base.Install();
        }
        public override void Uninstall()
        {
            base.Uninstall();
        }
        public bool HideInWidgetList => false;
    }
}
