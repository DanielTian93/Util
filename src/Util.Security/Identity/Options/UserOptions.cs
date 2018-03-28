﻿namespace Util.Security.Identity.Options {
    /// <summary>
    /// 用户配置
    /// </summary>
    public class UserOptions {
        /// <summary>
        /// 用户名允许使用的字符. 默认值为 abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+
        /// </summary>
        public string UserNameCharacters { get; set; } = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";

        /// <summary>
        /// 每个用户具有唯一的电子邮件，默认不启用
        /// </summary>
        public bool UniqueEmail { get; set; }
    }
}
