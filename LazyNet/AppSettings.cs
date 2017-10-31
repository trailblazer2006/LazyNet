using System.Configuration;
using Dekart.LazyNet.Helpers;

namespace Dekart.LazyNet
{
    [SettingsProvider(typeof(XpoSettingsProvider))]
    public class AppSettings : ApplicationSettingsBase
    {
        public static AppSettings Default { get; } = ((AppSettings)(Synchronized(new AppSettings())));

        [UserScopedSetting]
        [DefaultSettingValue(@"<ArrayOfFilterInfo xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <FilterInfo>
    <Name>������������</Name>
    <FilterCriteria>Contains([Title], '�����������') Or Contains([Title], '��������')</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>����������</Name>
    <FilterCriteria>Not Contains([Title], '�����������') And Not Contains([Title], '��������')</FilterCriteria>
  </FilterInfo>
</ArrayOfFilterInfo>")]
        public FilterInfoList UsersCustomFilters
        {
            get { return ((FilterInfoList) (this["UsersCustomFilters"])); }
            set { this["UsersCustomFilters"] = value; }
        }

        [DefaultSettingValue(@"<ArrayOfFilterInfo xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <FilterInfo>
    <Name>��������</Name>
    <FilterCriteria>[UserState] = ##Enum#Dekart.LazyNet.UserStateEnum,Salaried# Or [UserState] = ##Enum#Dekart.LazyNet.UserStateEnum,Freelancer# Or [UserState] = ##Enum#Dekart.LazyNet.UserStateEnum,OnLeave#</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>�������</Name>
    <FilterCriteria>[UserState] = ##Enum#Dekart.LazyNet.UserStateEnum,Salaried#</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>����������</Name>
    <FilterCriteria>[UserState] = ##Enum#Dekart.LazyNet.UserStateEnum,Freelancer#</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>� �������</Name>
    <FilterCriteria>[UserState] = ##Enum#Dekart.LazyNet.UserStateEnum,OnLeave#</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>���������</Name>
    <FilterCriteria>[UserState] = ##Enum#Dekart.LazyNet.UserStateEnum,Terminated#</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>���</Name>
  </FilterInfo>
</ArrayOfFilterInfo>")]
        [UserScopedSetting]
        public FilterInfoList UsersStaticFilters
        {
            get { return ((FilterInfoList) (this["UsersStaticFilters"])); }
            set { this["UsersStaticFilters"] = value; }
        }

        [DefaultSettingValue(@"<ArrayOfFilterInfo xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <FilterInfo>
    <Name>�� ������� ���</Name>
    <FilterCriteria>IsOutlookIntervalEarlierThisYear([CreatedOn])</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>�� ������� �����</Name>
    <FilterCriteria>IsOutlookIntervalEarlierThisMonth([CreatedOn])</FilterCriteria>
  </FilterInfo>
</ArrayOfFilterInfo>")]
        [UserScopedSetting]
        public FilterInfoList RepairsCustomFilters
        {
            get { return ((FilterInfoList) (this["RepairsCustomFilters"])); }
            set { this["RepairsCustomFilters"] = value; }
        }

        [UserScopedSetting]
        [DefaultSettingValue(@"<ArrayOfFilterInfo xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <FilterInfo>
    <Name>���</Name>
  </FilterInfo>
  <FilterInfo>
    <Name>����������� �������</Name>
    <FilterCriteria>[RepairType] = ##Enum#Dekart.LazyNet.RepairTypeEnum,WarrantyRepair#</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>������� �������</Name>
    <FilterCriteria>[RepairType] = ##Enum#Dekart.LazyNet.RepairTypeEnum,PaidRepair#</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>�������� ������������</Name>
    <FilterCriteria>[RepairType] = ##Enum#Dekart.LazyNet.RepairTypeEnum,ScheduledMaintenance#</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>������ ����������</Name>
    <FilterCriteria>[RepairType] = ##Enum#Dekart.LazyNet.RepairTypeEnum,CartridgeReplacement#</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>������</Name>
    <FilterCriteria>[RepairType] = ##Enum#Dekart.LazyNet.RepairTypeEnum,Other#</FilterCriteria>
  </FilterInfo>
</ArrayOfFilterInfo>")]
        public FilterInfoList RepairsStaticFilters
        {
            get { return (FilterInfoList) this["RepairsStaticFilters"]; }
            set { this["RepairsStaticFilters"] = value; }
        }

        [DefaultSettingValue(@"<ArrayOfFilterInfo xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <FilterInfo>
    <Name>�������� Microsoft</Name>
    <FilterCriteria>Contains([Name], 'Windows') Or Contains([Name], 'Office')</FilterCriteria>
  </FilterInfo>
</ArrayOfFilterInfo>")]
        [UserScopedSetting]
        public FilterInfoList SoftwareCustomFilters
        {
            get { return (FilterInfoList) this["SoftwareCustomFilters"]; }
            set { this["SoftwareCustomFilters"] = value; }
        }

        [UserScopedSetting]
        [DefaultSettingValue(@"<ArrayOfFilterInfo xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <FilterInfo>
    <Name>���</Name>
  </FilterInfo>
  <FilterInfo>
    <Name>������ ��������</Name>
    <FilterCriteria>[ExpiredOn] Is Null Or IsOutlookIntervalLaterThisYear([ExpiredOn]) Or IsOutlookIntervalBeyondThisYear([ExpiredOn])</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>������ �������������</Name>
    <FilterCriteria>IsOutlookIntervalEarlierThisYear([ExpiredOn]) Or IsOutlookIntervalPriorThisYear([ExpiredOn])</FilterCriteria>
  </FilterInfo>
</ArrayOfFilterInfo>")]
        public FilterInfoList SoftwareStaticFilters
        {
            get { return (FilterInfoList) this["SoftwareStaticFilters"]; }
            set { this["SoftwareStaticFilters"] = value; }
        }
    }
}