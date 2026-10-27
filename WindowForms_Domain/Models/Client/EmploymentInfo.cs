using System;
using System.Collections.Generic;
using WindowForms_Domain.Models.Enum;

namespace WinFormss.Domain.Models
{
    /// <summary>
    /// Класс EmploymentInfo хранит информацию о месте работы и типе занятости клиента.
    /// </summary>
    public class EmploymentInfo
    {
        /// <summary>
        /// Тип занятости (VALUE_TYPEEMPLOYMENT).
        /// </summary>
        public EnumTypeOfEmployment EmploymentType { get; set; }

        /// <summary>
        /// Наименование организации (ORGONITION_NAME).
        /// Например: "ООО Ромашка", "ИП Иванов".
        /// </summary>
        public string OrganizationName { get; set; } = string.Empty;

        /// <summary>
        /// Сфера деятельности организации (VALUE_FIELD_OF_ACTIVITY).
        /// Например: "Торговля", "Строительство", "IT".
        /// </summary>
        public string FieldOfActivity { get; set; } = string.Empty;


    }
}