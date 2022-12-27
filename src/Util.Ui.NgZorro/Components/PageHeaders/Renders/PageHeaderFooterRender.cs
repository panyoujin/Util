﻿using Util.Ui.Builders;
using Util.Ui.Configs;
using Util.Ui.NgZorro.Components.PageHeaders.Builders;
using Util.Ui.Renders;

namespace Util.Ui.NgZorro.Components.PageHeaders.Renders {
    /// <summary>
    /// 页头底部渲染器
    /// </summary>
    public class PageHeaderFooterRender : RenderBase {
        /// <summary>
        /// 配置
        /// </summary>
        private readonly Config _config;

        /// <summary>
        /// 初始化页头底部渲染器
        /// </summary>
        /// <param name="config">配置</param>
        public PageHeaderFooterRender( Config config ) {
            _config = config;
        }

        /// <summary>
        /// 获取标签生成器
        /// </summary>
        protected override TagBuilder GetTagBuilder() {
            var builder = new PageHeaderFooterBuilder(_config);
            builder.Config();
            return builder;
        }
    }
}