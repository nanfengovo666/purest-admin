// MIT 许可证
// 版权 © 2023-present dym 和所有贡献者
// 作者或版权持有人都不对任何索赔、损害或其他责任负责，无论这些追责来自合同、侵权或其它行为中，
// 还是产生于、源于或有关于本软件以及本软件的使用或其它处置。

namespace PurestAdmin.Application.DictCategory.Dtos;

/// <summary>
/// 字典分类详情
/// </summary>
public class DictCategoryProfile
{
    /// <summary>
    /// 主键Id
    /// </summary>
    public long Id { get; set; }
    /// <summary>
    /// 备注
    /// </summary>
    public string Remark { get; set; }
    /// <summary>
    /// 分类名称
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// 分类编码
    /// </summary>
    public string Code { get; set; }
}