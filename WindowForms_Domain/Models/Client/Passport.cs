using System;
using System.Collections.Generic;
using WindowForms_Domain.Interfaces;

namespace WinFormss.Domain.Models
{
    /// <summary>
    /// Класс Passport хранит паспортные данные клиента.
    /// </summary>
    public class Passport : InterfaceEvent
    {
        /// <summary>
        /// Регистрация по паспорту
        /// </summary>
        public string RegistrationAddress { get; set; } = string.Empty;  // PASSPORTREGISTRATION
        /// <summary>
        /// Серия и номер паспорта (PASSPORT_SERIES_NUMBER).
        /// Например: "MP1234567".
        /// </summary>
        public string SeriesAndNumber { get; set; } = string.Empty;

        /// <summary>
        /// Кем выдан паспорт (ISSUEDBY).
        /// Например: "Первомайский РУВД г. Минска".
        /// </summary>
        public string IssuedBy { get; set; } = string.Empty;

        /// <summary>
        /// Дата выдачи паспорта (ISSUEDATA).
        /// </summary>
        public DateTime IssueDate { get; set; }


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
        /// Код подразделения (если требуется). 

        /// </summary>
        public string DepartmentCode { get; set; } = string.Empty;
        /// <summary>
        ///     Метод проверяющий на пустое или пустую строку поля класса Passport
        /// </summary>
        /// <returns>
        ///     Возвращает пустой список если все поля заполнены, 
        ///     иначе список ошибок с описанием полей которые пусты
        /// </returns>
        public List<string> Validate()
        {
            List<string> Errors = new List<string>();
            if (string.IsNullOrEmpty(this.SeriesAndNumber))
            {
                Errors.Add("Поле серия и номер не могут быть пустыми");
            }
            if (string.IsNullOrEmpty(this.IssueDate.ToString()))
            {
                Errors.Add($"Дата выдачи не может быть пустой");
            }
            if (string.IsNullOrEmpty(this.IssuedBy))
            {
                Errors.Add("Поле кем выдан не может быть пустым !");
            }
            return Errors;
        }
      
    }
}