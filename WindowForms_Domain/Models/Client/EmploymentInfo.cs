using System;
using System.Collections.Generic;
using WindowForms_Domain.Interfaces;
using WindowForms_Domain.Models;

namespace WinFormss.Domain.Models
{
    /// <summary>
    /// Класс EmploymentInfo хранит информацию о месте работы и типе занятости клиента.
    /// </summary>
    public class EmploymentInfo : InterfaceEvent
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

        /// <summary>
        /// событие с Exception
        /// </summary>
        public event EventHandler<Exception> eventHandlerException;
        /// <summary>
        /// событие List<string>
        /// </summary>
        public event EventHandler<List<string>> eventHandlerListWithErrors;
        /// <summary>
        /// Событие EventHandler
        /// </summary>
        public event EventHandler eventhandler;
        /// <summary>
        /// Метод проверяет на null объекты или пустые строки поля класса EmploymentInfo
        /// </summary>
        /// <returns>Возвращает список ошибок, если поля являютя пустями </returns>
        public List<string> Validate()
        {
            List<string> errors = new List<string>();
            if (string.IsNullOrEmpty(this.EmploymentType.ToString()))
            {
                errors.Add("поле - Тип занятости - не может быть пустым");
            }
            if (string.IsNullOrEmpty(this.OrganizationName))
            {
                errors.Add("поле - Название организации - не может быть пустым, если организация отсутстует, то проверьте тип занятости !");
            }
            if (string.IsNullOrEmpty(this.FieldOfActivity))
            {
                errors.Add("Сфера деятельности ( услуг ) не может быть пустым !");
            }
            return errors;
        }
       
    }
}