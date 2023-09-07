// MIT 许可证
// 版权 © 2023-present dym 和所有贡献者
// 作者或版权持有人都不对任何索赔、损害或其他责任负责，无论这些追责来自合同、侵权或其它行为中，
// 还是产生于、源于或有关于本软件以及本软件的使用或其它处置。

namespace PurestAdmin.Core.Entity;

/// <summary>
/// 功能实体扩展
/// </summary>
public partial class FunctionEntity
{
    /// <summary>
    /// 子集
    /// </summary>
    [SugarColumn(IsIgnore = true)]
    public List<FunctionEntity> Children { get; set; }
}