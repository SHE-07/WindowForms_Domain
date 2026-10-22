using System;
using System.Collections.Generic;
using WindowForms_Domain.Models.Enum;


namespace WindowForms_Domain.Models.Client
{
    /// <summary>
    /// Кдасс Client хранит  в себе все данные о клиенте.
    /// </summary>
    public class Client
    {
        /// <summary>
        ///  Фамилии клиента
        /// </summary>
        public string First_name { get; set; } = string.Empty;
        /// <summary>
        ///  Имя клиента
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
        public string MobilePhone { get; set; } = string.Empty;          // NUMBERPHONE
        /// <summary>
        /// Електронная почта заявителя
        /// </summary>
        public string Email { get; set; } = string.Empty;                // VALUE_EMAIL_USER

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
        /// Метод проверяет на null объекты или пустые строки поля класса Client
        /// </summary>
        /// <returns>Возвращает список ошибок, если поля являютя пустями </returns>
        public List<string> Validate()
        {
            List<string> errors = new List<string>();
            List<string> errors_1 = this.Passport_.Validate();
            List<string> errors_2 = this.EmploymentInfo.Validate();
            if (string.IsNullOrEmpty(this.First_name))
            {
                errors.Add("поле - Фамилия - не может быть пустым");
            }
            if (string.IsNullOrEmpty(this.Last_name))
            {
                errors.Add("поле - Имя - не может быть пустым !");
            }
            if (string.IsNullOrEmpty(this.Middle_name))
            {
                errors.Add("поле - Отчество - не может быть пустым  !");
            }
            if (this.EnumTypeOfEmployment.HasFlag(EnumTypeOfEmployment))
            {
                errors.Add("поле - Отчество - не может быть пустым  !");
            }
            if (string.IsNullOrEmpty(this.MobilePhone))
            {
                errors.Add("поле - номер телефона не может быть пустым !");
            }
            if (string.IsNullOrEmpty(this.Email))
            {
                errors.Add("Поле - почта - не может быть пустым !");
            }
            if (errors_1.Count > 0) AddListErrors(ref errors, errors_1);
            if (errors_2.Count > 0) AddListErrors(ref errors, errors_2);
            return errors;
        }
        /// <summary>
        /// Метод который заполняет имеющийся список ошибок другим списком ошибок, меняя изначальных список 
        /// </summary>
        /// <param name="errors_old"></param>
        /// <param name="errors_new"></param>
        private void AddListErrors(ref List<string> errors_old, List<string> errors_new)
        {
            for (int index = 0; index < errors_old.Count; index++)
            {
                errors_old.Add(errors_new[index]);
            }
        }

    }
}
