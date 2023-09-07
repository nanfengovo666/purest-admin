﻿// MIT 许可证
// 版权 © 2023-present dym 和所有贡献者
// 作者或版权持有人都不对任何索赔、损害或其他责任负责，无论这些追责来自合同、侵权或其它行为中，
// 还是产生于、源于或有关于本软件以及本软件的使用或其它处置。

namespace PurestAdmin.Application;
public class PaginationParams
{
    /// <summary>
    /// 页码
    /// </summary>
    [Required(ErrorMessage = "页码不能为空"), Range(1, int.MaxValue, ErrorMessage = ("页码只能在 1 到 2147483647 之间"))]
    public int PageIndex { get; set; } = 1;

    /// <summary>
    /// 页容量
    /// </summary>
    [Required(ErrorMessage = "页容量不能为空"), Range(5, 200, ErrorMessage = ("页码只能在 5 到 200 之间"))]
    public int PageSize { get; set; } = 10;
}
