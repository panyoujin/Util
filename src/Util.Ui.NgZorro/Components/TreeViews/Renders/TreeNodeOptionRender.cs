﻿using Util.Ui.Builders;
using Util.Ui.Configs;
using Util.Ui.NgZorro.Components.TreeViews.Builders;
using Util.Ui.Renders;

namespace Util.Ui.NgZorro.Components.TreeViews.Renders {
    /// <summary>
    /// 树节点可选项渲染器
    /// </summary>
    public class TreeNodeOptionRender : RenderBase {
        /// <summary>
        /// 配置
        /// </summary>
        private readonly Config _config;

        /// <summary>
        /// 初始化树节点可选项渲染器
        /// </summary>
        /// <param name="config">配置</param>
        public TreeNodeOptionRender( Config config ) {
            _config = config;
        }

        /// <summary>
        /// 获取标签生成器
        /// </summary>
        protected override TagBuilder GetTagBuilder() {
            var builder = new TreeNodeOptionBuilder( _config );
            builder.Config();
            return builder;
        }
    }
}