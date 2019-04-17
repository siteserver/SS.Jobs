using System.Collections.Generic;
using Datory;
using SiteServer.Plugin;

namespace SS.Jobs
{
    public class Main : PluginBase
    {
        private const string Department = "Department";
        private const string Location = "Location";
        private const string NumberOfPeople = "NumberOfPeople";
        private const string Responsibility = "Responsibility";
        private const string Requirement = "Requirement";

        public override void Startup(IService service)
        {
            service.AddContentModel("ss_jobs", new List<TableColumn>
            {
                new TableColumn
                {
                    AttributeName = Department,
                    DataType = DataType.VarChar,
                    DataLength = 200
                },
                new TableColumn
                {
                    AttributeName = Location,
                    DataType = DataType.VarChar,
                    DataLength = 200
                },
                new TableColumn
                {
                    AttributeName = NumberOfPeople,
                    DataType = DataType.VarChar,
                    DataLength = 200
                },
                new TableColumn
                {
                    AttributeName = Responsibility,
                    DataType = DataType.Text
                },
                new TableColumn
                {
                    AttributeName = Requirement,
                    DataType = DataType.Text
                }
            }, new List<InputStyle>
            {
                new InputStyle
                {
                    InputType = InputType.Text,
                    DisplayName = "所属部门",
                    IsRequired = true
                },
                new InputStyle
                {
                    InputType = InputType.Text,
                    DisplayName = "工作地点",
                    IsRequired = true
                },
                new InputStyle
                {
                    InputType = InputType.Text,
                    DisplayName = "招聘人数",
                    IsRequired = true,
                    DefaultValue = "不限"
                },
                new InputStyle
                {
                    InputType = InputType.TextEditor,
                    DisplayName = "工作职责",
                    IsRequired = true
                },
                new InputStyle
                {
                    InputType = InputType.TextEditor,
                    DisplayName = "工作要求",
                    IsRequired = true
                }
            });
        }
    }
}