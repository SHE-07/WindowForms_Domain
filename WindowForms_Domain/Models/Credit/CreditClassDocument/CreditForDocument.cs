using System;
using System.Collections.Generic;
using WindowForms_Domain.Attributes_Doc;

namespace WindowForms_Domain.Models.Credit.CreditClassDocument
{
    /// <summary>
    /// Класс Credit хранит в себе параметры кредита согласно заявлению-анкете.
    /// </summary>
    public class CreditForDocument
    {
        /// <summary>
        /// Название / тип кредита (NAME_TYPE_CREDITA).
        /// Например: "Потребительский", "Автокредит".
        /// </summary>
        [DocAttributes("NAME_TYPE_CREDITA")]
        public string NameCredit { get; set; } = string.Empty;

        /// <summary>
        /// Способ выдачи кредита (METHOD_OF_ISSUANCE).
        /// Например: "Наличными", "На банковскую карту".
        /// </summary>
        [DocAttributes("METHOD_OF_ISSUANCE")]
        public string MethodOfIssuance { get; set; } = string.Empty;

        /// <summary>
        /// Объект залога / Обеспечение (Объект_ZALOG).
        /// Например: "Поручительство", "Залог автомобиля", "Без обеспечения".
        /// </summary>
        [DocAttributes("OBJECT_ZALOG")]
        public string Collateral { get; set; } = string.Empty;

        /// <summary>
        /// Сумма кредита или кредитного лимита (AMOUNT_VALUE).
        /// Используем decimal, так как это деньги.
        /// </summary>
        [DocAttributes("AMOUNT_VALUE")]
        public decimal Amount { get; set; }

        /// <summary>
        /// Срок кредита (VALUE_TERM).
        /// Лучше хранить в месяцах для удобства расчетов.
        /// </summary>
        [DocAttributes("VALUE_TERM")]
        public int TermInMonths { get; set; }

        /// <summary>
        /// Дата окончательного погашения кредита (VALUE_FINAL_DATE_PAYMENT).
        /// </summary>
        [DocAttributes("VALUE_FINAL_DATE_PAYMENT")]
        public DateTime FinalPaymentDate { get; set; }

        /// <summary>
        /// Страхование от несчастных случаев (VALUE_BOOL_CHS).
        /// true - если клиент согласен страховаться, false - если нет.
        /// </summary>
        [DocAttributes("VALUE_BOOL_CHS")]
        public bool IsInsured { get; set; }

        /// <summary>
        /// Порядок погашения кредита (NAME_TYPE_PAYMENT).
        /// Например: "Аннуитетный", "Дифференцированный".
        /// </summary>
        [DocAttributes("NAME_TYPE_PAYMENT")]
        public string PaymentType { get; set; } = string.Empty;

        /// <summary>
        /// Процентная ставка (для расчетов)
        /// </summary>
        public decimal AnnualRate { get; set; }

       
    }
}