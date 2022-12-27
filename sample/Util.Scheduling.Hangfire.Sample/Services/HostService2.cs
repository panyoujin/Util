﻿using Util.Scheduling.Hangfire.Sample.Jobs;

namespace Util.Scheduling.Hangfire.Sample.Services {
    /// <summary>
    /// 主机服务
    /// </summary>
    public class HostService2 : IHostedService {
        /// <summary>
        /// 调度管理器
        /// </summary>
        private readonly ISchedulerManager _manager;

        /// <summary>
        /// 初始化主机服务
        /// </summary>
        /// <param name="manager">调度管理器</param>
        public HostService2( ISchedulerManager manager ) {
            _manager = manager ?? throw new ArgumentNullException( nameof( manager ) );
        }

        /// <summary>
        /// 启动服务
        /// </summary>
        public async Task StartAsync( CancellationToken cancellationToken ) {
            await _manager.AddJobAsync( new TestJob1("哈哈") );
        }

        /// <summary>
        /// 停止服务
        /// </summary>
        public Task StopAsync( CancellationToken cancellationToken ) {
            return Task.CompletedTask;
        }
    }
}