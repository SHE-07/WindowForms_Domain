using System;
using System.Collections.Generic;

namespace WinFormss.Domain.Models
{
    /// <summary>
    /// Класс Passport хранит паспортные данные клиента.
    /// </summary>
    public class Passport
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
        /// Код подразделения (если требуется). 
        /// </summary>
        public string DepartmentCode { get; set; } = string.Empty;

    }
}