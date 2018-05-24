using System.Collections.Generic;
using SiteServer.Plugin;
using SS.Jobs.Model;

namespace SS.Jobs.Provider
{
    public static class JobDao
    {
        public const string TableName = "ss_jobs";

        public static List<TableColumn> TableColumns => new List<TableColumn>
        {
            new TableColumn
            {
                AttributeName = JobAttribute.Department,
                DataType = DataType.VarChar,
                DataLength = 200,
                InputStyle = new InputStyle
                {
                    InputType = InputType.Text,
                    DisplayName = "所属部门",
                    IsRequired = true
                }
            },
            new TableColumn
            {
                AttributeName = JobAttribute.Location,
                DataType = DataType.VarChar,
                DataLength = 200,
                InputStyle = new InputStyle
                {
                    InputType = InputType.Text,
                    DisplayName = "工作地点",
                    IsRequired = true
                }
            },
            new TableColumn
            {
                AttributeName = JobAttribute.NumberOfPeople,
                DataType = DataType.VarChar,
                DataLength = 200,
                InputStyle = new InputStyle
                {
                    InputType = InputType.Text,
                    DisplayName = "招聘人数",
                    IsRequired = true,
                    DefaultValue = "不限"
                }
            },
            new TableColumn
            {
                AttributeName = JobAttribute.Responsibility,
                DataType = DataType.Text,
                InputStyle = new InputStyle
                {
                    InputType = InputType.TextEditor,
                    DisplayName = "工作职责",
                    IsRequired = true
                }
            },
            new TableColumn
            {
                AttributeName = JobAttribute.Requirement,
                DataType = DataType.Text,
                InputStyle = new InputStyle
                {
                    InputType = InputType.TextEditor,
                    DisplayName = "工作要求",
                    IsRequired = true
                }
            }
        };
    }
}