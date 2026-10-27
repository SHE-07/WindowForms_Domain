using System;
using System.Collections.Generic;
using WindowForms_Domain.Models.Enum;

namespace WindowForms_Domain.Models.Client
{
    /// <summary>
    /// Класс Client хранит в себе все данные о клиенте.
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Фамилия клиента
        /// </summary>
        public string First_name { get; set; } = string.Empty;
        /// <summary>
        /// Имя клиента
        /// </summary>
        public string Last_name { get; set; } = string.Empty;
        /// <summary>
        /// Отчество клиента
        /// </summary>
        public string Middle_name { get; set; } = string.Empty;
        /// <summary>
        /// тип занятости клиента
        /// </summary>
        public EnumTypeOfEmployment EnumTypeOfEmployment { get; set; } = EnumTypeOfEmployment.Employment_related_work;
        /// <summary>
        /// Объект паспорт клиента 
        /// </summary>
        public WinFormss.Domain.Models.Passport Passport_ { get; set; } = null;
        /// <summary>
        /// Объект информация о работе клиента
        /// </summary>
        public WinFormss.Domain.Models.EmploymentInfo EmploymentInfo { get; set; } = null;

        /// <summary>
        /// Номер телефона заявителя
        /// </summary>
        public string MobilePhone { get; set; } = string.Empty;
        /// <summary>
        /// Электронная почта заявителя
        /// </summary>
        public string Email { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public string Citizenship { get; set; } = string.Empty;
        public string StatusFamily { get; set; } = string.Empty;
    }
}