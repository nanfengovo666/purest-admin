// Copyright © 2023-present https://github.com/dymproject/purest-admin作者以及贡献者

namespace PurestAdmin.SqlSugar.Entity;

/// <summary>
/// 工作流程
/// </summary>
[SugarTable("PUREST_WF_WORKFLOW")]
public partial class WfWorkflowEntity
{
    /// <summary>
    /// 
    /// </summary>
    [SugarColumn(ColumnName = "PERSISTENCE_ID", IsPrimaryKey = true)]
    public long PersistenceId { get; set; }
    /// <summary>
    /// 
    /// </summary>
    [SugarColumn(ColumnName = "COMPLETE_TIME")]
    public DateTime? CompleteTime { get; set; }
    /// <summary>
    /// 
    /// </summary>
    [SugarColumn(ColumnName = "DATA")]
    public string Data { get; set; }
    /// <summary>
    /// 
    /// </summary>
    [SugarColumn(ColumnName = "DESCRIPTION")]
    public string Description { get; set; }
    /// <summary>
    /// 
    /// </summary>
    [SugarColumn(ColumnName = "INSTANCE_ID")]
    public string InstanceId { get; set; }
    /// <summary>
    /// 
    /// </summary>
    [SugarColumn(ColumnName = "NEXT_EXECUTION")]
    public long? NextExecution { get; set; }
    /// <summary>
    /// 
    /// </summary>
    [SugarColumn(ColumnName = "STATUS")]
    public int Status { get; set; }
    /// <summary>
    /// 
    /// </summary>
    [SugarColumn(ColumnName = "VERSION")]
    public int Version { get; set; }
    /// <summary>
    /// 
    /// </summary>
    [SugarColumn(ColumnName = "WORKFLOW_DEFINITION_ID")]
    public string WorkflowDefinitionId { get; set; }
    /// <summary>
    /// 
    /// </summary>
    [SugarColumn(ColumnName = "REFERENCE")]
    public string Reference { get; set; }
    /// <summary>
    /// 创建时间
    ///</summary>
    [SugarColumn(ColumnName = "CREATE_TIME")]
    public DateTime CreateTime { get; set; }
    /// <summary>
    /// 创建人
    ///</summary>
    [SugarColumn(ColumnName = "CREATE_BY")]
    public long CreateBy { get; set; }
    /// <summary>
    /// 备注 
    ///</summary>
    [SugarColumn(ColumnName = "REMARK")]
    public string Remark { get; set; }
}